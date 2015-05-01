Public Class frmsobre

    Private Sub frmsobre_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'efeito de fadeout ao sair da tela sobre
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

    Private Sub frmsobre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'efeito fadein ao entrar na tela sobre
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

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        Me.Close()
    End Sub
End Class