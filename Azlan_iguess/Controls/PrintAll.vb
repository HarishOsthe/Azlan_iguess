﻿Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting
Public Class PrintAll
    Dim linepg As Integer
    Dim osthe As Integer = 0
    Dim StringToPrint As String
    Dim ttp As New ToolTip
    Dim babe As String
    Private Sub PrintAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dept_names_load()
            linepg = 50
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub eval_dates()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            If ComboBox1.Text <> "" Then
                ComboBox2.Items.Clear()
                Dim cmd As New OleDbCommand("select distinct Eval_date from FacultyReport where Dept_Name='" & ComboBox1.Text & "'", conn)
                Try
                    Dim dr As OleDbDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        ComboBox2.Items.Add(dr.GetValue(0).ToString)
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub dept_names_load()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            ComboBox1.Items.Clear()
            Dim cmd As New OleDbCommand("Select distinct Dept_Name From FacultyReport", conn)


            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read
                ComboBox1.Items.Add(reader.GetValue(0).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub list()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
                Try
                    Dim ds1 As New DataSet
                    Dim cmd As New OleDbDataAdapter("Select * From FacultyReport where Eval_date='" & ComboBox2.Text & "' and Dept_Name='" & ComboBox1.Text & "'", conn)
                    cmd.Fill(ds1)
                    DG1.DataSource = ds1.Tables(0)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        eval_dates()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        list()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            For hari = osthe To DG1.RowCount - 1
                Dim p1 As New Point(e.MarginBounds.X, 110)
                Dim p2 As New Point(e.PageBounds.Width - e.MarginBounds.X, 110)
                Dim cute As Pen = New Pen(Color.FromArgb(255, 0, 0, 0), 2)

                Dim charval As String = DG1.Rows(hari).Cells(0).Value
                Dim charsub As String = DG1.Rows(hari).Cells(2).Value
                Dim charevaldate As String = DG1.Rows(hari).Cells(3).Value
                Dim charcourse As String = DG1.Rows(hari).Cells(4).Value
                Dim charsem As String = DG1.Rows(hari).Cells(5).Value
                Dim chardept As String = DG1.Rows(hari).Cells(6).Value
                Dim charnum As Integer = DG1.Rows(hari).Cells(8).Value
                Try
                    If charval <> "" Then
                        chart_design(charval, charsub, charevaldate, charcourse, charsem, chardept, charnum)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                e.Graphics.DrawLine(cute, p1, p2)
                'Line from the top / below the jain logo
                '_____________________________________________________________________________________________________________
                Dim font As New Font("Cambria", 30, FontStyle.Bold)
                e.Graphics.DrawString("Jain College", font, Brushes.Black, 340, 28)
                e.Graphics.DrawImage(PictureBox1.Image, 260, 28)
                'Jain logo and Text
                '______________________________________________________________________________________________________________

                Dim font1 As New Font("Times New Roman", 8, FontStyle.Bold)
                e.Graphics.DrawString("#463/465, 18th Main, SS Royal, 80 Feet Road, ", font1, Brushes.Black, 345, 78)
                e.Graphics.DrawString(" Rajarajeshwari Nagar, Bangalore - 560 098", font1, Brushes.Black, 345, 93)
                'Address of jain
                '______________________________________________________________________________________________________________
                Chart1.ChartAreas(0).AxisY.Title = ""
                Chart1.ChartAreas(0).AxisX.Title = ""
                Chart1.Titles.Clear()

                Dim bm As New Bitmap(Chart1.Width, Chart1.Height) '' chart
                Dim rec As New Rectangle(0, 0, Chart1.Width, Chart1.Height)
                Chart1.DrawToBitmap(bm, rec)
                Clipboard.SetImage(bm)
                PictureBox2.Image = bm
                e.Graphics.DrawImage(PictureBox2.Image, 100, 133)
                bm.Dispose()

                Chart1.ChartAreas(0).AxisY.Title = "Ratings"
                Chart1.ChartAreas(0).AxisX.Title = "Questions"
                Chart1.Titles.Add(babe)
                'chart
                '_______________________________________________________________________________________________________________

                Dim font2 As New Font("Georgia", 20, FontStyle.Bold)
                e.Graphics.DrawString("Chart Showing Faculty Evaluation", font2, Brushes.Black, 180, 115)
                'Text above the chart
                '______________________________________________________________________________________________________________

                Dim font4 As New Font("Cambria", 12, FontStyle.Bold)
                e.Graphics.DrawString("Faculty Name :", font4, Brushes.Black, 60, 480)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(1).Value, font4, Brushes.Black, 175, 480) ''Name
                e.Graphics.DrawString("Faculty Code :", font4, Brushes.Black, 490, 480)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(0).Value, font4, Brushes.Black, 600, 480) ''Code

                e.Graphics.DrawString("Subject      ", font4, Brushes.Black, 60, 520)
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(2).Value, font4, Brushes.Black, 165, 520) ''subject
                e.Graphics.DrawString("Evaluation Period", font4, Brushes.Black, 450, 500)
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(3).Value, font4, Brushes.Black, 592, 500) ''eval period
                e.Graphics.DrawString("Class      ", font4, Brushes.Black, 60, 500)
                Dim str As String = ""
                If DG1.Rows(hari).Cells(21).Value.ToString = "-" Then
                    str = ""
                Else
                    str = "'" & DG1.Rows(hari).Cells(21).Value.ToString & "'"
                End If
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(4).Value + " " + DG1.Rows(hari).Cells(5).Value + " " + str, font4, Brushes.Black, 165, 500) ''class

                'details of faculty
                '________________________________________________________________________________________________________________

                Dim xs As Integer = 40
                For i = 1 To 10
                    e.Graphics.DrawRectangle(cute, 60, 545, xs, 35)
                    e.Graphics.DrawRectangle(cute, 60, 545, xs, 80)
                    xs += 40
                Next
                e.Graphics.DrawRectangle(cute, 460, 545, 255, 35)
                e.Graphics.DrawRectangle(cute, 460, 545, 100, 80) ''box next to total
                e.Graphics.DrawRectangle(cute, 460, 545, 255, 80)
                Dim c As String = "Q1"
                Dim pk As Integer = 68
                For i = 1 To 10
                    e.Graphics.DrawString(c, font4, Brushes.Black, pk, 555)
                    c = c.Substring(1) + 1
                    c = "Q" & c
                    pk += 39
                Next
                e.Graphics.DrawString("Total Class", font4, Brushes.Black, pk + 10, 545)
                e.Graphics.DrawString("Strength", font4, Brushes.Black, pk + 20, 560)

                e.Graphics.DrawString("No. of students", font4, Brushes.Black, pk + 120, 545)
                e.Graphics.DrawString("present", font4, Brushes.Black, pk + 140, 560)

                Dim va As Integer = 75
                For i = 1 To 10
                    e.Graphics.DrawString(DG1.Rows(hari).Cells(10 + i).Value, font4, Brushes.Black, va, 595)
                    va += 39
                Next

                e.Graphics.DrawString(DG1.Rows(hari).Cells(7).Value, font4, Brushes.Black, va + 20, 595)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(8).Value, font4, Brushes.Black, va + 150, 595)

                'Table feedback
                '___________________________________________________________________________________________________________________

                StringToPrint = DG1.Rows(hari).Cells(10).Value.ToString

                Dim numChars As Integer
                Dim numLines As Integer
                Dim stringForPage As String
                Dim strFormat As New StringFormat()
                Dim PrintFont As Font
                PrintFont = TextBox1.Font


                e.Graphics.DrawString("Remarks      :", font4, Brushes.Black, 60, 630)
                Dim rectDraw As New RectangleF(75, 650, 680, e.MarginBounds.Height)
                Dim sizeMeasure As New SizeF(680, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))
                strFormat.Trimming = StringTrimming.Word
                e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)
                stringForPage = StringToPrint.Substring(0, numChars)
                Dim font5 As New Font("Calibri (Body)", 10, FontStyle.Bold Or FontStyle.Italic)
                e.Graphics.DrawString("'" + stringForPage + "'", font5, Brushes.Black, rectDraw, strFormat)
                'remarks
                '____________________________________________________________________________________________________________________

                Dim p11 As New Point(e.MarginBounds.X, 800)
                Dim p22 As New Point(e.PageBounds.Width - e.MarginBounds.X, 800)
                e.Graphics.DrawLine(cute, p11, p22)
                'line
                '____________________________________________________________________________________________________________________
                Dim font6 As New Font("Cambria Math", 9, FontStyle.Bold)
                e.Graphics.DrawString("Q1) Does the faculty explain the concepts very clearly and" + vbNewLine + "       covers all the topics as per the syllabus?", font6, Brushes.Black, e.MarginBounds.X + 5, 805)
                e.Graphics.DrawString("Q7) Does the faculty able to control the class well and deals" + vbNewLine + "        with the students maturely and professionally?", font6, Brushes.Black, 410, 805)

                e.Graphics.DrawString("Q2) Does the faculty able to relate the concepts to both theory" + vbNewLine + "       and practical aspects?", font6, Brushes.Black, e.MarginBounds.X + 5, 835)
                e.Graphics.DrawString("Q8) Does the faculty effectively uses the black board / charts /" + vbNewLine + "       OHP / PPT / Demo and notes for better communication?", font6, Brushes.Black, 410, 835)

                e.Graphics.DrawString("Q3) Does the faculty encourage students participation in the" + vbNewLine + "       class and build interest in the subject?", font6, Brushes.Black, e.MarginBounds.X + 5, 865)
                e.Graphics.DrawString("Q9) Does the faculty help the students from the examination" + vbNewLine + "       point of view (Question paper, relevant material etc.)", font6, Brushes.Black, 410, 865)

                e.Graphics.DrawString("Q4) Does the faculty maintain punctuality and engage the" + vbNewLine + "       entire hour productively?", font6, Brushes.Black, e.MarginBounds.X + 5, 895)
                e.Graphics.DrawString("Q10) The overall rating of the faculty is", font6, Brushes.Black, 410, 900)

                e.Graphics.DrawString("Q5) Does the faculty address subject related queries / doubts" + vbNewLine + "       and provide convincing solutions?", font6, Brushes.Black, e.MarginBounds.X + 5, 925)
                e.Graphics.DrawString("Q6) Does the assignments / worked-out problems / case studies /" + vbNewLine + "       presentation provided in each of the concepts help students to develop" + vbNewLine + "       practical knowledge?", font6, Brushes.Black, e.MarginBounds.X + 5, 955)

                Dim p111 As New Point(220, 1010)
                Dim p222 As New Point(580, 1010)
                e.Graphics.DrawLine(Pens.Black, p111, p222)
                Dim font7 As New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                Dim font8 As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                Dim font9 As New Font("Rage Italic", 11)
                e.Graphics.DrawString("Software Solutions by Azlan Soft Works", font7, Brushes.Black, 270, 1020)
                e.Graphics.DrawImage(PictureBox3.Image, 650, 980)
                e.Graphics.DrawString("Report generated using ♥iguess", font8, Brushes.Black, e.MarginBounds.X + 5, 1020)
                e.Graphics.DrawString("Love What You Do..", font9, Brushes.Black, 340, 1050)


                '___________________________________________________________________________________________________________________________________
                Dim bpen As Pen = New Pen(Color.FromArgb(255, 0, 0, 0), 5) ''border
                e.Graphics.DrawRectangle(bpen, e.MarginBounds) '5, 5, 775, 1126) ''border
                'Border
                '___________________________________________________________________________________________________________________________________
                osthe = hari + 1
                If osthe <> DG1.RowCount - 1 Then e.HasMorePages = True
                If osthe = DG1.RowCount - 1 Then osthe = 0
                Exit For
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub chart_design(ByVal charval As String, ByVal charsub As String, ByVal charevaldate As String, ByVal charcourse As String, ByVal charsem As String, ByVal chardept As String, ByVal charnum As Integer)

        Chart1.Series.Clear()
        Chart1.Series.Add("FacultyReport")
        Chart1.BackColor = Color.Transparent
        Try
            With Chart1.ChartAreas(0)
                .AxisY.Interval = 1
                .AxisY.Maximum = 7
                .AxisY.Minimum = 0
                .AxisY.MajorGrid.LineColor = Color.Transparent
                .AxisY.Title = "Ratings"


                .AxisX.Interval = 1
                .AxisX.Maximum = 11
                .AxisX.Minimum = 0
                .AxisX.MajorGrid.LineColor = Color.Transparent
                .AxisX.Title = "Questions"

                .BackColor = Color.Transparent
                .BorderDashStyle = ChartDashStyle.Solid
                .BorderWidth = 2
                .ShadowOffset = 15
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("select Fac_Name,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10 from FacultyReport where Fac_Code='" & charval & "' and sub='" & charsub & "' and Eval_date='" & charevaldate & "' and Course='" & charcourse & "' and Stream='" & charsem & "' and Dept_Name='" & chardept & "' and no_of_present=" & charnum & "", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            dr.Read()

            Chart1.Titles.Clear()
            Chart1.Titles.Add(dr("Fac_Name").ToString)
            babe = dr("Fac_Name").ToString
            With Chart1.Series("FacultyReport")
                .Points.Clear()
                .Points.Add(dr("q1").ToString).Label = dr("q1").ToString
                .Points.Add(dr("q2").ToString).Label = dr("q2").ToString
                .Points.Add(dr("q3").ToString).Label = dr("q3").ToString
                .Points.Add(dr("q4").ToString).Label = dr("q4").ToString
                .Points.Add(dr("q5").ToString).Label = dr("q5").ToString
                .Points.Add(dr("q6").ToString).Label = dr("q6").ToString
                .Points.Add(dr("q7").ToString).Label = dr("q7").ToString
                .Points.Add(dr("q8").ToString).Label = dr("q8").ToString
                .Points.Add(dr("q9").ToString).Label = dr("q9").ToString
                .Points.Add(dr("q10").ToString).Label = dr("q10").ToString


                .Points(0).AxisLabel = "Q1"
                .Points(1).AxisLabel = "Q2"
                .Points(2).AxisLabel = "Q3"
                .Points(3).AxisLabel = "Q4"
                .Points(4).AxisLabel = "Q5"
                .Points(5).AxisLabel = "Q6"
                .Points(6).AxisLabel = "Q7"
                .Points(7).AxisLabel = "Q8"
                .Points(8).AxisLabel = "Q9"
                .Points(9).AxisLabel = "Q10"

                .Points(0).Color = Color.Violet
                .Points(1).Color = Color.MediumSlateBlue
                .Points(2).Color = Color.Violet
                .Points(3).Color = Color.MediumSlateBlue
                .Points(4).Color = Color.Violet
                .Points(5).Color = Color.MediumSlateBlue
                .Points(6).Color = Color.Violet
                .Points(7).Color = Color.MediumSlateBlue
                .Points(8).Color = Color.Violet
                .Points(9).Color = Color.MediumSlateBlue

            End With
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            PrintDialog1.Document = PrintDocument1


            If PrintDialog1.ShowDialog = DialogResult.OK Then
                PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings

                'Dim new_paper As New PaperSize("", 500, 500)
                'new_paper.PaperName = PaperKind.Custom

                'Dim new_margin As New Printing.Margins
                'new_margin.Left = 0
                'new_margin.Top = 50

                With PrintDocument1
                    Dim new_margin As New Printing.Margins
                    new_margin.Left = 24
                    new_margin.Top = 24
                    new_margin.Right = 24
                    new_margin.Left = 24
                    .DefaultPageSettings.PaperSize = (From s As PaperSize In PrintDocument1.PrinterSettings.PaperSizes.Cast(Of PaperSize) Where s.RawKind = PaperKind.A4).FirstOrDefault
                    .DefaultPageSettings.Margins = new_margin
                    .PrinterSettings.DefaultPageSettings.Landscape = False
                    .Print()
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DG1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG1.CellMouseClick
        Try
            If DG1.CurrentRow.Cells(10).Value.ToString <> "" And DG1.CurrentRow.Cells(0).Value.ToString <> "" Then
                TextBox1.ForeColor = Color.Black
                TextBox1.Text = DG1.CurrentRow.Cells(10).Value
            ElseIf DG1.CurrentRow.Cells(0).Value.ToString <> "" Then
                TextBox1.ForeColor = Color.DarkSlateGray
                TextBox1.Text = "NO REMARKS FOR " & DG1.CurrentRow.Cells(1).Value.ToString
            Else
                TextBox1.Text = ""
            End If
            Label4.Text = "FeedBacks of " + DG1.CurrentRow.Cells(8).Value.ToString + " outof " + DG1.CurrentRow.Cells(7).Value.ToString + " Students"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd1 As New OleDbCommand("update FacultyReport set Pri_Remarks='" & TextBox1.Text & "' where Fac_Code='" & DG1.CurrentRow.Cells(0).Value & "' and sub='" & DG1.CurrentRow.Cells(2).Value & "' and Eval_date='" & DG1.CurrentRow.Cells(3).Value & "' and Course='" & DG1.CurrentRow.Cells(4).Value & "' and Stream='" & DG1.CurrentRow.Cells(5).Value & "'", conn)
            cmd1.ExecuteNonQuery()
            list()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuImageButton1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, BunifuImageButton1.MouseEnter
        Try
            Select Case sender.Name.ToString
                Case "BunifuImageButton1"
                    ttp.Show("Save the principal's comment", BunifuImageButton1)
                Case "Button1"
                    ttp.Show("Print all", Button1)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, BunifuImageButton1.MouseLeave
        Try
            Select Case sender.Name.ToString
                Case "BunifuImageButton1"
                    ttp.Hide(BunifuImageButton1)
                Case "Button1"
                    ttp.Hide(Button1)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
