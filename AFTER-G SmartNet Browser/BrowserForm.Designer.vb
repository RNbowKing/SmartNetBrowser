﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrowserForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    ''' <summary>
    ''' Procédure requise pour le concepteur Windows Forms.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserForm))
        Me.MainToolbar = New System.Windows.Forms.MenuStrip()
        Me.MainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperçuAvantImpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉditionSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SélectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.RechercherDansLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom75 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom125 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom150 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom175 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom200 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom300 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Zoom400 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomPlusButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomMinusButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TéléchargerCetteVidéoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FavorisSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLesFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterCettePageDansLesFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLhistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PleinÉcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterLePleinÉcranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentreDaideEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContacterLéquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÀProposDeSmartNetBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyerVosCommentairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleVersionDisponibleSubMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TéléchargerLaVersionXXXXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerSmartNetBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomepageButton = New System.Windows.Forms.PictureBox()
        Me.PreviouspageButton = New System.Windows.Forms.PictureBox()
        Me.NextpageButton = New System.Windows.Forms.PictureBox()
        Me.FaviconBox = New System.Windows.Forms.PictureBox()
        Me.URLBox = New System.Windows.Forms.ComboBox()
        Me.SearchBox = New System.Windows.Forms.ComboBox()
        Me.RefreshButton = New System.Windows.Forms.PictureBox()
        Me.StopButton = New System.Windows.Forms.PictureBox()
        Me.GoButton = New System.Windows.Forms.PictureBox()
        Me.SearchButton = New System.Windows.Forms.PictureBox()
        Me.CloseTabButton = New System.Windows.Forms.PictureBox()
        Me.NewTabButton = New System.Windows.Forms.PictureBox()
        Me.UpdateNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PreviousPageButtonDisabled = New System.Windows.Forms.PictureBox()
        Me.NextPageButtonDisabled = New System.Windows.Forms.PictureBox()
        Me.BrowserContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OuvrirLeLienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLadresseDuLienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterLeLienAuxFavorisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierLadresseDeLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ActualiserLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropriétésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLeCodeSourceDeLaPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveImageDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SavePageDialog = New System.Windows.Forms.SaveFileDialog()
        Me.BrowserTabs = New System.Windows.Forms.TabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabsContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FermerCetOngletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RouvrirLeDernierOngletFerméToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritesButton = New System.Windows.Forms.PictureBox()
        Me.LoadingGif = New System.Windows.Forms.PictureBox()
        Me.SearchBoxLabel = New System.Windows.Forms.Label()
        Me.URLBoxLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.MessageBarPictureBox = New System.Windows.Forms.PictureBox()
        Me.MessageBarLabel1 = New System.Windows.Forms.Label()
        Me.MessageBarButton1 = New System.Windows.Forms.Button()
        Me.MessageBarCloseButton1 = New System.Windows.Forms.PictureBox()
        Me.GardeFouTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SignalerUnSiteMalveillantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainToolbar.SuspendLayout()
        CType(Me.HomepageButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviouspageButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextpageButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaviconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseTabButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewTabButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousPageButtonDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextPageButtonDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrowserContextMenuStrip.SuspendLayout()
        Me.TabsContextMenuStrip.SuspendLayout()
        CType(Me.FavoritesButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageBarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageBarCloseButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainToolbar
        '
        Me.MainToolbar.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.MainToolbar, "MainToolbar")
        Me.MainToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu})
        Me.MainToolbar.Name = "MainToolbar"
        '
        'MainMenu
        '
        Me.MainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenPageToolStripMenuItem, Me.SavePageToolStripMenuItem, Me.AperçuAvantImpressionToolStripMenuItem, Me.EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem, Me.ÉditionSubMenu, Me.ZoomToolStripMenuItem, Me.ToolStripSeparator2, Me.TéléchargerCetteVidéoToolStripMenuItem, Me.ToolStripSeparator6, Me.FavorisSubMenu, Me.AfficherLhistoriqueToolStripMenuItem, Me.ToolStripSeparator4, Me.PleinÉcranToolStripMenuItem, Me.QuitterLePleinÉcranToolStripMenuItem, Me.ToolStripSeparator3, Me.ParamètresToolStripMenuItem, Me.SupportToolStripMenuItem, Me.NouvelleVersionDisponibleSubMenu, Me.FermerSmartNetBrowserToolStripMenuItem})
        resources.ApplyResources(Me.MainMenu, "MainMenu")
        Me.MainMenu.Name = "MainMenu"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.NewTabBlack
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        resources.ApplyResources(Me.NewTabToolStripMenuItem, "NewTabToolStripMenuItem")
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.CloseTabBlack
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        resources.ApplyResources(Me.CloseTabToolStripMenuItem, "CloseTabToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'OpenPageToolStripMenuItem
        '
        Me.OpenPageToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Ouvrir_un_document
        Me.OpenPageToolStripMenuItem.Name = "OpenPageToolStripMenuItem"
        resources.ApplyResources(Me.OpenPageToolStripMenuItem, "OpenPageToolStripMenuItem")
        '
        'SavePageToolStripMenuItem
        '
        Me.SavePageToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Enregistrer_la_page_sous
        Me.SavePageToolStripMenuItem.Name = "SavePageToolStripMenuItem"
        resources.ApplyResources(Me.SavePageToolStripMenuItem, "SavePageToolStripMenuItem")
        '
        'AperçuAvantImpressionToolStripMenuItem
        '
        Me.AperçuAvantImpressionToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Imprimer_la_page
        Me.AperçuAvantImpressionToolStripMenuItem.Name = "AperçuAvantImpressionToolStripMenuItem"
        resources.ApplyResources(Me.AperçuAvantImpressionToolStripMenuItem, "AperçuAvantImpressionToolStripMenuItem")
        '
        'EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem
        '
        Me.EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Envoyer_par_email
        Me.EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem.Name = "EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem"
        resources.ApplyResources(Me.EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem, "EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem")
        '
        'ÉditionSubMenu
        '
        Me.ÉditionSubMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CouperToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.SélectionnerToutToolStripMenuItem, Me.ToolStripSeparator9, Me.RechercherDansLaPageToolStripMenuItem})
        Me.ÉditionSubMenu.Name = "ÉditionSubMenu"
        resources.ApplyResources(Me.ÉditionSubMenu, "ÉditionSubMenu")
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.couper
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        resources.ApplyResources(Me.CouperToolStripMenuItem, "CouperToolStripMenuItem")
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.copier
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        resources.ApplyResources(Me.CopierToolStripMenuItem, "CopierToolStripMenuItem")
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.coller
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        resources.ApplyResources(Me.CollerToolStripMenuItem, "CollerToolStripMenuItem")
        '
        'SélectionnerToutToolStripMenuItem
        '
        Me.SélectionnerToutToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.selectionner_tout
        Me.SélectionnerToutToolStripMenuItem.Name = "SélectionnerToutToolStripMenuItem"
        resources.ApplyResources(Me.SélectionnerToutToolStripMenuItem, "SélectionnerToutToolStripMenuItem")
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        resources.ApplyResources(Me.ToolStripSeparator9, "ToolStripSeparator9")
        '
        'RechercherDansLaPageToolStripMenuItem
        '
        Me.RechercherDansLaPageToolStripMenuItem.Name = "RechercherDansLaPageToolStripMenuItem"
        resources.ApplyResources(Me.RechercherDansLaPageToolStripMenuItem, "RechercherDansLaPageToolStripMenuItem")
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Zoom50, Me.Zoom75, Me.Zoom100, Me.Zoom125, Me.Zoom150, Me.Zoom175, Me.Zoom200, Me.Zoom250, Me.Zoom300, Me.Zoom400, Me.ToolStripSeparator8, Me.ZoomPlusButton, Me.ZoomMinusButton})
        resources.ApplyResources(Me.ZoomToolStripMenuItem, "ZoomToolStripMenuItem")
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        '
        'Zoom50
        '
        Me.Zoom50.Name = "Zoom50"
        resources.ApplyResources(Me.Zoom50, "Zoom50")
        '
        'Zoom75
        '
        Me.Zoom75.Name = "Zoom75"
        resources.ApplyResources(Me.Zoom75, "Zoom75")
        '
        'Zoom100
        '
        Me.Zoom100.Name = "Zoom100"
        resources.ApplyResources(Me.Zoom100, "Zoom100")
        '
        'Zoom125
        '
        Me.Zoom125.Name = "Zoom125"
        resources.ApplyResources(Me.Zoom125, "Zoom125")
        '
        'Zoom150
        '
        Me.Zoom150.Name = "Zoom150"
        resources.ApplyResources(Me.Zoom150, "Zoom150")
        '
        'Zoom175
        '
        Me.Zoom175.Name = "Zoom175"
        resources.ApplyResources(Me.Zoom175, "Zoom175")
        '
        'Zoom200
        '
        Me.Zoom200.Name = "Zoom200"
        resources.ApplyResources(Me.Zoom200, "Zoom200")
        '
        'Zoom250
        '
        Me.Zoom250.Name = "Zoom250"
        resources.ApplyResources(Me.Zoom250, "Zoom250")
        '
        'Zoom300
        '
        Me.Zoom300.Name = "Zoom300"
        resources.ApplyResources(Me.Zoom300, "Zoom300")
        '
        'Zoom400
        '
        Me.Zoom400.Name = "Zoom400"
        resources.ApplyResources(Me.Zoom400, "Zoom400")
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        resources.ApplyResources(Me.ToolStripSeparator8, "ToolStripSeparator8")
        '
        'ZoomPlusButton
        '
        Me.ZoomPlusButton.Name = "ZoomPlusButton"
        resources.ApplyResources(Me.ZoomPlusButton, "ZoomPlusButton")
        '
        'ZoomMinusButton
        '
        Me.ZoomMinusButton.Name = "ZoomMinusButton"
        resources.ApplyResources(Me.ZoomMinusButton, "ZoomMinusButton")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'TéléchargerCetteVidéoToolStripMenuItem
        '
        Me.TéléchargerCetteVidéoToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Télécharger_cette_vidéo
        Me.TéléchargerCetteVidéoToolStripMenuItem.Name = "TéléchargerCetteVidéoToolStripMenuItem"
        resources.ApplyResources(Me.TéléchargerCetteVidéoToolStripMenuItem, "TéléchargerCetteVidéoToolStripMenuItem")
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'FavorisSubMenu
        '
        Me.FavorisSubMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfficherLesFavorisToolStripMenuItem, Me.AjouterCettePageDansLesFavorisToolStripMenuItem})
        Me.FavorisSubMenu.Image = Global.SmartNet_Browser.My.Resources.Resources.Favoris
        Me.FavorisSubMenu.Name = "FavorisSubMenu"
        resources.ApplyResources(Me.FavorisSubMenu, "FavorisSubMenu")
        '
        'AfficherLesFavorisToolStripMenuItem
        '
        Me.AfficherLesFavorisToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.FavoritesYellow
        Me.AfficherLesFavorisToolStripMenuItem.Name = "AfficherLesFavorisToolStripMenuItem"
        resources.ApplyResources(Me.AfficherLesFavorisToolStripMenuItem, "AfficherLesFavorisToolStripMenuItem")
        '
        'AjouterCettePageDansLesFavorisToolStripMenuItem
        '
        Me.AjouterCettePageDansLesFavorisToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Ajouter_cette_page_dans_les_favoris
        Me.AjouterCettePageDansLesFavorisToolStripMenuItem.Name = "AjouterCettePageDansLesFavorisToolStripMenuItem"
        resources.ApplyResources(Me.AjouterCettePageDansLesFavorisToolStripMenuItem, "AjouterCettePageDansLesFavorisToolStripMenuItem")
        '
        'AfficherLhistoriqueToolStripMenuItem
        '
        Me.AfficherLhistoriqueToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Afficher_l_historique
        Me.AfficherLhistoriqueToolStripMenuItem.Name = "AfficherLhistoriqueToolStripMenuItem"
        resources.ApplyResources(Me.AfficherLhistoriqueToolStripMenuItem, "AfficherLhistoriqueToolStripMenuItem")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'PleinÉcranToolStripMenuItem
        '
        Me.PleinÉcranToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Plein_écran
        Me.PleinÉcranToolStripMenuItem.Name = "PleinÉcranToolStripMenuItem"
        resources.ApplyResources(Me.PleinÉcranToolStripMenuItem, "PleinÉcranToolStripMenuItem")
        '
        'QuitterLePleinÉcranToolStripMenuItem
        '
        resources.ApplyResources(Me.QuitterLePleinÉcranToolStripMenuItem, "QuitterLePleinÉcranToolStripMenuItem")
        Me.QuitterLePleinÉcranToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Quitter_le_plein_écran
        Me.QuitterLePleinÉcranToolStripMenuItem.Name = "QuitterLePleinÉcranToolStripMenuItem"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Paramètres
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        resources.ApplyResources(Me.ParamètresToolStripMenuItem, "ParamètresToolStripMenuItem")
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentreDaideEnLigneToolStripMenuItem, Me.ContacterLéquipeToolStripMenuItem, Me.ToolStripSeparator5, Me.ÀProposDeSmartNetBrowserToolStripMenuItem, Me.EnvoyerVosCommentairesToolStripMenuItem, Me.ToolStripSeparator10, Me.SignalerUnSiteMalveillantToolStripMenuItem})
        Me.SupportToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Aide
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        resources.ApplyResources(Me.SupportToolStripMenuItem, "SupportToolStripMenuItem")
        '
        'CentreDaideEnLigneToolStripMenuItem
        '
        Me.CentreDaideEnLigneToolStripMenuItem.Name = "CentreDaideEnLigneToolStripMenuItem"
        resources.ApplyResources(Me.CentreDaideEnLigneToolStripMenuItem, "CentreDaideEnLigneToolStripMenuItem")
        '
        'ContacterLéquipeToolStripMenuItem
        '
        Me.ContacterLéquipeToolStripMenuItem.Name = "ContacterLéquipeToolStripMenuItem"
        resources.ApplyResources(Me.ContacterLéquipeToolStripMenuItem, "ContacterLéquipeToolStripMenuItem")
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'ÀProposDeSmartNetBrowserToolStripMenuItem
        '
        Me.ÀProposDeSmartNetBrowserToolStripMenuItem.Name = "ÀProposDeSmartNetBrowserToolStripMenuItem"
        resources.ApplyResources(Me.ÀProposDeSmartNetBrowserToolStripMenuItem, "ÀProposDeSmartNetBrowserToolStripMenuItem")
        '
        'EnvoyerVosCommentairesToolStripMenuItem
        '
        Me.EnvoyerVosCommentairesToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Envoyer_vos_commentaires
        Me.EnvoyerVosCommentairesToolStripMenuItem.Name = "EnvoyerVosCommentairesToolStripMenuItem"
        resources.ApplyResources(Me.EnvoyerVosCommentairesToolStripMenuItem, "EnvoyerVosCommentairesToolStripMenuItem")
        '
        'NouvelleVersionDisponibleSubMenu
        '
        Me.NouvelleVersionDisponibleSubMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerLaVersionXXXXToolStripMenuItem})
        resources.ApplyResources(Me.NouvelleVersionDisponibleSubMenu, "NouvelleVersionDisponibleSubMenu")
        Me.NouvelleVersionDisponibleSubMenu.Name = "NouvelleVersionDisponibleSubMenu"
        '
        'TéléchargerLaVersionXXXXToolStripMenuItem
        '
        resources.ApplyResources(Me.TéléchargerLaVersionXXXXToolStripMenuItem, "TéléchargerLaVersionXXXXToolStripMenuItem")
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Name = "TéléchargerLaVersionXXXXToolStripMenuItem"
        '
        'FermerSmartNetBrowserToolStripMenuItem
        '
        Me.FermerSmartNetBrowserToolStripMenuItem.Image = Global.SmartNet_Browser.My.Resources.Resources.Fermer_SmartNet_Browser
        Me.FermerSmartNetBrowserToolStripMenuItem.Name = "FermerSmartNetBrowserToolStripMenuItem"
        resources.ApplyResources(Me.FermerSmartNetBrowserToolStripMenuItem, "FermerSmartNetBrowserToolStripMenuItem")
        '
        'HomepageButton
        '
        resources.ApplyResources(Me.HomepageButton, "HomepageButton")
        Me.HomepageButton.BackColor = System.Drawing.Color.White
        Me.HomepageButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.HomeBlack
        Me.HomepageButton.Image = Global.SmartNet_Browser.My.Resources.Resources.HomeBlack
        Me.HomepageButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.HomeBlue
        Me.HomepageButton.Name = "HomepageButton"
        Me.HomepageButton.TabStop = False
        '
        'PreviouspageButton
        '
        Me.PreviouspageButton.BackColor = System.Drawing.Color.White
        Me.PreviouspageButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.PreviousBlack
        Me.PreviouspageButton.Image = Global.SmartNet_Browser.My.Resources.Resources.PreviousBlack
        Me.PreviouspageButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.PreviousBlue
        resources.ApplyResources(Me.PreviouspageButton, "PreviouspageButton")
        Me.PreviouspageButton.Name = "PreviouspageButton"
        Me.PreviouspageButton.TabStop = False
        '
        'NextpageButton
        '
        Me.NextpageButton.BackColor = System.Drawing.Color.White
        Me.NextpageButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.NextBlack
        Me.NextpageButton.Image = Global.SmartNet_Browser.My.Resources.Resources.NextBlack
        Me.NextpageButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.NextBlue
        resources.ApplyResources(Me.NextpageButton, "NextpageButton")
        Me.NextpageButton.Name = "NextpageButton"
        Me.NextpageButton.TabStop = False
        '
        'FaviconBox
        '
        Me.FaviconBox.BackColor = System.Drawing.Color.White
        Me.FaviconBox.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.ErrorFavicon
        Me.FaviconBox.Image = Global.SmartNet_Browser.My.Resources.Resources.ErrorFavicon
        Me.FaviconBox.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.logo16
        resources.ApplyResources(Me.FaviconBox, "FaviconBox")
        Me.FaviconBox.Name = "FaviconBox"
        Me.FaviconBox.TabStop = False
        '
        'URLBox
        '
        Me.URLBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        resources.ApplyResources(Me.URLBox, "URLBox")
        Me.URLBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.URLBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.URLBox.FormattingEnabled = True
        Me.URLBox.Name = "URLBox"
        '
        'SearchBox
        '
        resources.ApplyResources(Me.SearchBox, "SearchBox")
        Me.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SearchBox.FormattingEnabled = True
        Me.SearchBox.Name = "SearchBox"
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.White
        Me.RefreshButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.RefreshBlack
        Me.RefreshButton.Image = Global.SmartNet_Browser.My.Resources.Resources.RefreshBlack
        Me.RefreshButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.RefreshGreen
        resources.ApplyResources(Me.RefreshButton, "RefreshButton")
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.TabStop = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.White
        Me.StopButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.StopBlack
        Me.StopButton.Image = Global.SmartNet_Browser.My.Resources.Resources.StopBlack
        Me.StopButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.StopRed
        resources.ApplyResources(Me.StopButton, "StopButton")
        Me.StopButton.Name = "StopButton"
        Me.StopButton.TabStop = False
        '
        'GoButton
        '
        Me.GoButton.BackColor = System.Drawing.Color.White
        Me.GoButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.GoBlack
        Me.GoButton.Image = Global.SmartNet_Browser.My.Resources.Resources.GoBlack
        Me.GoButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.GoBlue
        resources.ApplyResources(Me.GoButton, "GoButton")
        Me.GoButton.Name = "GoButton"
        Me.GoButton.TabStop = False
        '
        'SearchButton
        '
        resources.ApplyResources(Me.SearchButton, "SearchButton")
        Me.SearchButton.BackColor = System.Drawing.Color.White
        Me.SearchButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.SearchBlack
        Me.SearchButton.Image = Global.SmartNet_Browser.My.Resources.Resources.SearchBlack
        Me.SearchButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.SearchBlue
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.TabStop = False
        '
        'CloseTabButton
        '
        resources.ApplyResources(Me.CloseTabButton, "CloseTabButton")
        Me.CloseTabButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.CloseTabBlack
        Me.CloseTabButton.Image = Global.SmartNet_Browser.My.Resources.Resources.CloseTabBlack
        Me.CloseTabButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.CloseTabRed
        Me.CloseTabButton.Name = "CloseTabButton"
        Me.CloseTabButton.TabStop = False
        '
        'NewTabButton
        '
        resources.ApplyResources(Me.NewTabButton, "NewTabButton")
        Me.NewTabButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.NewTabBlack
        Me.NewTabButton.Image = Global.SmartNet_Browser.My.Resources.Resources.NewTabBlack
        Me.NewTabButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.NewTabGreen
        Me.NewTabButton.Name = "NewTabButton"
        Me.NewTabButton.TabStop = False
        '
        'UpdateNotifyIcon
        '
        Me.UpdateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.UpdateNotifyIcon, "UpdateNotifyIcon")
        '
        'OpenFileDialog1
        '
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'PreviousPageButtonDisabled
        '
        Me.PreviousPageButtonDisabled.Image = Global.SmartNet_Browser.My.Resources.Resources.PreviousDisabled
        resources.ApplyResources(Me.PreviousPageButtonDisabled, "PreviousPageButtonDisabled")
        Me.PreviousPageButtonDisabled.Name = "PreviousPageButtonDisabled"
        Me.PreviousPageButtonDisabled.TabStop = False
        '
        'NextPageButtonDisabled
        '
        Me.NextPageButtonDisabled.Image = Global.SmartNet_Browser.My.Resources.Resources.NextDisabled
        resources.ApplyResources(Me.NextPageButtonDisabled, "NextPageButtonDisabled")
        Me.NextPageButtonDisabled.Name = "NextPageButtonDisabled"
        Me.NextPageButtonDisabled.TabStop = False
        '
        'BrowserContextMenuStrip
        '
        Me.BrowserContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirLeLienToolStripMenuItem, Me.OuvrirDansUnNouvelOngletToolStripMenuItem, Me.CopierLadresseDuLienToolStripMenuItem, Me.AjouterLeLienAuxFavorisToolStripMenuItem, Me.LinkToolStripSeparator, Me.EnregistrerLimageToolStripMenuItem, Me.CopierLadresseDeLimageToolStripMenuItem, Me.AfficherLimageToolStripMenuItem, Me.ImageToolStripSeparator, Me.CouperToolStripMenuItem1, Me.CopierToolStripMenuItem1, Me.CollerToolStripMenuItem1, Me.LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem, Me.EditionToolStripSeparator, Me.ActualiserLaPageToolStripMenuItem, Me.ToolStripSeparator7, Me.PropriétésToolStripMenuItem, Me.AfficherLeCodeSourceDeLaPageToolStripMenuItem})
        Me.BrowserContextMenuStrip.Name = "BrowserContextMenuStrip"
        resources.ApplyResources(Me.BrowserContextMenuStrip, "BrowserContextMenuStrip")
        '
        'OuvrirLeLienToolStripMenuItem
        '
        Me.OuvrirLeLienToolStripMenuItem.Name = "OuvrirLeLienToolStripMenuItem"
        resources.ApplyResources(Me.OuvrirLeLienToolStripMenuItem, "OuvrirLeLienToolStripMenuItem")
        '
        'OuvrirDansUnNouvelOngletToolStripMenuItem
        '
        resources.ApplyResources(Me.OuvrirDansUnNouvelOngletToolStripMenuItem, "OuvrirDansUnNouvelOngletToolStripMenuItem")
        Me.OuvrirDansUnNouvelOngletToolStripMenuItem.Name = "OuvrirDansUnNouvelOngletToolStripMenuItem"
        '
        'CopierLadresseDuLienToolStripMenuItem
        '
        resources.ApplyResources(Me.CopierLadresseDuLienToolStripMenuItem, "CopierLadresseDuLienToolStripMenuItem")
        Me.CopierLadresseDuLienToolStripMenuItem.Name = "CopierLadresseDuLienToolStripMenuItem"
        '
        'AjouterLeLienAuxFavorisToolStripMenuItem
        '
        resources.ApplyResources(Me.AjouterLeLienAuxFavorisToolStripMenuItem, "AjouterLeLienAuxFavorisToolStripMenuItem")
        Me.AjouterLeLienAuxFavorisToolStripMenuItem.Name = "AjouterLeLienAuxFavorisToolStripMenuItem"
        '
        'LinkToolStripSeparator
        '
        Me.LinkToolStripSeparator.Name = "LinkToolStripSeparator"
        resources.ApplyResources(Me.LinkToolStripSeparator, "LinkToolStripSeparator")
        '
        'EnregistrerLimageToolStripMenuItem
        '
        resources.ApplyResources(Me.EnregistrerLimageToolStripMenuItem, "EnregistrerLimageToolStripMenuItem")
        Me.EnregistrerLimageToolStripMenuItem.Name = "EnregistrerLimageToolStripMenuItem"
        '
        'CopierLadresseDeLimageToolStripMenuItem
        '
        resources.ApplyResources(Me.CopierLadresseDeLimageToolStripMenuItem, "CopierLadresseDeLimageToolStripMenuItem")
        Me.CopierLadresseDeLimageToolStripMenuItem.Name = "CopierLadresseDeLimageToolStripMenuItem"
        '
        'AfficherLimageToolStripMenuItem
        '
        resources.ApplyResources(Me.AfficherLimageToolStripMenuItem, "AfficherLimageToolStripMenuItem")
        Me.AfficherLimageToolStripMenuItem.Name = "AfficherLimageToolStripMenuItem"
        '
        'ImageToolStripSeparator
        '
        Me.ImageToolStripSeparator.Name = "ImageToolStripSeparator"
        resources.ApplyResources(Me.ImageToolStripSeparator, "ImageToolStripSeparator")
        '
        'CouperToolStripMenuItem1
        '
        resources.ApplyResources(Me.CouperToolStripMenuItem1, "CouperToolStripMenuItem1")
        Me.CouperToolStripMenuItem1.Name = "CouperToolStripMenuItem1"
        '
        'CopierToolStripMenuItem1
        '
        resources.ApplyResources(Me.CopierToolStripMenuItem1, "CopierToolStripMenuItem1")
        Me.CopierToolStripMenuItem1.Name = "CopierToolStripMenuItem1"
        '
        'CollerToolStripMenuItem1
        '
        resources.ApplyResources(Me.CollerToolStripMenuItem1, "CollerToolStripMenuItem1")
        Me.CollerToolStripMenuItem1.Name = "CollerToolStripMenuItem1"
        '
        'LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem
        '
        resources.ApplyResources(Me.LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem, "LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem")
        Me.LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem.Name = "LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem"
        '
        'EditionToolStripSeparator
        '
        Me.EditionToolStripSeparator.Name = "EditionToolStripSeparator"
        resources.ApplyResources(Me.EditionToolStripSeparator, "EditionToolStripSeparator")
        '
        'ActualiserLaPageToolStripMenuItem
        '
        resources.ApplyResources(Me.ActualiserLaPageToolStripMenuItem, "ActualiserLaPageToolStripMenuItem")
        Me.ActualiserLaPageToolStripMenuItem.Name = "ActualiserLaPageToolStripMenuItem"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'PropriétésToolStripMenuItem
        '
        Me.PropriétésToolStripMenuItem.Name = "PropriétésToolStripMenuItem"
        resources.ApplyResources(Me.PropriétésToolStripMenuItem, "PropriétésToolStripMenuItem")
        '
        'AfficherLeCodeSourceDeLaPageToolStripMenuItem
        '
        Me.AfficherLeCodeSourceDeLaPageToolStripMenuItem.Name = "AfficherLeCodeSourceDeLaPageToolStripMenuItem"
        resources.ApplyResources(Me.AfficherLeCodeSourceDeLaPageToolStripMenuItem, "AfficherLeCodeSourceDeLaPageToolStripMenuItem")
        '
        'SaveImageDialog
        '
        resources.ApplyResources(Me.SaveImageDialog, "SaveImageDialog")
        '
        'SavePageDialog
        '
        Me.SavePageDialog.DefaultExt = "html"
        resources.ApplyResources(Me.SavePageDialog, "SavePageDialog")
        '
        'BrowserTabs
        '
        resources.ApplyResources(Me.BrowserTabs, "BrowserTabs")
        Me.BrowserTabs.ImageList = Me.ImageList1
        Me.BrowserTabs.Name = "BrowserTabs"
        Me.BrowserTabs.SelectedIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Logo 16x16.png")
        '
        'TabsContextMenuStrip
        '
        Me.TabsContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FermerCetOngletToolStripMenuItem, Me.RouvrirLeDernierOngletFerméToolStripMenuItem})
        Me.TabsContextMenuStrip.Name = "TabsContextMenuStrip"
        resources.ApplyResources(Me.TabsContextMenuStrip, "TabsContextMenuStrip")
        '
        'FermerCetOngletToolStripMenuItem
        '
        Me.FermerCetOngletToolStripMenuItem.Name = "FermerCetOngletToolStripMenuItem"
        resources.ApplyResources(Me.FermerCetOngletToolStripMenuItem, "FermerCetOngletToolStripMenuItem")
        '
        'RouvrirLeDernierOngletFerméToolStripMenuItem
        '
        Me.RouvrirLeDernierOngletFerméToolStripMenuItem.Name = "RouvrirLeDernierOngletFerméToolStripMenuItem"
        resources.ApplyResources(Me.RouvrirLeDernierOngletFerméToolStripMenuItem, "RouvrirLeDernierOngletFerméToolStripMenuItem")
        '
        'FavoritesButton
        '
        resources.ApplyResources(Me.FavoritesButton, "FavoritesButton")
        Me.FavoritesButton.BackColor = System.Drawing.Color.White
        Me.FavoritesButton.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.FavoritesYellow
        Me.FavoritesButton.Image = Global.SmartNet_Browser.My.Resources.Resources.FavoritesOutline
        Me.FavoritesButton.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.FavoritesOutline
        Me.FavoritesButton.Name = "FavoritesButton"
        Me.FavoritesButton.TabStop = False
        '
        'LoadingGif
        '
        Me.LoadingGif.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.chargement_browserform
        Me.LoadingGif.Image = Global.SmartNet_Browser.My.Resources.Resources.chargement_browserform
        Me.LoadingGif.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.chargement_browserform
        resources.ApplyResources(Me.LoadingGif, "LoadingGif")
        Me.LoadingGif.Name = "LoadingGif"
        Me.LoadingGif.TabStop = False
        '
        'SearchBoxLabel
        '
        resources.ApplyResources(Me.SearchBoxLabel, "SearchBoxLabel")
        Me.SearchBoxLabel.BackColor = System.Drawing.Color.Transparent
        Me.SearchBoxLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBoxLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SearchBoxLabel.Name = "SearchBoxLabel"
        '
        'URLBoxLabel
        '
        resources.ApplyResources(Me.URLBoxLabel, "URLBoxLabel")
        Me.URLBoxLabel.BackColor = System.Drawing.Color.Transparent
        Me.URLBoxLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.URLBoxLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.URLBoxLabel.Name = "URLBoxLabel"
        '
        'StatusLabel
        '
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        Me.StatusLabel.BackColor = System.Drawing.SystemColors.Control
        Me.StatusLabel.Name = "StatusLabel"
        '
        'MessageBarPictureBox
        '
        resources.ApplyResources(Me.MessageBarPictureBox, "MessageBarPictureBox")
        Me.MessageBarPictureBox.BackColor = System.Drawing.Color.DarkOrange
        Me.MessageBarPictureBox.Name = "MessageBarPictureBox"
        Me.MessageBarPictureBox.TabStop = False
        '
        'MessageBarLabel1
        '
        resources.ApplyResources(Me.MessageBarLabel1, "MessageBarLabel1")
        Me.MessageBarLabel1.BackColor = System.Drawing.Color.DarkOrange
        Me.MessageBarLabel1.ForeColor = System.Drawing.Color.White
        Me.MessageBarLabel1.Name = "MessageBarLabel1"
        '
        'MessageBarButton1
        '
        resources.ApplyResources(Me.MessageBarButton1, "MessageBarButton1")
        Me.MessageBarButton1.BackColor = System.Drawing.Color.Transparent
        Me.MessageBarButton1.Name = "MessageBarButton1"
        Me.MessageBarButton1.UseVisualStyleBackColor = True
        '
        'MessageBarCloseButton1
        '
        resources.ApplyResources(Me.MessageBarCloseButton1, "MessageBarCloseButton1")
        Me.MessageBarCloseButton1.BackColor = System.Drawing.Color.DarkOrange
        Me.MessageBarCloseButton1.ErrorImage = Global.SmartNet_Browser.My.Resources.Resources.CloseTabButton_in_tab
        Me.MessageBarCloseButton1.Image = Global.SmartNet_Browser.My.Resources.Resources.CloseTabButton_in_tab
        Me.MessageBarCloseButton1.InitialImage = Global.SmartNet_Browser.My.Resources.Resources.CloseTabButton_in_tab
        Me.MessageBarCloseButton1.Name = "MessageBarCloseButton1"
        Me.MessageBarCloseButton1.TabStop = False
        '
        'GardeFouTimer
        '
        Me.GardeFouTimer.Interval = 1000
        '
        'SignalerUnSiteMalveillantToolStripMenuItem
        '
        Me.SignalerUnSiteMalveillantToolStripMenuItem.Name = "SignalerUnSiteMalveillantToolStripMenuItem"
        resources.ApplyResources(Me.SignalerUnSiteMalveillantToolStripMenuItem, "SignalerUnSiteMalveillantToolStripMenuItem")
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        resources.ApplyResources(Me.ToolStripSeparator10, "ToolStripSeparator10")
        '
        'BrowserForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MessageBarCloseButton1)
        Me.Controls.Add(Me.MessageBarButton1)
        Me.Controls.Add(Me.MessageBarLabel1)
        Me.Controls.Add(Me.MessageBarPictureBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.URLBoxLabel)
        Me.Controls.Add(Me.SearchBoxLabel)
        Me.Controls.Add(Me.LoadingGif)
        Me.Controls.Add(Me.FaviconBox)
        Me.Controls.Add(Me.NewTabButton)
        Me.Controls.Add(Me.CloseTabButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.FavoritesButton)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.NextpageButton)
        Me.Controls.Add(Me.PreviouspageButton)
        Me.Controls.Add(Me.HomepageButton)
        Me.Controls.Add(Me.NextPageButtonDisabled)
        Me.Controls.Add(Me.PreviousPageButtonDisabled)
        Me.Controls.Add(Me.URLBox)
        Me.Controls.Add(Me.MainToolbar)
        Me.Controls.Add(Me.BrowserTabs)
        Me.Name = "BrowserForm"
        Me.MainToolbar.ResumeLayout(False)
        Me.MainToolbar.PerformLayout()
        CType(Me.HomepageButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviouspageButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextpageButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaviconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseTabButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewTabButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousPageButtonDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextPageButtonDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrowserContextMenuStrip.ResumeLayout(False)
        Me.TabsContextMenuStrip.ResumeLayout(False)
        CType(Me.FavoritesButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageBarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageBarCloseButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainToolbar As MenuStrip
    Friend WithEvents MainMenu As ToolStripMenuItem
    Friend WithEvents HomepageButton As PictureBox
    Friend WithEvents PreviouspageButton As PictureBox
    Friend WithEvents NextpageButton As PictureBox
    Friend WithEvents FaviconBox As PictureBox
    Friend WithEvents URLBox As ComboBox
    Friend WithEvents SearchBox As ComboBox
    Friend WithEvents RefreshButton As PictureBox
    Friend WithEvents StopButton As PictureBox
    Friend WithEvents GoButton As PictureBox
    Friend WithEvents SearchButton As PictureBox
    Friend WithEvents CloseTabButton As PictureBox
    Friend WithEvents NewTabButton As PictureBox
    Friend WithEvents UpdateNotifyIcon As NotifyIcon
    Friend WithEvents ÉditionSubMenu As ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavorisSubMenu As ToolStripMenuItem
    Friend WithEvents AfficherLesFavorisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterCettePageDansLesFavorisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleVersionDisponibleSubMenu As ToolStripMenuItem
    Friend WithEvents TéléchargerLaVersionXXXXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FermerSmartNetBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents NewTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AperçuAvantImpressionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AfficherLhistoriqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents PleinÉcranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterLePleinÉcranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CentreDaideEnLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacterLéquipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÀProposDeSmartNetBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TéléchargerCetteVidéoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents PreviousPageButtonDisabled As PictureBox
    Friend WithEvents NextPageButtonDisabled As PictureBox
    Friend WithEvents BrowserContextMenuStrip As ContextMenuStrip
    Friend WithEvents OuvrirLeLienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirDansUnNouvelOngletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierLadresseDuLienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkToolStripSeparator As ToolStripSeparator
    Friend WithEvents EnregistrerLimageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopierLadresseDeLimageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherLimageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripSeparator As ToolStripSeparator
    Friend WithEvents PropriétésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterLeLienAuxFavorisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualiserLaPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents AfficherLeCodeSourceDeLaPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditionToolStripSeparator As ToolStripSeparator
    Friend WithEvents LancerUneRechercheAvecLeTexteSélectionnéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveImageDialog As SaveFileDialog
    Friend WithEvents EnvoyerVosCommentairesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePageDialog As SaveFileDialog
    Friend WithEvents BrowserTabs As TabControl
    Friend WithEvents FavoritesButton As PictureBox
    Friend WithEvents LoadingGif As PictureBox
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Zoom50 As ToolStripMenuItem
    Friend WithEvents Zoom75 As ToolStripMenuItem
    Friend WithEvents Zoom100 As ToolStripMenuItem
    Friend WithEvents Zoom125 As ToolStripMenuItem
    Friend WithEvents Zoom150 As ToolStripMenuItem
    Friend WithEvents Zoom175 As ToolStripMenuItem
    Friend WithEvents Zoom200 As ToolStripMenuItem
    Friend WithEvents Zoom250 As ToolStripMenuItem
    Friend WithEvents Zoom300 As ToolStripMenuItem
    Friend WithEvents Zoom400 As ToolStripMenuItem
    Friend WithEvents SearchBoxLabel As Label
    Friend WithEvents URLBoxLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ZoomPlusButton As ToolStripMenuItem
    Friend WithEvents ZoomMinusButton As ToolStripMenuItem
    Friend WithEvents SélectionnerToutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents RechercherDansLaPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvoyerLadresseDeLaPageParCourrierÉlectoniqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MessageBarPictureBox As PictureBox
    Friend WithEvents MessageBarLabel1 As Label
    Friend WithEvents MessageBarButton1 As Button
    Friend WithEvents MessageBarCloseButton1 As PictureBox
    Friend WithEvents TabsContextMenuStrip As ContextMenuStrip
    Friend WithEvents FermerCetOngletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RouvrirLeDernierOngletFerméToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GardeFouTimer As Timer
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents SignalerUnSiteMalveillantToolStripMenuItem As ToolStripMenuItem
End Class
