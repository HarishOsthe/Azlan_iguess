Imports Azlan_iguess

Public Class Form1
    Dim ttp As New ToolTip
    Private Sub buteval_Click(sender As Object, e As EventArgs) Handles buteval.Click
        buteval.Normalcolor = Color.Plum
        butprint.Normalcolor = Color.Transparent
        butreport.Normalcolor = Color.Transparent
        butabout.Normalcolor = Color.Transparent

        p1.Height = buteval.Height
        p1.Top = buteval.Top
        If Lets1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
            BunifuTransition1.HideSync(Lets1)
            Evaluation1.Show()
            ''BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
            ''BunifuTransition1.ShowSync(Evaluation1)
        ElseIf Report1.Visible = True Or PrintAll1.Visible = True Or About1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Report1)
            BunifuTransition1.HideSync(PrintAll1)
            BunifuTransition1.HideSync(About1)
            BunifuTransition1.ShowSync(Evaluation1)
        End If

    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub butreport_Click(sender As Object, e As EventArgs) Handles butreport.Click
        buteval.Normalcolor = Color.Transparent
        butprint.Normalcolor = Color.Transparent
        butreport.Normalcolor = Color.Plum
        butabout.Normalcolor = Color.Transparent

        p1.Height = butreport.Height
        p1.Top = butreport.Top

        If Lets1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
            BunifuTransition1.HideSync(Lets1)
            Report1.Show()
            Report1.eval_dates()
            ''BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
            ''BunifuTransition1.ShowSync(Report1)

        ElseIf Evaluation1.Visible = True Or PrintAll1.Visible = True Or About1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Evaluation1)
            BunifuTransition1.HideSync(PrintAll1)
            BunifuTransition1.HideSync(About1)
            BunifuTransition1.ShowSync(Report1)
            Report1.eval_dates()
        End If
    End Sub

    Private Sub butprint_Click(sender As Object, e As EventArgs) Handles butprint.Click
        buteval.Normalcolor = Color.Transparent
        butprint.Normalcolor = Color.Plum
        butreport.Normalcolor = Color.Transparent
        butabout.Normalcolor = Color.Transparent

        p1.Height = butprint.Height
        p1.Top = butprint.Top

        If Lets1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
            BunifuTransition1.HideSync(Lets1)
            PrintAll1.Show()
            PrintAll1.dept_names_load()
            ''BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
            ''BunifuTransition1.ShowSync(PrintAll1)

        ElseIf Report1.Visible = True Or Evaluation1.Visible = True Or About1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Evaluation1)
            BunifuTransition1.HideSync(Report1)
            BunifuTransition1.HideSync(About1)
            BunifuTransition1.ShowSync(PrintAll1)
            PrintAll1.dept_names_load()
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 1218
        Me.Height = 717
        p1.Location = New Point(208, 176)

        buteval.Width = 224
        buteval.Height = 48
        buteval.Location = New Point(0, 176)
        buteval.TextAlign = ContentAlignment.MiddleLeft

        butreport.Width = 224
        butreport.Height = 48
        butreport.Location = New Point(0, 263)
        butreport.TextAlign = ContentAlignment.MiddleLeft

        butprint.Width = 224
        butprint.Height = 48
        butprint.Location = New Point(0, 357)
        butprint.TextAlign = ContentAlignment.MiddleLeft

        Panel1.Width = 216
        Panel1.Height = 717

        Panel2.Width = 1002
        Panel2.Height = 47

    End Sub

    Private Sub butabout_Click(sender As Object, e As EventArgs) Handles butabout.Click
        buteval.Normalcolor = Color.Transparent
        butprint.Normalcolor = Color.Transparent
        butreport.Normalcolor = Color.Transparent
        butabout.Normalcolor = Color.Plum

        p1.Height = butabout.Height
        p1.Top = butabout.Top

        If Lets1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
            BunifuTransition1.HideSync(Lets1)
            About1.Show()

            ''BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
            ''BunifuTransition1.ShowSync(About1)
        ElseIf Report1.Visible = True Or Evaluation1.Visible = True Or PrintAll1.Visible = True Then
            BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Evaluation1)
            BunifuTransition1.HideSync(Report1)
            BunifuTransition1.HideSync(PrintAll1)
            BunifuTransition1.ShowSync(About1)
        End If
    End Sub

    Private Sub BunifuImageButton1_MouseEnter(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseEnter, BunifuImageButton2.MouseEnter, PictureBox3.MouseEnter
        Select Case sender.Name.ToString
            Case "BunifuImageButton1"
                ttp.Show("Close", BunifuImageButton1)
            Case "BunifuImageButton2"
                ttp.Show("Minimize", BunifuImageButton2)
            Case "PictureBox3"
                ttp.Show("Click to View Documentaion", PictureBox3)
        End Select
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter, PictureBox1.MouseEnter
        ttp.Show("8 1 18 19 8 9 14 9", PictureBox2)
        ttp.Show("8 1 18 19 8 9 14 9", PictureBox1)
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, PictureBox1.MouseLeave
        ttp.Hide(PictureBox2)
        ttp.Hide(PictureBox1)
    End Sub
    Private Sub BunifuImageButton2_MouseLeave(sender As Object, e As EventArgs) Handles BunifuImageButton2.MouseLeave, BunifuImageButton1.MouseLeave, PictureBox3.MouseLeave
        Select Case sender.Name.ToString
            Case "BunifuImageButton1"
                ttp.Hide(BunifuImageButton1)
            Case "BunifuImageButton2"
                ttp.Hide(BunifuImageButton2)
            Case "PictureBox3"
                ttp.Hide(PictureBox3)
        End Select
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim url As String = “https://github.com/HarishOsthe/Azlan_iguess“
        Process.Start(url)
    End Sub
End Class
