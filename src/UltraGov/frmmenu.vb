Imports Microsoft.Win32

Public Class frmmenu
    Dim i As Byte
    Dim fecha As Boolean = True

    Private Sub btcertificado_Click(sender As Object, e As EventArgs) Handles btcertificado.Click
        Try
            'inicia processo para instalar o certificado a partir da pasta UltraGov
            Dim cert As New ProcessStartInfo
            cert.FileName = Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\certificado.crt"
            cert.Arguments = "certmgr.msc"
            Process.Start(cert)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde.", "Antenção",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            'inicia processo para instalar o registro do certificado a partir da pasta UltraGov
            Dim regcert As New ProcessStartInfo
            regcert.FileName = Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\registrador.reg"
            regcert.Arguments = "regedit.exe"
            Process.Start(regcert)
            'se ocorrer um erro ou o usuário não tiver acesso de adm, finaliza o processo do certificado
            'e mostra uma mensagem de erro
        Catch ex As Exception
            Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName("Rundll32")
            For Each x As Process In Processos
                x.Kill()
            Next
            MetroFramework.MetroMessageBox.Show(Me, "É necessário privilégios de administrador!" + vbCrLf + "O Proxy não foi instalado corretamente", "Antenção",
                                                MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub cmsabrir_Click(sender As Object, e As EventArgs) Handles cmsabrir.Click
        'exibe menu e esconte o icone da barra de notificação
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub cmsativa_Click(sender As Object, e As EventArgs) Handles cmsativa.Click
        Try
            Dim pRegKey2 As RegistryKey = Registry.CurrentUser
            pRegKey2 = pRegKey2.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings")
            Dim val2 As Object = pRegKey2.GetValue("AutoConfigURL")
            If val2 <> "" Then
                btativa.Text = "Desativar Proxy"
                cmsativa.Text = "Desativar Proxy"
            Else
                btativa.Text = "Ativar Proxy"
                cmsativa.Text = "Ativar Proxy"
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmssair_Click(sender As Object, e As EventArgs) Handles cmssair.Click
        'finaliza programa
        End
    End Sub

    Private Sub pbnotifi_Click(sender As Object, e As EventArgs) Handles pbnotifi.Click
        'exibe icone na barra de notificação e esconde menu
        NotifyIcon.Visible = True
        Me.Hide()
    End Sub

    Private Sub frmmenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = fecha
            Me.Opacity = 1
            Dim tmr As New Timer
            tmr.Interval = 10
            tmr.Start()
        AddHandler tmr.Tick,
            Sub()
                Me.Opacity -= 0.1
                If Me.Opacity = 0.5 Then Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
                If Me.Opacity = 0 Then
                    fecha = False
                    tmr.Stop()
                    Me.Close()
                End If
            End Sub
    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'efeito fadein ao entrar na tela de menu
        Me.Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 10
        tmr.Start()
        AddHandler tmr.Tick,
            Sub()
                Me.Opacity += 0.1
                If Me.Opacity = 1 Then
                    tmr.Stop()
                End If
            End Sub
        Try
            Dim pRegKey As RegistryKey = Registry.CurrentUser
            pRegKey = pRegKey.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            Dim val As Object = pRegKey.GetValue("UltraGov")
            If val <> "" Then
                frmconfig.mtinicia.CheckState = CheckState.Checked
            Else
                frmconfig.mtinicia.CheckState = CheckState.Unchecked
            End If
            Dim pRegKey2 As RegistryKey = Registry.CurrentUser
            pRegKey2 = pRegKey2.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings")
            Dim val2 As Object = pRegKey2.GetValue("AutoConfigURL")
            If val2 <> "" Then
                btativa.Text = "Desativar Proxy"
                cmsativa.Text = "Desativar Proxy"
            Else
                btativa.Text = "Ativar Proxy"
                cmsativa.Text = "Ativar Proxy"
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        'abre menu ao dar 2 cliques no icone na barra de notificação
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon.Visible = False
    End Sub

    Private Sub pbfirefox_Click(sender As Object, e As EventArgs) Handles pbfirefox.Click
        'inicia o firefox na pagina do google
        Try
            Dim firefox As New ProcessStartInfo
            firefox.FileName = Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable\FirefoxPortable.exe"
            firefox.Arguments = "http://www.google.com.br/"
            Process.Start(firefox)
            'caso dê um erro, exibe uma mensagem de erro
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btativa_Click(sender As Object, e As EventArgs) Handles btativa.Click
        If btativa.Text = "Ativar Proxy" Then
            btativa.Text = "Desativar Proxy"
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                 "AutoConfigURL", "http://pac.zscaler.net/centropaulasouza.sp.gov.br/cpsouza.pac")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                "AutoConfigProxy", "wininet.dll")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            btativa.Text = "Ativar Proxy"
            Try
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                "AutoConfigURL", "")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings",
                "AutoConfigProxy", "")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub pbconfig_Click(sender As Object, e As EventArgs) Handles pbconfig.Click
        frmconfig.ShowDialog()
    End Sub

    Private Sub pbinfo_Click(sender As Object, e As EventArgs) Handles pbinfo.Click
        frmsobre.ShowDialog()
    End Sub
End Class
