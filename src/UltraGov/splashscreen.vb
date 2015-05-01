Imports System
Imports System.IO
Imports Ionic.Zip

Public Class splashscreen
    Dim conte As Byte, i As Byte
    Dim existeC As Boolean = False, existeR As Boolean = False, fecha As Boolean = True

    Private Sub tmcarrega_Tick(sender As Object, e As EventArgs) Handles tmcarrega.Tick
        conte += 1
        progressbar.Value = conte
        If progressbar.Value = 20 Then
            Try
                'verifica se existe a pasta UltraGov, se não existir cria
                If Not Directory.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov") Then
                    Directory.CreateDirectory(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov")
                End If
                'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
            Catch ex As Exception
                conte = 0
                progressbar.Value = 0
                tmcarrega.Stop()
                If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End Try
        End If
        If progressbar.Value = 40 Then
            Try
                'verifica existencia dos arquivos e os cria
                'verifica o certificado
                If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\certificado.crt") Then
                    Try
                        Dim ms As New IO.MemoryStream(My.Resources.certificado)
                        Dim fs As IO.FileStream = IO.File.OpenWrite(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\certificado.crt")
                        ms.WriteTo(fs)
                        fs.Close()
                        'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
                    Catch ex As Exception
                        conte = 0
                        progressbar.Value = 0
                        tmcarrega.Stop()
                        If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                            Me.Close()
                        End If
                    End Try
                End If
                'verifica o arquivo de registro do certificado
                If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\registrador.reg") Then
                    Try
                        Dim ms As New IO.MemoryStream(My.Resources.registrador)
                        Dim fs As IO.FileStream = IO.File.OpenWrite(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\registrador.reg")
                        ms.WriteTo(fs)
                        fs.Close()
                        'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
                    Catch ex As Exception
                        conte = 0
                        progressbar.Value = 0
                        tmcarrega.Stop()
                        If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                            Me.Close()
                        End If
                    End Try
                End If
                'verifica se o arquivo zip com o firefox está na pasta
                If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable.zip") Then
                    Try
                        Dim ms As New IO.MemoryStream(My.Resources.FirefoxPortable)
                        Dim fs As IO.FileStream = IO.File.OpenWrite(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable.zip")
                        ms.WriteTo(fs)
                        fs.Close()
                        'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
                    Catch ex As Exception
                        conte = 0
                        progressbar.Value = 0
                        tmcarrega.Stop()
                        If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                            Me.Close()
                        End If
                    End Try
                End If
                'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
            Catch ex As Exception
                conte = 0
                progressbar.Value = 0
                tmcarrega.Stop()
                If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End Try
        End If
        If progressbar.Value = 60 Then
            'verifica o firefox e extrai caso não esteja na pasta
            If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable\FirefoxPortable.exe") Then
                Try
                    Using zip As ZipFile = ZipFile.Read(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable.zip")
                        'Varre todos os arquivos
                        For Each entry As ZipEntry In zip
                            'Extrai os arquivos e sobrescreve caso já exista
                            entry.Extract(Environment.GetEnvironmentVariable("APPDATA") & "\UltraGov\FirefoxPortable", ExtractExistingFileAction.OverwriteSilently)
                        Next
                    End Using
                    'se ocorrer um erro, para tudo, da uma mensagem de erro e sai do programa
                Catch ex As Exception
                    conte = 0
                    progressbar.Value = 0
                    tmcarrega.Stop()
                    If MetroFramework.MetroMessageBox.Show(Me, "Ocorreu um erro!" + vbCrLf + "Tente novamente ou mais tarde." + vbCrLf + ex.Message, "Antenção",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                        Me.Close()
                    End If
                End Try
            End If
        End If
        If progressbar.Value = 100 Then
            'inicia atraso para abrir o menu
            tmatrasa.Start()
        End If
    End Sub

    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblver.Text = System.String.Format(lblver.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        'efeito fadein ao entrar na tela de splashscreen
        Me.Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 10
        tmr.Start()
        AddHandler tmr.Tick,
            Sub()
                Me.Opacity += 0.1
                If Me.Opacity = 1 Then
                    tmr.Stop()
                    tmcarrega.Start()
                End If
            End Sub
    End Sub

    Private Sub tmatrasa_Tick(sender As Object, e As EventArgs) Handles tmatrasa.Tick
        'atraso para preencher o progressbar
        i += 1
        If i = 10 Then
            tmcarrega.Stop()
            tmatrasa.Stop()
            frmmenu.Show()
            Me.Close()
        End If
    End Sub
End Class