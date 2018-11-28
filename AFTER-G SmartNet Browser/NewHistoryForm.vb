﻿Public Class NewHistoryForm
    Dim Historique As List(Of WebPage)
    Dim Favoris As List(Of WebPage)

    Public Sub New()
        InitializeComponent()
        Historique = New List(Of WebPage)
        Favoris = New List(Of WebPage)
    End Sub

    Private Sub NewHistoryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshHistory()
        RefreshFavorites()
        RefreshSearches()
        RefreshDownloads()
    End Sub

    Private Sub HistoryListView_DoubleClick(sender As Object, e As EventArgs) Handles HistoryListView.DoubleClick
        Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
        WB.Navigate(HistoryListView.SelectedItems.Item(0).SubItems(1).Text)
        Me.Close()
    End Sub

    Private Sub OpenPageButton_Click(sender As Object, e As EventArgs) Handles OpenPageButton.Click
        Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
        For Each Item As ListViewItem In HistoryListView.SelectedItems
            BrowserForm.AddTab(Item.SubItems(1).Text.ToString(), BrowserForm.BrowserTabs)
        Next
        WB.Navigate(HistoryListView.SelectedItems.Item(0).SubItems(1).Text)
        Me.Close()
    End Sub

    Private Sub ButtonOpenFavorite_Click(sender As Object, e As EventArgs) Handles ButtonOpenFavorite.Click
        Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
        For Each Item As ListViewItem In ListViewFavorites.SelectedItems
            BrowserForm.AddTab(Item.SubItems(1).Text.ToString(), BrowserForm.BrowserTabs)
        Next
        WB.Navigate(ListViewFavorites.SelectedItems.Item(0).SubItems(1).Text)
        Me.Close()
    End Sub

    Private Sub ButtonDeleteFavorite_Click(sender As Object, e As EventArgs) Handles ButtonDeleteFavorite.Click
        DeleteSelectedFavorites()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteSelectedHistory()
    End Sub

    Private Sub ButtonSearchAgain_Click(sender As Object, e As EventArgs) Handles ButtonSearchAgain.Click
        BrowserForm.OpenSearchResults(ListBoxSearches.SelectedItem.ToString())
    End Sub

    Private Sub ButtonDeleteSearch_Click(sender As Object, e As EventArgs) Handles ButtonDeleteSearch.Click
        My.Settings.SearchHistory.RemoveAt(ListBoxSearches.SelectedIndex)
        My.Settings.Save()
        ListBoxSearches.Items.RemoveAt(ListBoxSearches.SelectedIndex)
    End Sub

    Private Sub ListViewFavorites_DoubleClick(sender As Object, e As EventArgs) Handles ListViewFavorites.DoubleClick
        Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
        WB.Navigate(ListViewFavorites.SelectedItems.Item(0).SubItems(1).Text)
        Me.Close()
    End Sub

    Private Sub RefreshHistory()
        HistoryListView.Items.Clear()
        HistoryFaviconImageList.Images.Clear()
        Historique = BrowserForm.Historique
        For Each entree In Historique
            Dim element As New ListViewItem
            HistoryFaviconImageList.Images.Add(entree.GetFavicon())
            element = CType(HistoryListView.Items.Add(entree.GetNom()), ListViewItem)
            element.SubItems.Add(entree.GetURL())
        Next
        HistoryListView.SmallImageList = HistoryFaviconImageList
        HistoryListView.LargeImageList = HistoryFaviconImageList
    End Sub

    Private Sub RefreshFavorites()
        ListViewFavorites.Items.Clear()
        FavoritesFaviconImageList.Images.Clear()
        Favoris = BrowserForm.Favoris
        For Each entree In Favoris
            Dim element As New ListViewItem
            FavoritesFaviconImageList.Images.Add(entree.GetFavicon())
            element = CType(ListViewFavorites.Items.Add(entree.GetNom()), ListViewItem)
            element.SubItems.Add(entree.GetURL())
        Next
        ListViewFavorites.SmallImageList = FavoritesFaviconImageList
        ListViewFavorites.LargeImageList = FavoritesFaviconImageList
    End Sub

    Private Sub RefreshSearches()
        ListBoxSearches.Items.Clear()
        For Each item In My.Settings.SearchHistory
            ListBoxSearches.Items.Add(item)
        Next
    End Sub

    Private Sub RefreshDownloads()

    End Sub

    Private Sub DeleteSelectedHistory()
        Dim indice As Integer
        Dim SelectedIndexes As ListView.SelectedIndexCollection
        SelectedIndexes = HistoryListView.SelectedIndices
        For i As Integer = SelectedIndexes.Count - 1 To 0 Step -1
            indice = SelectedIndexes.Item(i)
            My.Settings.History.RemoveAt(indice)
            My.Settings.Save()
            BrowserForm.Historique.RemoveAt(indice)
        Next
        RefreshHistory()
    End Sub

    Private Sub DeleteSelectedFavorites()
        Dim indice As Integer
        Dim SelectedIndexes As ListView.SelectedIndexCollection
        SelectedIndexes = ListViewFavorites.SelectedIndices
        For i As Integer = SelectedIndexes.Count - 1 To 0 Step -1
            indice = SelectedIndexes.Item(i)
            My.Settings.Favorites.RemoveAt(indice)
            My.Settings.Save()
            BrowserForm.Favoris.RemoveAt(indice)
        Next
        RefreshFavorites()
    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AProposDeSmartNetBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposDeSmartNetBrowserToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub RafraîchirLesListesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RafraîchirLesListesToolStripMenuItem.Click
        RefreshHistory()
        RefreshFavorites()
        RefreshSearches()
        RefreshDownloads()
    End Sub

    Private Sub HistoryListView_KeyDown(sender As Object, e As KeyEventArgs) Handles HistoryListView.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                DeleteSelectedHistory()
            Case Keys.Enter
                Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
                For Each Item As ListViewItem In HistoryListView.SelectedItems
                    BrowserForm.AddTab(Item.SubItems(1).Text.ToString(), BrowserForm.BrowserTabs)
                Next
                WB.Navigate(HistoryListView.SelectedItems.Item(0).SubItems(1).Text)
                Me.Close()
        End Select
    End Sub

    Private Sub ListViewFavorites_KeyDown(sender As Object, e As KeyEventArgs) Handles ListViewFavorites.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                DeleteSelectedFavorites()
            Case Keys.Enter
                Dim WB As CustomBrowser = CType(BrowserForm.BrowserTabs.SelectedTab.Tag, CustomBrowser)
                For Each Item As ListViewItem In ListViewFavorites.SelectedItems
                    BrowserForm.AddTab(Item.SubItems(1).Text.ToString(), BrowserForm.BrowserTabs)
                Next
                WB.Navigate(ListViewFavorites.SelectedItems.Item(0).SubItems(1).Text)
                Me.Close()
        End Select
    End Sub
End Class