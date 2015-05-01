<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsobre))
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.btok = New MetroFramework.Controls.MetroButton()
        Me.tlpsobre = New System.Windows.Forms.TableLayoutPanel()
        Me.rtbsobre = New System.Windows.Forms.RichTextBox()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpsobre.SuspendLayout()
        Me.SuspendLayout()
        '
        'pblogo
        '
        Me.pblogo.Image = Global.UltraGov.My.Resources.Resources.Logo
        Me.pblogo.Location = New System.Drawing.Point(279, 23)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(136, 31)
        Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pblogo.TabIndex = 0
        Me.pblogo.TabStop = False
        '
        'btok
        '
        Me.btok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btok.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btok.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btok.Location = New System.Drawing.Point(317, 300)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(75, 23)
        Me.btok.TabIndex = 1
        Me.btok.TabStop = False
        Me.btok.Text = "&OK"
        Me.btok.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btok.UseSelectable = True
        '
        'tlpsobre
        '
        Me.tlpsobre.ColumnCount = 1
        Me.tlpsobre.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpsobre.Controls.Add(Me.btok, 0, 1)
        Me.tlpsobre.Controls.Add(Me.rtbsobre, 0, 0)
        Me.tlpsobre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpsobre.Location = New System.Drawing.Point(20, 60)
        Me.tlpsobre.Name = "tlpsobre"
        Me.tlpsobre.RowCount = 2
        Me.tlpsobre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297.0!))
        Me.tlpsobre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpsobre.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpsobre.Size = New System.Drawing.Size(395, 326)
        Me.tlpsobre.TabIndex = 2
        '
        'rtbsobre
        '
        Me.rtbsobre.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.rtbsobre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbsobre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rtbsobre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbsobre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbsobre.ForeColor = System.Drawing.Color.White
        Me.rtbsobre.Location = New System.Drawing.Point(3, 3)
        Me.rtbsobre.Name = "rtbsobre"
        Me.rtbsobre.ReadOnly = True
        Me.rtbsobre.Size = New System.Drawing.Size(389, 291)
        Me.rtbsobre.TabIndex = 2
        Me.rtbsobre.TabStop = False
        Me.rtbsobre.Text = resources.GetString("rtbsobre.Text")
        '
        'frmsobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(435, 406)
        Me.Controls.Add(Me.tlpsobre)
        Me.Controls.Add(Me.pblogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmsobre"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sobre"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpsobre.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pblogo As System.Windows.Forms.PictureBox
    Friend WithEvents btok As MetroFramework.Controls.MetroButton
    Friend WithEvents tlpsobre As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rtbsobre As System.Windows.Forms.RichTextBox
End Class
