<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfig
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfig))
        Me.mtinicia = New MetroFramework.Controls.MetroToggle()
        Me.lblinicia = New MetroFramework.Controls.MetroLabel()
        Me.lblnotifi = New MetroFramework.Controls.MetroLabel()
        Me.mtnotifi = New MetroFramework.Controls.MetroToggle()
        Me.btsalvar = New MetroFramework.Controls.MetroButton()
        Me.btcancela = New MetroFramework.Controls.MetroButton()
        Me.ttinfo = New MetroFramework.Components.MetroToolTip()
        Me.SuspendLayout()
        '
        'mtinicia
        '
        Me.mtinicia.AutoSize = True
        Me.mtinicia.Location = New System.Drawing.Point(227, 96)
        Me.mtinicia.Name = "mtinicia"
        Me.mtinicia.Size = New System.Drawing.Size(80, 17)
        Me.mtinicia.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtinicia.TabIndex = 0
        Me.mtinicia.TabStop = False
        Me.mtinicia.Text = "Off"
        Me.mtinicia.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtinicia.UseSelectable = True
        Me.mtinicia.UseStyleColors = True
        '
        'lblinicia
        '
        Me.lblinicia.AutoSize = True
        Me.lblinicia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblinicia.Location = New System.Drawing.Point(23, 95)
        Me.lblinicia.Name = "lblinicia"
        Me.lblinicia.Size = New System.Drawing.Size(145, 19)
        Me.lblinicia.TabIndex = 1
        Me.lblinicia.Text = "Iniciar com o Windows:"
        Me.lblinicia.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblnotifi
        '
        Me.lblnotifi.AutoSize = True
        Me.lblnotifi.Enabled = False
        Me.lblnotifi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblnotifi.Location = New System.Drawing.Point(24, 140)
        Me.lblnotifi.Name = "lblnotifi"
        Me.lblnotifi.Size = New System.Drawing.Size(186, 19)
        Me.lblnotifi.TabIndex = 2
        Me.lblnotifi.Text = "Iniciar na barra de notificação:"
        Me.lblnotifi.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'mtnotifi
        '
        Me.mtnotifi.AutoSize = True
        Me.mtnotifi.Enabled = False
        Me.mtnotifi.Location = New System.Drawing.Point(227, 141)
        Me.mtnotifi.Name = "mtnotifi"
        Me.mtnotifi.Size = New System.Drawing.Size(80, 17)
        Me.mtnotifi.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtnotifi.TabIndex = 3
        Me.mtnotifi.TabStop = False
        Me.mtnotifi.Text = "Off"
        Me.mtnotifi.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ttinfo.SetToolTip(Me.mtnotifi, "Em desenvolvimento...")
        Me.mtnotifi.UseSelectable = True
        Me.mtnotifi.UseStyleColors = True
        '
        'btsalvar
        '
        Me.btsalvar.DisplayFocus = True
        Me.btsalvar.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btsalvar.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btsalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btsalvar.Location = New System.Drawing.Point(149, 244)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(88, 33)
        Me.btsalvar.Style = MetroFramework.MetroColorStyle.Blue
        Me.btsalvar.TabIndex = 4
        Me.btsalvar.TabStop = False
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btsalvar.UseCustomBackColor = True
        Me.btsalvar.UseSelectable = True
        '
        'btcancela
        '
        Me.btcancela.DisplayFocus = True
        Me.btcancela.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btcancela.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btcancela.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btcancela.Location = New System.Drawing.Point(243, 244)
        Me.btcancela.Name = "btcancela"
        Me.btcancela.Size = New System.Drawing.Size(88, 33)
        Me.btcancela.Style = MetroFramework.MetroColorStyle.Blue
        Me.btcancela.TabIndex = 5
        Me.btcancela.TabStop = False
        Me.btcancela.Text = "Cancelar"
        Me.btcancela.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btcancela.UseCustomBackColor = True
        Me.btcancela.UseSelectable = True
        '
        'ttinfo
        '
        Me.ttinfo.Style = MetroFramework.MetroColorStyle.Blue
        Me.ttinfo.StyleManager = Nothing
        Me.ttinfo.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'frmconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(354, 300)
        Me.Controls.Add(Me.btcancela)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.mtnotifi)
        Me.Controls.Add(Me.lblnotifi)
        Me.Controls.Add(Me.lblinicia)
        Me.Controls.Add(Me.mtinicia)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmconfig"
        Me.Resizable = False
        Me.Text = "Configurações"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtinicia As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblinicia As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblnotifi As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtnotifi As MetroFramework.Controls.MetroToggle
    Friend WithEvents btsalvar As MetroFramework.Controls.MetroButton
    Friend WithEvents btcancela As MetroFramework.Controls.MetroButton
    Friend WithEvents ttinfo As MetroFramework.Components.MetroToolTip
End Class
