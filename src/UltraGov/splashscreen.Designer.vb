<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        Me.tmcarrega = New System.Windows.Forms.Timer(Me.components)
        Me.progressbar = New MetroFramework.Controls.MetroProgressBar()
        Me.tmatrasa = New System.Windows.Forms.Timer(Me.components)
        Me.lblver = New MetroFramework.Controls.MetroLabel()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmcarrega
        '
        Me.tmcarrega.Interval = 60
        '
        'progressbar
        '
        Me.progressbar.FontWeight = MetroFramework.MetroProgressBarWeight.Regular
        Me.progressbar.HideProgressText = False
        resources.ApplyResources(Me.progressbar, "progressbar")
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Style = MetroFramework.MetroColorStyle.Blue
        Me.progressbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.progressbar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.progressbar.UseWaitCursor = True
        '
        'tmatrasa
        '
        Me.tmatrasa.Interval = 60
        '
        'lblver
        '
        resources.ApplyResources(Me.lblver, "lblver")
        Me.lblver.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblver.Name = "lblver"
        Me.lblver.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblver.UseWaitCursor = True
        '
        'pblogo
        '
        Me.pblogo.Image = Global.UltraGov.My.Resources.Resources.Logo
        resources.ApplyResources(Me.pblogo, "pblogo")
        Me.pblogo.Name = "pblogo"
        Me.pblogo.TabStop = False
        Me.pblogo.UseWaitCursor = True
        '
        'splashscreen
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Controls.Add(Me.pblogo)
        Me.Controls.Add(Me.lblver)
        Me.Controls.Add(Me.progressbar)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "splashscreen"
        Me.Resizable = False
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.UseWaitCursor = True
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmcarrega As System.Windows.Forms.Timer
    Friend WithEvents progressbar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents tmatrasa As System.Windows.Forms.Timer
    Friend WithEvents lblver As MetroFramework.Controls.MetroLabel
    Friend WithEvents pblogo As System.Windows.Forms.PictureBox
End Class
