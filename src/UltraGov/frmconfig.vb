Public Class frmconfig

    Private Sub mtinicia_CheckedChanged(sender As Object, e As EventArgs) Handles mtinicia.CheckedChanged
        If mtinicia.CheckState = CheckState.Checked Then
            Try
                My.Settings.iniciawindows = True
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",
                        My.Application.Info.Title, My.Application.Info.DirectoryPath & "\" & My.Application.Info.Title & ".exe")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtinicia.CheckState = CheckState.Unchecked
            End Try
        Else
            Try
                My.Settings.iniciawindows = False
                Dim key As String = My.Application.Info.DirectoryPath & "\" & My.Application.Info.Title & ".exe"
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",
                        My.Application.Info.Title, "")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub mtnotifi_CheckedChanged(sender As Object, e As EventArgs) Handles mtnotifi.CheckedChanged
        If mtnotifi.CheckState = CheckState.Checked Then
            My.Settings.iniciarnotifi = True
        Else
            My.Settings.iniciarnotifi = False
        End If
    End Sub

    Private Sub btcancela_Click(sender As Object, e As EventArgs) Handles btcancela.Click
        Me.Close()
    End Sub

    Private Sub frmconfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'efeito de fadeout ao sair da tela de config
        e.Cancel = True
        Me.Opacity = 1
        Dim tmr As New Timer
        tmr.Interval = 10
        tmr.Start()
        AddHandler tmr.Tick,
            Sub()
                Me.Opacity -= 0.1
                If Me.Opacity = 0.5 Then Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
                If Me.Opacity = 0 Then
                    tmr.Stop()
                    Me.Dispose()
                End If
            End Sub
    End Sub

    Private Sub frmconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'efeito fadein ao entrar na tela de config
        Me.Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 10
        tmr.Start()
        AddHandler tmr.Tick,
            Sub()
                Me.Opacity += 0.1
                If Me.Opacity = 0.2 Then Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
                If Me.Opacity = 1 Then
                    Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.Flat
                    tmr.Stop()
                End If
            End Sub
    End Sub
End Class