﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewHistoryForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewHistoryForm))
        Me.HistoryListView = New System.Windows.Forms.ListView()
        Me.TitleColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.URLColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HistoryFaviconImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.OpenPageButton = New System.Windows.Forms.Button()
        Me.OpenOldHistoryButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageHistory = New System.Windows.Forms.TabPage()
        Me.TabPageFavorites = New System.Windows.Forms.TabPage()
        Me.ListViewFavorites = New System.Windows.Forms.ListView()
        Me.ColumnHeaderTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageDownloads = New System.Windows.Forms.TabPage()
        Me.TabPageSearchHistory = New System.Windows.Forms.TabPage()
        Me.FavoritesFaviconImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonOpenOldFavorites = New System.Windows.Forms.Button()
        Me.ButtonOpenFavorite = New System.Windows.Forms.Button()
        Me.ButtonDeleteFavorite = New System.Windows.Forms.Button()
        Me.ListBoxSearches = New System.Windows.Forms.ListBox()
        Me.ButtonSearchAgain = New System.Windows.Forms.Button()
        Me.ButtonDeleteSearch = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPageHistory.SuspendLayout()
        Me.TabPageFavorites.SuspendLayout()
        Me.TabPageSearchHistory.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistoryListView
        '
        Me.HistoryListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TitleColumnHeader, Me.URLColumnHeader})
        resources.ApplyResources(Me.HistoryListView, "HistoryListView")
        Me.HistoryListView.FullRowSelect = True
        Me.HistoryListView.LargeImageList = Me.HistoryFaviconImageList
        Me.HistoryListView.Name = "HistoryListView"
        Me.HistoryListView.SmallImageList = Me.HistoryFaviconImageList
        Me.HistoryListView.StateImageList = Me.HistoryFaviconImageList
        Me.HistoryListView.UseCompatibleStateImageBehavior = False
        Me.HistoryListView.View = System.Windows.Forms.View.Details
        '
        'TitleColumnHeader
        '
        resources.ApplyResources(Me.TitleColumnHeader, "TitleColumnHeader")
        '
        'URLColumnHeader
        '
        resources.ApplyResources(Me.URLColumnHeader, "URLColumnHeader")
        '
        'HistoryFaviconImageList
        '
        Me.HistoryFaviconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.HistoryFaviconImageList, "HistoryFaviconImageList")
        Me.HistoryFaviconImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'DeleteButton
        '
        resources.ApplyResources(Me.DeleteButton, "DeleteButton")
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'OpenPageButton
        '
        resources.ApplyResources(Me.OpenPageButton, "OpenPageButton")
        Me.OpenPageButton.Name = "OpenPageButton"
        Me.OpenPageButton.UseVisualStyleBackColor = True
        '
        'OpenOldHistoryButton
        '
        resources.ApplyResources(Me.OpenOldHistoryButton, "OpenOldHistoryButton")
        Me.OpenOldHistoryButton.Name = "OpenOldHistoryButton"
        Me.OpenOldHistoryButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageHistory)
        Me.TabControl1.Controls.Add(Me.TabPageFavorites)
        Me.TabControl1.Controls.Add(Me.TabPageSearchHistory)
        Me.TabControl1.Controls.Add(Me.TabPageDownloads)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPageHistory
        '
        Me.TabPageHistory.Controls.Add(Me.HistoryListView)
        Me.TabPageHistory.Controls.Add(Me.OpenOldHistoryButton)
        Me.TabPageHistory.Controls.Add(Me.DeleteButton)
        Me.TabPageHistory.Controls.Add(Me.OpenPageButton)
        resources.ApplyResources(Me.TabPageHistory, "TabPageHistory")
        Me.TabPageHistory.Name = "TabPageHistory"
        Me.TabPageHistory.UseVisualStyleBackColor = True
        '
        'TabPageFavorites
        '
        Me.TabPageFavorites.Controls.Add(Me.ButtonDeleteFavorite)
        Me.TabPageFavorites.Controls.Add(Me.ButtonOpenFavorite)
        Me.TabPageFavorites.Controls.Add(Me.ButtonOpenOldFavorites)
        Me.TabPageFavorites.Controls.Add(Me.ListViewFavorites)
        resources.ApplyResources(Me.TabPageFavorites, "TabPageFavorites")
        Me.TabPageFavorites.Name = "TabPageFavorites"
        Me.TabPageFavorites.UseVisualStyleBackColor = True
        '
        'ListViewFavorites
        '
        Me.ListViewFavorites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderTitle, Me.ColumnHeaderURL})
        resources.ApplyResources(Me.ListViewFavorites, "ListViewFavorites")
        Me.ListViewFavorites.FullRowSelect = True
        Me.ListViewFavorites.Name = "ListViewFavorites"
        Me.ListViewFavorites.UseCompatibleStateImageBehavior = False
        Me.ListViewFavorites.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderTitle
        '
        resources.ApplyResources(Me.ColumnHeaderTitle, "ColumnHeaderTitle")
        '
        'ColumnHeaderURL
        '
        resources.ApplyResources(Me.ColumnHeaderURL, "ColumnHeaderURL")
        '
        'TabPageDownloads
        '
        resources.ApplyResources(Me.TabPageDownloads, "TabPageDownloads")
        Me.TabPageDownloads.Name = "TabPageDownloads"
        Me.TabPageDownloads.UseVisualStyleBackColor = True
        '
        'TabPageSearchHistory
        '
        Me.TabPageSearchHistory.Controls.Add(Me.ButtonDeleteSearch)
        Me.TabPageSearchHistory.Controls.Add(Me.ButtonSearchAgain)
        Me.TabPageSearchHistory.Controls.Add(Me.ListBoxSearches)
        resources.ApplyResources(Me.TabPageSearchHistory, "TabPageSearchHistory")
        Me.TabPageSearchHistory.Name = "TabPageSearchHistory"
        Me.TabPageSearchHistory.UseVisualStyleBackColor = True
        '
        'FavoritesFaviconImageList
        '
        Me.FavoritesFaviconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.FavoritesFaviconImageList, "FavoritesFaviconImageList")
        Me.FavoritesFaviconImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ButtonOpenOldFavorites
        '
        resources.ApplyResources(Me.ButtonOpenOldFavorites, "ButtonOpenOldFavorites")
        Me.ButtonOpenOldFavorites.Name = "ButtonOpenOldFavorites"
        Me.ButtonOpenOldFavorites.UseVisualStyleBackColor = True
        '
        'ButtonOpenFavorite
        '
        resources.ApplyResources(Me.ButtonOpenFavorite, "ButtonOpenFavorite")
        Me.ButtonOpenFavorite.Name = "ButtonOpenFavorite"
        Me.ButtonOpenFavorite.UseVisualStyleBackColor = True
        '
        'ButtonDeleteFavorite
        '
        resources.ApplyResources(Me.ButtonDeleteFavorite, "ButtonDeleteFavorite")
        Me.ButtonDeleteFavorite.Name = "ButtonDeleteFavorite"
        Me.ButtonDeleteFavorite.UseVisualStyleBackColor = True
        '
        'ListBoxSearches
        '
        resources.ApplyResources(Me.ListBoxSearches, "ListBoxSearches")
        Me.ListBoxSearches.FormattingEnabled = True
        Me.ListBoxSearches.Name = "ListBoxSearches"
        '
        'ButtonSearchAgain
        '
        resources.ApplyResources(Me.ButtonSearchAgain, "ButtonSearchAgain")
        Me.ButtonSearchAgain.Name = "ButtonSearchAgain"
        Me.ButtonSearchAgain.UseVisualStyleBackColor = True
        '
        'ButtonDeleteSearch
        '
        resources.ApplyResources(Me.ButtonDeleteSearch, "ButtonDeleteSearch")
        Me.ButtonDeleteSearch.Name = "ButtonDeleteSearch"
        Me.ButtonDeleteSearch.UseVisualStyleBackColor = True
        '
        'NewHistoryForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "NewHistoryForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageHistory.ResumeLayout(False)
        Me.TabPageFavorites.ResumeLayout(False)
        Me.TabPageSearchHistory.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HistoryListView As ListView
    Friend WithEvents TitleColumnHeader As ColumnHeader
    Friend WithEvents URLColumnHeader As ColumnHeader
    Friend WithEvents HistoryFaviconImageList As ImageList
    Friend WithEvents DeleteButton As Button
    Friend WithEvents OpenPageButton As Button
    Friend WithEvents OpenOldHistoryButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageHistory As TabPage
    Friend WithEvents TabPageFavorites As TabPage
    Friend WithEvents ListViewFavorites As ListView
    Friend WithEvents ColumnHeaderTitle As ColumnHeader
    Friend WithEvents ColumnHeaderURL As ColumnHeader
    Friend WithEvents TabPageSearchHistory As TabPage
    Friend WithEvents TabPageDownloads As TabPage
    Friend WithEvents FavoritesFaviconImageList As ImageList
    Friend WithEvents ButtonDeleteFavorite As Button
    Friend WithEvents ButtonOpenFavorite As Button
    Friend WithEvents ButtonOpenOldFavorites As Button
    Friend WithEvents ListBoxSearches As ListBox
    Friend WithEvents ButtonSearchAgain As Button
    Friend WithEvents ButtonDeleteSearch As Button
End Class
