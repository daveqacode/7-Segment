Public Class Form1

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval

            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim index As Byte = 0

        While index < 1
            '0'

            TextBox1.BackColor = Color.Red
            TextBox2.BackColor = Color.Red
            TextBox3.BackColor = Color.Red
            TextBox4.BackColor = Color.Red
            TextBox5.BackColor = Color.Red
            TextBox6.BackColor = Color.Red
            TextBox7.BackColor = Color.Black
            TextBox8.BackColor = Color.Black
            TextBox9.BackColor = Color.Black
            TextBox10.BackColor = Color.Red
            TextBox11.BackColor = Color.Red
            TextBox12.BackColor = Color.Black
            TextBox13.BackColor = Color.Black
            TextBox14.BackColor = Color.Black
            TextBox15.BackColor = Color.Red
            TextBox16.BackColor = Color.Red
            TextBox17.BackColor = Color.Black
            TextBox18.BackColor = Color.Black
            TextBox19.BackColor = Color.Black
            TextBox20.BackColor = Color.Red
            TextBox21.BackColor = Color.Red
            TextBox22.BackColor = Color.Red
            TextBox23.BackColor = Color.Red
            TextBox24.BackColor = Color.Red
            TextBox25.BackColor = Color.Red

            '1'
            wait(1000)
            TextBox1.BackColor = Color.Black
            TextBox2.BackColor = Color.Black
            TextBox3.BackColor = Color.Black
            TextBox4.BackColor = Color.Black
            TextBox6.BackColor = Color.Black
            TextBox11.BackColor = Color.Black
            TextBox16.BackColor = Color.Black
            TextBox21.BackColor = Color.Black
            TextBox22.BackColor = Color.Black
            TextBox23.BackColor = Color.Black
            TextBox24.BackColor = Color.Black

            '2'
            wait(1000)
            TextBox1.BackColor = Color.Red
            TextBox2.BackColor = Color.Red
            TextBox3.BackColor = Color.Red
            TextBox4.BackColor = Color.Red
            TextBox6.BackColor = Color.Black
            TextBox11.BackColor = Color.Red
            TextBox12.BackColor = Color.Red
            TextBox13.BackColor = Color.Red
            TextBox14.BackColor = Color.Red
            TextBox16.BackColor = Color.Red
            TextBox20.BackColor = Color.Black
            TextBox21.BackColor = Color.Red
            TextBox22.BackColor = Color.Red
            TextBox23.BackColor = Color.Red
            TextBox24.BackColor = Color.Red
            TextBox25.BackColor = Color.Red

            '3'
            wait(1000)

            TextBox16.BackColor = Color.Black
            TextBox20.BackColor = Color.Red

            '4'
            wait(1000)
            TextBox2.BackColor = Color.Black
            TextBox3.BackColor = Color.Black
            TextBox4.BackColor = Color.Black
            TextBox6.BackColor = Color.Red
            TextBox11.BackColor = Color.Red
            TextBox12.BackColor = Color.Red
            TextBox13.BackColor = Color.Red
            TextBox14.BackColor = Color.Red
            TextBox21.BackColor = Color.Black
            TextBox22.BackColor = Color.Black
            TextBox23.BackColor = Color.Black
            TextBox24.BackColor = Color.Black

            '5'
            wait(1000)
            TextBox2.BackColor = Color.Red
            TextBox3.BackColor = Color.Red
            TextBox4.BackColor = Color.Red
            TextBox10.BackColor = Color.Black
            TextBox21.BackColor = Color.Red
            TextBox22.BackColor = Color.Red
            TextBox23.BackColor = Color.Red
            TextBox24.BackColor = Color.Red

            '6'
            wait(1000)
            TextBox16.BackColor = Color.Red

            '7'
            wait(1000)
            TextBox6.BackColor = Color.Black
            TextBox10.BackColor = Color.Red
            TextBox11.BackColor = Color.Black
            TextBox12.BackColor = Color.Black
            TextBox13.BackColor = Color.Black
            TextBox14.BackColor = Color.Black
            TextBox16.BackColor = Color.Black
            TextBox21.BackColor = Color.Black
            TextBox22.BackColor = Color.Black
            TextBox23.BackColor = Color.Black
            TextBox24.BackColor = Color.Black

            '8'
            wait(1000)
            TextBox6.BackColor = Color.Red
            TextBox11.BackColor = Color.Red
            TextBox12.BackColor = Color.Red
            TextBox13.BackColor = Color.Red
            TextBox14.BackColor = Color.Red
            TextBox16.BackColor = Color.Red
            TextBox21.BackColor = Color.Red
            TextBox22.BackColor = Color.Red
            TextBox23.BackColor = Color.Red
            TextBox24.BackColor = Color.Red

            '9'
            wait(1000)
            TextBox16.BackColor = Color.Black


            wait(1000)
        End While
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class
