﻿Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports Gecko
Imports Gecko.Events

Public Class CustomBrowser
    Inherits Gecko.GeckoWebBrowser
    Public PointedElement As Gecko.GeckoElement
    Public Favicon As Image

    Public Sub New()
        MyBase.New()
        Me.NoDefaultContextMenu = True
        Me.ContextMenuStrip = BrowserForm.BrowserContextMenuStrip
        Favicon = My.Resources.ErrorFavicon
    End Sub

    Private Sub UpdateInterface()
        BrowserForm.BrowserTabs.ImageList.Images.Item(CType(Me.Tag, TabPage).TabIndex) = New Bitmap(Favicon, 16, 16)
        CType(Me.Tag, TabPage).ImageIndex = CType(Me.Tag, TabPage).TabIndex

        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.UpdateInterface()
        Else
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub

    ''' <summary>
    ''' Indique si la page ou le cadre est une publicité.
    ''' </summary>
    ''' <param name="url">URL de la page ou du cadre.</param>
    ''' <returns></returns>
    Public Function IsAdvertisement(url As String) As Boolean
        Try
            Dim AdsDomainsFileDownloader As New WebClient
            Dim AdsDomainsListFile As String = AdsDomainsFileDownloader.DownloadString("http://adsblocker.smartnetapps.quentinpugeat.fr/v1/AdsDomains.txt")
            Dim AdsDomainsList As New List(Of String)(AdsDomainsListFile.Split(","c))
            For Each domain In AdsDomainsList
                If url.Contains(domain) Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            BrowserForm.msgBar = New MessageBar(MessageBar.MessageBarLevel.Warning, "SmartNet AdsBlocker a rencontré une erreur. (" + ex.Message + ")", MessageBar.MessageBarAction.OpenExceptionForm, "Voir les détails", ex)
            BrowserForm.DisplayMessageBar()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Indique si la page est dangereuse pour les enfants.
    ''' </summary>
    ''' <param name="url">URL de la page à tester</param>
    ''' <returns></returns>
    Public Function IsDangerousForChildren(url As String) As Boolean
        Try
            Dim AdultDomainsFile As New WebClient
            Dim AdultDomainsListFile As String = AdultDomainsFile.DownloadString("http://childguard.smartnetapps.quentinpugeat.fr/v1/ChildrenProtection.txt")
            Dim AdultDomainsList As New List(Of String)(AdultDomainsListFile.Split(","c))
            For Each domain In AdultDomainsList
                If url.Contains(domain) Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            BrowserForm.msgBar = New MessageBar(MessageBar.MessageBarLevel.Critical, "SmartNet ChildGuard a rencontré une erreur. (" + ex.Message + ")", MessageBar.MessageBarAction.OpenExceptionForm, "Voir les détails", ex)
            BrowserForm.DisplayMessageBar()
            Return False
        End Try
    End Function

    Private Sub CustomBrowser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F5
                    Reload()
                Case Keys.BrowserBack
                    GoBack()
                Case Keys.BrowserFavorites
                    If My.Settings.HistoryFavoritesSecurity = True Then
                        EnterBrowserSettingsSecurityForm.SecurityMode = "Favorites"
                        EnterBrowserSettingsSecurityForm.ShowDialog()
                    Else
                        NewHistoryForm.TabControl1.SelectTab(1)
                        NewHistoryForm.Show()
                    End If
                Case Keys.BrowserForward
                    GoForward()
                Case Keys.BrowserHome
                    BrowserForm.AddTab(My.Settings.Homepage)
                Case Keys.BrowserRefresh
                    Reload()
                Case Keys.BrowserSearch
                    BrowserForm.SearchBox.Focus()
                    BrowserForm.SearchBoxLabel.Visible = False
                Case Keys.BrowserStop
                    Me.Stop()
                Case Keys.Print
                    Navigate("javascript.print()")
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BrowserNavigating(ByVal sender As Object, ByVal e As GeckoNavigatingEventArgs) Handles Me.Navigating
        Favicon = My.Resources.ErrorFavicon

        If My.Settings.ChildrenProtection = True AndAlso IsDangerousForChildren(e.Uri.ToString()) = True Then
            Dim Language As String = Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName
            If File.Exists(My.Application.Info.DirectoryPath + "\ChildGuard\" + Language + ".html") Then
                Me.Navigate("file:///" + My.Application.Info.DirectoryPath + "\ChildGuard\" + Language + ".html")
            Else
                Me.Navigate("file:///" + My.Application.Info.DirectoryPath + "\ChildGuard\en.html")
            End If
        End If

        If My.Settings.PopUpBlocker = True And Me.GetContextFlagsAttribute() = GeckoWindowFlags.WindowPopup AndAlso My.Settings.AdBlockerWhitelist.Contains(e.Uri.Host) = False AndAlso IsAdvertisement(e.Uri.ToString()) Then
            Dim url As String = e.Uri.ToString()
            BrowserForm.BrowserTabs.TabPages.Remove(CType(Me.Tag, TabPage))
            BrowserForm.msgBar = New MessageBar(MessageBar.MessageBarLevel.Info, "SmartNet Browser a empêché l'ouverture d'une fenêtre publicitaire.", MessageBar.MessageBarAction.OpenPopup, "Ouvrir quand même", url)
            BrowserForm.DisplayMessageBar()
            Me.Dispose()
        End If

        If e.Uri.ToString.Contains("window.close") Then
            If BrowserForm.BrowserTabs.TabPages.Count > 1 Then
                BrowserForm.BrowserTabs.TabPages.Remove(BrowserForm.BrowserTabs.SelectedTab)
            Else
                If MsgBox("Le site Web tente de fermer la fenêtre. Voulez-vous continuer ? (Si vous cliquez sur non, vous serez redirigé vers la page d'accueil)", MsgBoxStyle.YesNo, "Fermeture de la fenêtre") = MsgBoxResult.Yes Then
                    Application.Exit()
                Else
                    Me.Navigate(My.Settings.Homepage)
                End If
            End If

            UpdateInterface()
        End If
    End Sub

    Private Sub CustomBrowser_DomContentChanged(sender As Object, e As DomEventArgs) Handles Me.DomContentChanged
        If Not BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub

    Private Sub CustomBrowser_DOMContentLoaded(sender As Object, e As DomEventArgs) Handles Me.DOMContentLoaded
        Favicon = GetCurrentPageFavicon()
        If My.Settings.PrivateBrowsing = False And Not (Me.Url.ToString().Contains(My.Application.Info.DirectoryPath.Replace("\", "/")) Or Me.Url.ToString().Contains("about:")) Then
            BrowserForm.AddInHistory(New WebPage(Me.DocumentTitle, Me.Url.ToString()))
        End If
        UpdateInterface()
    End Sub

    Private Sub BrowserDocumentCompleted(ByVal sender As System.Object, ByVal e As GeckoDocumentCompletedEventArgs) Handles Me.DocumentCompleted
        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.StopOrRefreshButton.Image = My.Resources.RefreshBlack
            BrowserForm.LoadingGif.Visible = False
            BrowserForm.UpdateInterface()
        Else
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub

    Private Sub CustomBrowser_NewWindow(sender As Object, e As Gecko.GeckoCreateWindowEventArgs) Handles Me.CreateWindow
        Dim NewBrowser As New CustomBrowser
        NewBrowser.SetContextFlagsAttribute(CType(GeckoWindowFlags.WindowPopup, UInteger))
        e.WebBrowser = NewBrowser
        BrowserForm.AddTab(NewBrowser)
    End Sub

    Private Sub CustomBrowser_FrameNavigating(sender As Object, e As GeckoNavigatingEventArgs) Handles Me.FrameNavigating
        If (My.Settings.AdBlocker = True And My.Settings.AdBlockerWhitelist.Contains(Me.Url.Host) = False AndAlso IsAdvertisement(e.Uri.ToString()) = True) Or (My.Settings.ChildrenProtection = True AndAlso IsDangerousForChildren(e.Uri.ToString())) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub CustomBrowser_DomMouseMove(sender As Object, e As Gecko.DomMouseEventArgs) Handles Me.DomMouseMove
        PointedElement = DomDocument.ElementFromPoint(e.ClientX, e.ClientY)
    End Sub

    Private Sub CustomBrowser_StatusTextChanged(sender As Object, e As EventArgs) Handles Me.StatusTextChanged
        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.StatusLabel.Text = Me.StatusText
        End If
    End Sub

    Private Sub CustomBrowser_DocumentTitleChanged(sender As Object, e As EventArgs) Handles Me.DocumentTitleChanged
        Dim doctitle As String
        If DocumentTitle = "" Then
            doctitle = Url.ToString()
        Else
            doctitle = DocumentTitle
        End If

        If doctitle.Length > 30 Then
            doctitle = doctitle.Substring(0, 26) & "..."
        End If

        CType(Me.Tag, TabPage).Text = doctitle

        If CType(Me.Tag, TabPage).TabIndex = BrowserForm.BrowserTabs.SelectedTab.TabIndex Then
            BrowserForm.Text = DocumentTitle + " - SmartNet Browser"
        End If
    End Sub

    Private Sub CustomBrowser_CanGoBackChanged(sender As Object, e As EventArgs) Handles Me.CanGoBackChanged
        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.PreviouspageButton.Enabled = CanGoBack
        Else
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub
    Private Sub CustomBrowser_CanGoForwardChanged(sender As Object, e As EventArgs) Handles Me.CanGoForwardChanged
        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.NextpageButton.Enabled = CanGoForward
        Else
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub

    ''' <summary>
    ''' Favicon de la page actuellement chargée
    ''' </summary>
    ''' <returns>Favicon de la page actuellement chargée</returns>
    Public Function GetCurrentPageFavicon() As Image
        Dim faviconPath As String
        Try
            If Me.Url.ToString.Contains(My.Application.Info.DirectoryPath.Replace("\", "/")) Or Me.Url.ToString.Contains("about:") Then
                Return My.Resources._2019_SmartNetBrowser_32
            Else
                Try
                    Dim metaLinks As GeckoElementCollection = Me.DomDocument.GetElementsByTagName("LINK")
                    For Each element In metaLinks
                        If element.GetAttribute("REL").ToUpper() = "ICON" Then
                            faviconPath = element.GetAttribute("HREF")
                            If faviconPath.Contains("://") = False Then
                                If Me.Url.Host.Contains("/") Or faviconPath.Substring(0, 1) = "/" Then
                                    faviconPath = "http://" + Me.Url.Host + faviconPath
                                Else
                                    faviconPath = "http://" + Me.Url.Host + "/" + faviconPath
                                End If
                            End If
                            GoTo FaviconFound
                        End If
                    Next
                Catch ex As Exception
                    GoTo FaviconNotFound
                End Try
FaviconNotFound:
                If Me.Url.HostNameType = UriHostNameType.Dns Then
                    faviconPath = "http://" & Me.Url.Host & "/favicon.ico"
                Else
                    Return My.Resources.ErrorFavicon
                End If
FaviconFound:
                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(faviconPath)
                Dim response As System.Net.HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim stream As System.IO.Stream = response.GetResponseStream()
                Dim favicon = Image.FromStream(stream)
                Return favicon
            End If
        Catch ex As Exception
            Return My.Resources.ErrorFavicon
        End Try
    End Function

    Private Sub CustomBrowser_NavigationError(sender As Object, e As GeckoNavigationErrorEventArgs) Handles MyBase.NavigationError
        Select Case e.ErrorCode
            'Case -2142568446
            '    BrowserForm.StopButton.Visible = False
            '    BrowserForm.RefreshButton.Visible = True
            Case -2142568418
                If System.IO.File.Exists(My.Application.Info.DirectoryPath + "/404/" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".html") Then
                    Navigate("file:///" + My.Application.Info.DirectoryPath.Replace("\", "/") + "/404/" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".html")
                Else
                    Navigate("file:///" + My.Application.Info.DirectoryPath.Replace("\", "/") + "/404/en.html")
                End If
                BrowserForm.URLBox.Text = e.Uri
            Case -2142568435
                Console.WriteLine("Refus de connexion sur " + e.Uri + " (Code d'erreur " + e.ErrorCode.ToString() + ")")
            Case Else
                Console.WriteLine("Erreur de navigation inconnue sur " + e.Uri + " (Code d'erreur " + e.ErrorCode.ToString() + ")")
        End Select
    End Sub

    Private Sub CustomBrowser_NSSError(sender As Object, e As GeckoNSSErrorEventArgs) Handles MyBase.NSSError
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "/404/" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".html") Then
            Navigate("file:///" + My.Application.Info.DirectoryPath.Replace("\", "/") + "/CertificateError/" + My.Computer.Info.InstalledUICulture.TwoLetterISOLanguageName + ".html")
        Else
            Navigate("file:///" + My.Application.Info.DirectoryPath.Replace("\", "/") + "/CertificateError/en.html")
        End If
        BrowserForm.URLBox.Text = e.Uri.ToString()
        Console.WriteLine("Erreur de certificat non identifiée. Code d'erreur : " + e.ErrorCode.ToString())
    End Sub

    Private Sub CustomBrowser_ReadyStateChange(sender As Object, e As DomEventArgs) Handles Me.ReadyStateChange
        If BrowserForm.BrowserTabs.SelectedIndex = CType(Me.Tag, TabPage).TabIndex Then
            BrowserForm.UpdateInterface()
        Else
            CType(Me.Tag, TabPage).BackColor = Color.LightYellow
        End If
    End Sub
End Class
