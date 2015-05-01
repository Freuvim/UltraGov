<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.btcertificado = New MetroFramework.Controls.MetroButton()
        Me.btativa = New MetroFramework.Controls.MetroButton()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsabrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsativa = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmssair = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbnotifi = New System.Windows.Forms.PictureBox()
        Me.pbfirefox = New System.Windows.Forms.PictureBox()
        Me.pbconfig = New System.Windows.Forms.PictureBox()
        Me.ttinfo = New MetroFramework.Components.MetroToolTip()
        Me.pbinfo = New System.Windows.Forms.PictureBox()
        Me.cmsmenu.SuspendLayout()
        CType(Me.pbnotifi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbfirefox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcertificado
        '
        Me.btcertificado.DisplayFocus = True
        Me.btcertificado.FontWeight = MetroFramework.MetroButtonWeight.Regular
        resources.ApplyResources(Me.btcertificado, "btcertificado")
        Me.btcertificado.Name = "btcertificado"
        Me.btcertificado.TabStop = False
        Me.btcertificado.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ttinfo.SetToolTip(Me.btcertificado, resources.GetString("btcertificado.ToolTip"))
        Me.btcertificado.UseCustomBackColor = True
        Me.btcertificado.UseSelectable = True
        '
        'btativa
        '
        Me.btativa.DisplayFocus = True
        Me.btativa.FontWeight = MetroFramework.MetroButtonWeight.Regular
        resources.ApplyResources(Me.btativa, "btativa")
        Me.btativa.Name = "btativa"
        Me.btativa.Style = MetroFramework.MetroColorStyle.Blue
        Me.btativa.TabStop = False
        Me.btativa.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ttinfo.SetToolTip(Me.btativa, resources.GetString("btativa.ToolTip"))
        Me.btativa.UseCustomBackColor = True
        Me.btativa.UseSelectable = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon, "NotifyIcon")
        Me.NotifyIcon.ContextMenuStrip = Me.cmsmenu
        '
        'cmsmenu
        '
        Me.cmsmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsabrir, Me.cmsativa, Me.cmssair})
        Me.cmsmenu.Name = "cmsmenu"
        resources.ApplyResources(Me.cmsmenu, "cmsmenu")
        '
        'cmsabrir
        '
        Me.cmsabrir.Name = "cmsabrir"
        resources.ApplyResources(Me.cmsabrir, "cmsabrir")
        '
        'cmsativa
        '
        Me.cmsativa.Name = "cmsativa"
        resources.ApplyResources(Me.cmsativa, "cmsativa")
        '
        'cmssair
        '
        Me.cmssair.Name = "cmssair"
        resources.ApplyResources(Me.cmssair, "cmssair")
        '
        'pbnotifi
        '
        Me.pbnotifi.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.pbnotifi, "pbnotifi")
        Me.pbnotifi.Name = "pbnotifi"
        Me.pbnotifi.TabStop = False
        Me.ttinfo.SetToolTip(Me.pbnotifi, resources.GetString("pbnotifi.ToolTip"))
        '
        'pbfirefox
        '
        Me.pbfirefox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbfirefox.Image = Global.UltraGov.My.Resources.Resources.firefox
        resources.ApplyResources(Me.pbfirefox, "pbfirefox")
        Me.pbfirefox.Name = "pbfirefox"
        Me.pbfirefox.TabStop = False
        Me.ttinfo.SetToolTip(Me.pbfirefox, resources.GetString("pbfirefox.ToolTip"))
        '
        'pbconfig
        '
        Me.pbconfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbconfig.Image = Global.UltraGov.My.Resources.Resources.controls
        resources.ApplyResources(Me.pbconfig, "pbconfig")
        Me.pbconfig.Name = "pbconfig"
        Me.pbconfig.TabStop = False
        Me.ttinfo.SetToolTip(Me.pbconfig, resources.GetString("pbconfig.ToolTip"))
        '
        'ttinfo
        '
        Me.ttinfo.Style = MetroFramework.MetroColorStyle.Blue
        Me.ttinfo.StyleManager = Nothing
        Me.ttinfo.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'pbinfo
        '
        Me.pbinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbinfo.Image = Global.UltraGov.My.Resources.Resources.info
        resources.ApplyResources(Me.pbinfo, "pbinfo")
        Me.pbinfo.Name = "pbinfo"
        Me.pbinfo.TabStop = False
        Me.ttinfo.SetToolTip(Me.pbinfo, resources.GetString("pbinfo.ToolTip"))
        '
        'frmmenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Controls.Add(Me.pbinfo)
        Me.Controls.Add(Me.btcertificado)
        Me.Controls.Add(Me.btativa)
        Me.Controls.Add(Me.pbconfig)
        Me.Controls.Add(Me.pbfirefox)
        Me.Controls.Add(Me.pbnotifi)
        Me.MaximizeBox = False
        Me.Name = "frmmenu"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cmsmenu.ResumeLayout(False)
        CType(Me.pbnotifi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbfirefox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbconfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btcertificado As MetroFramework.Controls.MetroButton
    Friend WithEvents btativa As MetroFramework.Controls.MetroButton
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsabrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsativa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmssair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbnotifi As System.Windows.Forms.PictureBox
    Friend WithEvents pbfirefox As System.Windows.Forms.PictureBox
    Friend WithEvents pbconfig As System.Windows.Forms.PictureBox
    Friend WithEvents ttinfo As MetroFramework.Components.MetroToolTip
    Friend WithEvents pbinfo As System.Windows.Forms.PictureBox

End Class
