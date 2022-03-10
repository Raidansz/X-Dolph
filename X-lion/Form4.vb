Imports System.Net.Sockets

Public Class Form4

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text += 1&
        Try

            Dim Range As TcpClient = New TcpClient("127.0.0.1", TextBox1.Text)
            If Range.Connected = True Then
                Ports.Items.Add(TextBox1.Text & " is Open")
            End If
        Catch ex As Exception
            Ports.Items.Add(TextBox1.Text & " is Closed")
            Ports.SelectedIndex = Ports.SelectedIndex + 1
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Timer1.Enabled = True


        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 10000000 Then
            ProgressBar1.Value = 0
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RedemptionButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("are you sure?", MsgBoxStyle.YesNo)
        Timer1.Stop()
        ProgressBar1.Value = 0
        Ports.Text = 0
        Ports.Text = 0

        Ports.Text = 0 = ProgressBar1.Value = 0
        TextBox1.Text = 0
        Ports.Items.Clear()

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

End Class
