﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppSyncLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppSyncLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_Email = New System.Windows.Forms.Label()
        Me.Label_MDP = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_MDP = New System.Windows.Forms.TextBox()
        Me.Button_Connecter = New System.Windows.Forms.Button()
        Me.LinkLabel_MDPOublie = New System.Windows.Forms.LinkLabel()
        Me.Button_CreerCompte = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.SmartNet_Browser.My.Resources.Resources.appsync_1024
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label_Email
        '
        Me.Label_Email.AutoSize = True
        Me.Label_Email.Location = New System.Drawing.Point(8, 166)
        Me.Label_Email.Name = "Label_Email"
        Me.Label_Email.Size = New System.Drawing.Size(99, 19)
        Me.Label_Email.TabIndex = 0
        Me.Label_Email.Text = "Adresse e-mail"
        '
        'Label_MDP
        '
        Me.Label_MDP.AutoSize = True
        Me.Label_MDP.Location = New System.Drawing.Point(8, 229)
        Me.Label_MDP.Name = "Label_MDP"
        Me.Label_MDP.Size = New System.Drawing.Size(92, 19)
        Me.Label_MDP.TabIndex = 0
        Me.Label_MDP.Text = "Mot de passe"
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Title.Location = New System.Drawing.Point(86, 121)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(259, 30)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "Bienvenue sur AppSync !"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Email.Location = New System.Drawing.Point(12, 188)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(400, 25)
        Me.TextBox_Email.TabIndex = 1
        '
        'TextBox_MDP
        '
        Me.TextBox_MDP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_MDP.Location = New System.Drawing.Point(12, 251)
        Me.TextBox_MDP.Name = "TextBox_MDP"
        Me.TextBox_MDP.Size = New System.Drawing.Size(404, 25)
        Me.TextBox_MDP.TabIndex = 2
        Me.TextBox_MDP.UseSystemPasswordChar = True
        '
        'Button_Connecter
        '
        Me.Button_Connecter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Connecter.Location = New System.Drawing.Point(12, 328)
        Me.Button_Connecter.Name = "Button_Connecter"
        Me.Button_Connecter.Size = New System.Drawing.Size(100, 28)
        Me.Button_Connecter.TabIndex = 4
        Me.Button_Connecter.Text = "Se connecter"
        Me.Button_Connecter.UseVisualStyleBackColor = True
        '
        'LinkLabel_MDPOublie
        '
        Me.LinkLabel_MDPOublie.AutoSize = True
        Me.LinkLabel_MDPOublie.Location = New System.Drawing.Point(16, 283)
        Me.LinkLabel_MDPOublie.Name = "LinkLabel_MDPOublie"
        Me.LinkLabel_MDPOublie.Size = New System.Drawing.Size(143, 19)
        Me.LinkLabel_MDPOublie.TabIndex = 3
        Me.LinkLabel_MDPOublie.TabStop = True
        Me.LinkLabel_MDPOublie.Text = "Mot de passe oublié ?"
        '
        'Button_CreerCompte
        '
        Me.Button_CreerCompte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_CreerCompte.Location = New System.Drawing.Point(12, 362)
        Me.Button_CreerCompte.Name = "Button_CreerCompte"
        Me.Button_CreerCompte.Size = New System.Drawing.Size(183, 28)
        Me.Button_CreerCompte.TabIndex = 5
        Me.Button_CreerCompte.Text = "Créer un compte"
        Me.Button_CreerCompte.UseVisualStyleBackColor = True
        '
        'AppSyncLogin
        '
        Me.AcceptButton = Me.Button_Connecter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(428, 401)
        Me.Controls.Add(Me.Button_CreerCompte)
        Me.Controls.Add(Me.LinkLabel_MDPOublie)
        Me.Controls.Add(Me.Button_Connecter)
        Me.Controls.Add(Me.TextBox_MDP)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Label_MDP)
        Me.Controls.Add(Me.Label_Email)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppSyncLogin"
        Me.ShowIcon = False
        Me.Text = "Se connecter à SmartNet AppSync"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label_Email As Label
    Friend WithEvents Label_MDP As Label
    Friend WithEvents Label_Title As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_MDP As TextBox
    Friend WithEvents Button_Connecter As Button
    Friend WithEvents LinkLabel_MDPOublie As LinkLabel
    Friend WithEvents Button_CreerCompte As Button
End Class
