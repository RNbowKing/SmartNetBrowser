﻿Imports System.ComponentModel

Public Class EnterBrowserSettingsSecurityForm
    Public Sub New()
        InitializeComponent()
    End Sub

    Public SecurityMode As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If BrowserForm.GetSHA512(PasswordTextBox.Text) = My.Settings.BrowserSettingsSecurityPassword Then
            Select Case SecurityMode
                Case "Settings"
                    SettingsForm.Show()
                Case "History"
                    UserDataLibraryForm.TabControl1.SelectTab(0)
                    UserDataLibraryForm.Show()
                Case "Favorites"
                    UserDataLibraryForm.TabControl1.SelectTab(1)
                    UserDataLibraryForm.Show()
                Case "SearchHistory"
                    UserDataLibraryForm.TabControl1.SelectTab(2)
                    UserDataLibraryForm.Show()
                Case "DownloadHistory"
                    UserDataLibraryForm.TabControl1.SelectTab(3)
                    UserDataLibraryForm.Show()
                Case Else
                    MsgBox("Un problème est survenu, réessayez.")
            End Select
            Me.Close()
        Else
            MsgBox("Mot de passe incorrect", MsgBoxStyle.Critical, "SmartNet Browser Protection des paramètres - Saisie du mot de passe")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AbortButton.Click
        Me.Close()
    End Sub

    Private Sub EnterBrowserSettingsSecurityForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PasswordTextBox.Text = ""
    End Sub
End Class