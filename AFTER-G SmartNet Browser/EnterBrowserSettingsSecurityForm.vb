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
                    NewHistoryForm.TabControl1.SelectTab(0)
                    NewHistoryForm.Show()
                Case "Favorites"
                    NewHistoryForm.TabControl1.SelectTab(1)
                    NewHistoryForm.Show()
                Case "SearchHistory"
                    NewHistoryForm.TabControl1.SelectTab(2)
                    NewHistoryForm.Show()
                Case "DownloadHistory"
                    NewHistoryForm.TabControl1.SelectTab(3)
                    NewHistoryForm.Show()
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