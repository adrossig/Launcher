<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New Launcher_Endora.FormSkin()
        Me.FlatButton1 = New Launcher_Endora.FlatButton()
        Me.FlatButton9 = New Launcher_Endora.FlatButton()
        Me.FlatButton8 = New Launcher_Endora.FlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatButton6 = New Launcher_Endora.FlatButton()
        Me.FlatButton5 = New Launcher_Endora.FlatButton()
        Me.FlatButton4 = New Launcher_Endora.FlatButton()
        Me.FlatButton3 = New Launcher_Endora.FlatButton()
        Me.FlatButton2 = New Launcher_Endora.FlatButton()
        Me.FlatProgressBar1 = New Launcher_Endora.FlatProgressBar()
        Me.FlatMini1 = New Launcher_Endora.FlatMini()
        Me.FlatClose1 = New Launcher_Endora.FlatClose()
        Me.FlatContextMenuStrip1 = New Launcher_Endora.FlatContextMenuStrip()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 750
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.FlatButton9)
        Me.FormSkin1.Controls.Add(Me.FlatButton8)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.FlatButton6)
        Me.FormSkin1.Controls.Add(Me.FlatButton5)
        Me.FormSkin1.Controls.Add(Me.FlatButton4)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.FlatProgressBar1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(800, 341)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Launcher Endora"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton1.Location = New System.Drawing.Point(589, 256)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = True
        Me.FlatButton1.Size = New System.Drawing.Size(199, 56)
        Me.FlatButton1.TabIndex = 4
        Me.FlatButton1.Text = "MISE A JOUR"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton9
        '
        Me.FlatButton9.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton9.Location = New System.Drawing.Point(134, 256)
        Me.FlatButton9.Name = "FlatButton9"
        Me.FlatButton9.Rounded = True
        Me.FlatButton9.Size = New System.Drawing.Size(106, 19)
        Me.FlatButton9.TabIndex = 12
        Me.FlatButton9.Text = "DISCORD"
        Me.FlatButton9.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton8.Location = New System.Drawing.Point(250, 291)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = True
        Me.FlatButton8.Size = New System.Drawing.Size(110, 20)
        Me.FlatButton8.TabIndex = 11
        Me.FlatButton8.Text = "TWITTER"
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Launcher_Endora.My.Resources.Resources.baniere_endora_v1_a
        Me.PictureBox1.Location = New System.Drawing.Point(3, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(794, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton6.Location = New System.Drawing.Point(18, 291)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = True
        Me.FlatButton6.Size = New System.Drawing.Size(110, 20)
        Me.FlatButton6.TabIndex = 8
        Me.FlatButton6.Text = "TOP-SERVEUR"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton5.Location = New System.Drawing.Point(250, 256)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = True
        Me.FlatButton5.Size = New System.Drawing.Size(110, 20)
        Me.FlatButton5.TabIndex = 7
        Me.FlatButton5.Text = "AZERTY"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton4.Location = New System.Drawing.Point(134, 291)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = True
        Me.FlatButton4.Size = New System.Drawing.Size(110, 20)
        Me.FlatButton4.TabIndex = 6
        Me.FlatButton4.Text = "CACHE"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton3.Location = New System.Drawing.Point(18, 256)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = True
        Me.FlatButton3.Size = New System.Drawing.Size(110, 20)
        Me.FlatButton3.TabIndex = 5
        Me.FlatButton3.Text = "SITE"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.FlatButton2.Location = New System.Drawing.Point(374, 256)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = True
        Me.FlatButton2.Size = New System.Drawing.Size(199, 56)
        Me.FlatButton2.TabIndex = 4
        Me.FlatButton2.Text = "JOUER"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.FlatProgressBar1.Location = New System.Drawing.Point(1, 298)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatProgressBar1.Size = New System.Drawing.Size(800, 42)
        Me.FlatProgressBar1.TabIndex = 3
        Me.FlatProgressBar1.Text = "FlatProgressBar1"
        Me.FlatProgressBar1.Value = 0
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(746, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(770, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatContextMenuStrip1
        '
        Me.FlatContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.FlatContextMenuStrip1.Name = "FlatContextMenuStrip1"
        Me.FlatContextMenuStrip1.ShowImageMargin = False
        Me.FlatContextMenuStrip1.Size = New System.Drawing.Size(36, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 341)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher Endora"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatProgressBar1 As FlatProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlatContextMenuStrip1 As FlatContextMenuStrip
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlatButton7 As FlatButton
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatButton9 As FlatButton
    Friend WithEvents Timer2 As Timer
End Class
