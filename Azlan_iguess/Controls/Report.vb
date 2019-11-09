Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Report
    Dim s As Boolean = False
    Dim StringToPrint As String
    Dim ttp As New ToolTip
    Dim babe As String
    Sub dept_names_load()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            If ComboBox2.Text <> "" Then
                ComboBox1.Items.Clear()
                Dim cmd As New OleDbCommand("Select distinct Dept_Name From FacultyReport where Eval_date='" & ComboBox2.Text & "'", conn)
                Try
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read
                        ComboBox1.Items.Add(reader.GetValue(0).ToString)
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub ''4th
    Sub facsub()
        Try
            If ComboBox1.Text <> "" Then
                Try
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()

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
    Sub eval_dates()
        Try
            ComboBox2.Items.Clear()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As New OleDbCommand("select distinct Eval_date from FacultyReport", conn)

            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            While dr.Read()
                ComboBox2.Items.Add(dr.GetValue(0).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub ''2nd
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
            Dim av As Double = (((Val(dr("q1").ToString) + Val(dr("q2").ToString) + Val(dr("q3").ToString) + Val(dr("q4").ToString) + Val(dr("q5").ToString) + Val(dr("q6").ToString) + Val(dr("q7").ToString) + Val(dr("q8").ToString) + Val(dr("q9").ToString) + Val(dr("q10").ToString)) * 10) / 84)
            Progressbar1.ResetText()
            Progressbar1.MaxValue = 10
            Progressbar1.animated = True
            Progressbar1.Value = av

            Select Case Math.Round(av)
                Case 1, 2, 3
                    Rating1.Value = 1
                Case 4, 5, 6
                    Rating1.Value = 2
                Case 7, 8, 9
                    Rating1.Value = 3
                Case 10, 11
                    Rating1.Value = 4
                Case 12
                    Rating1.Value = 5
            End Select

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
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        dept_names_load()
    End Sub ''3rd
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        facsub()
    End Sub
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eval_dates()
    End Sub ''1st
    Private Sub DG1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG1.CellMouseClick
        Dim charval As String
        Dim charsub As String
        Dim charevaldate As String
        Dim charcourse As String
        Dim charsem As String
        Dim chardept As String
        Dim charnum As Integer
        Dim chartot As Integer


        Try
            If IsDBNull(DG1.CurrentRow.Cells(0).Value) Then
            Else
                charval = DG1.CurrentRow.Cells(0).Value
                charsub = DG1.CurrentRow.Cells(2).Value
                charevaldate = DG1.CurrentRow.Cells(3).Value
                charcourse = DG1.CurrentRow.Cells(4).Value
                charsem = DG1.CurrentRow.Cells(5).Value
                chardept = DG1.CurrentRow.Cells(6).Value
                charnum = DG1.CurrentRow.Cells(8).Value
                chartot = DG1.CurrentRow.Cells(7).Value
                If charval <> "" Then
                    chart_design(charval, charsub, charevaldate, charcourse, charsem, chardept, charnum)
                    Label4.Text = "Overall ratings by " + charnum.ToString + " outof " + chartot.ToString + " students."
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("Select Pri_Remarks from FacultyReport where Fac_Code='" & DG1.CurrentRow.Cells(0).Value & "' and sub='" & DG1.CurrentRow.Cells(2).Value & "' and Eval_date='" & DG1.CurrentRow.Cells(3).Value & "' and Course='" & DG1.CurrentRow.Cells(4).Value & "' and Stream='" & DG1.CurrentRow.Cells(5).Value & "'", conn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read
                If reader.GetValue(0).ToString <> "" Then
                    TextBox1.ForeColor = Color.Black
                    TextBox1.Text = reader.GetValue(0).ToString
                Else
                    TextBox1.ForeColor = Color.DarkSlateGray
                    TextBox1.Text = "NO REMARKS FOR " & DG1.CurrentRow.Cells(1).Value.ToString
                End If
            End While
            Dim str As String = DG1.CurrentRow.Cells(9).Value.ToString

            Dim d() As String
            d = Split(str, ",")

            BunifuProgressBar1.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar2.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar3.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar4.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar5.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar6.Maximum_Value = DG1.CurrentRow.Cells(8).Value
            BunifuProgressBar7.Maximum_Value = DG1.CurrentRow.Cells(8).Value

            BunifuProgressBar1.Value = CInt(d(0))
            BunifuProgressBar2.Value = CInt(d(1))
            BunifuProgressBar3.Value = CInt(d(2))
            BunifuProgressBar4.Value = CInt(d(3))
            BunifuProgressBar5.Value = CInt(d(4))
            BunifuProgressBar6.Value = CInt(d(5))
            BunifuProgressBar7.Value = CInt(d(6))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim x, y As Long
            Dim p1 As New Point(5, 100)
            Dim p2 As New Point(780, 100)
            Dim cute As Pen = New Pen(Color.FromArgb(255, 0, 0, 0), 2)
            e.Graphics.DrawLine(cute, p1, p2)

            y = 15
            x = 315
            Dim font As New Font("Arial", 30, FontStyle.Bold)
            e.Graphics.DrawString("Jain College", font, Brushes.Black, x, y)

            e.Graphics.DrawImage(PictureBox1.Image, 235, 10)

            y = 65
            x = 315
            Dim font1 As New Font("Arial", 9, FontStyle.Bold)
            e.Graphics.DrawString("#463/465, 18th Main, SS Royal, 80 Feet Road, ", font1, Brushes.Black, x, y)
            e.Graphics.DrawString(" Rajarajeshwari Nagar, Bangalore - 560 098", font1, Brushes.Black, 325, 80)

            Dim font2 As New Font("Arial", 20, FontStyle.Bold)
            e.Graphics.DrawString("Chart Showing Faculty Evaluation", font2, Brushes.Black, 180, 120)


            Chart1.ChartAreas(0).AxisY.Title = ""
            Chart1.ChartAreas(0).AxisX.Title = ""
            Chart1.Titles.Clear()

            Dim bm As New Bitmap(Chart1.Width, Chart1.Height) '' chart
            Dim rec As New Rectangle(0, 0, Chart1.Width, Chart1.Height)
            Chart1.DrawToBitmap(bm, rec)
            Clipboard.SetImage(bm)
            PictureBox2.Image = bm
            e.Graphics.DrawImage(PictureBox2.Image, 60, 155)
            bm.Dispose()

            Chart1.ChartAreas(0).AxisY.Title = "Ratings"
            Chart1.ChartAreas(0).AxisX.Title = "Questions"
            Chart1.Titles.Add(babe)

            Dim font3 As New Font("Arial", 12, FontStyle.Bold)
            e.Graphics.DrawString("Faculty Name : ", font3, Brushes.Black, 30, 500)
            e.Graphics.DrawString(DG1.CurrentRow.Cells(1).Value, font3, Brushes.Black, 150, 500) ''Name
            e.Graphics.DrawString("Faculty Code :", font3, Brushes.Black, 490, 500)
            e.Graphics.DrawString(DG1.CurrentRow.Cells(0).Value, font3, Brushes.Black, 610, 500) ''Code
            e.Graphics.DrawString("Subject      ", font3, Brushes.Black, 30, 560)
            e.Graphics.DrawString(": " + DG1.CurrentRow.Cells(2).Value, font3, Brushes.Black, 145, 560) ''subject
            e.Graphics.DrawString("Evaluation Period", font3, Brushes.Black, 450, 530)
            e.Graphics.DrawString(": " + DG1.CurrentRow.Cells(3).Value, font3, Brushes.Black, 600, 530) ''eval period
            e.Graphics.DrawString("Class      ", font3, Brushes.Black, 30, 530)
            Dim str As String = ""
            If DG1.CurrentRow.Cells(21).Value.ToString = "-" Then
                str = ""
            Else
                str = "'" & DG1.CurrentRow.Cells(21).Value.ToString & "'"
            End If
            e.Graphics.DrawString(": " + DG1.CurrentRow.Cells(4).Value + " " + DG1.CurrentRow.Cells(5).Value + " " + str, font3, Brushes.Black, 145, 530) ''class

            Dim xs As Integer = 30
            For i = 1 To 10
                e.Graphics.DrawRectangle(cute, 30, 600, xs, 35)
                e.Graphics.DrawRectangle(cute, 30, 600, xs, 80)
                xs += 40
            Next
            e.Graphics.DrawRectangle(cute, 420, 600, 255, 35)
            e.Graphics.DrawRectangle(cute, 420, 600, 100, 80) ''box next to total
            e.Graphics.DrawRectangle(cute, 420, 600, 255, 80)
            Dim c As String = "Q1"
            Dim pk As Integer = 32
            For i = 1 To 10
                e.Graphics.DrawString(c, font3, Brushes.Black, pk, 610)
                c = c.Substring(1) + 1
                c = "Q" & c
                pk += 39
            Next
            e.Graphics.DrawString("Total Class", font3, Brushes.Black, pk, 600)
            e.Graphics.DrawString("Strength", font3, Brushes.Black, pk + 5, 615)

            e.Graphics.DrawString("No. of students", font3, Brushes.Black, pk + 120, 600)
            e.Graphics.DrawString("present", font3, Brushes.Black, pk + 140, 615)

            Dim va As Integer = 38
            For i = 1 To 10
                e.Graphics.DrawString(DG1.CurrentRow.Cells(10 + i).Value, font3, Brushes.Black, va, 650)
                va += 39
            Next

            e.Graphics.DrawString(DG1.CurrentRow.Cells(7).Value, font3, Brushes.Black, va + 20, 650)
            e.Graphics.DrawString(DG1.CurrentRow.Cells(8).Value, font3, Brushes.Black, va + 150, 650)


            Dim numChars As Integer
            Dim numLines As Integer
            Dim stringForPage As String
            Dim strFormat As New StringFormat()
            Dim PrintFont As Font
            PrintFont = TextBox1.Font


            e.Graphics.DrawString("REMARKS      :", font3, Brushes.Black, 30, 700)
            Dim rectDraw As New RectangleF(45, 730, e.MarginBounds.Width, e.MarginBounds.Height)
            Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))
            strFormat.Trimming = StringTrimming.Word
            e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)
            stringForPage = StringToPrint.Substring(0, numChars)
            Dim font4 As New Font("Microsoft Sans Serif", 12, FontStyle.Italic)
            e.Graphics.DrawString("'" + stringForPage + "'", font4, Brushes.Black, rectDraw, strFormat)


            Dim p11 As New Point(5, 865)
            Dim p22 As New Point(780, 865)
            e.Graphics.DrawLine(cute, p11, p22)
            Dim font5 As New Font("Microsoft Sans Serif", 9.5)
            e.Graphics.DrawString("Q1) Does the faculty explain the concepts very clearly and" + vbNewLine + "       covers all the topics as per the syllabus?", font5, Brushes.Black, 10, 875)
            e.Graphics.DrawString("Q7) Does the faculty able to control the class well and deals" + vbNewLine + "        with the students maturely and professionally?", font5, Brushes.Black, 410, 875)

            e.Graphics.DrawString("Q2) Does the faculty able to relate the concepts to both theory" + vbNewLine + "       and practical aspects?", font5, Brushes.Black, 10, 910)
            e.Graphics.DrawString("Q8) Does the faculty effectively uses the black board / charts /" + vbNewLine + "       OHP / PPT / Demo and notes for better communication?", font5, Brushes.Black, 410, 925)

            e.Graphics.DrawString("Q3) Does the faculty encourage students participation in the" + vbNewLine + "       class and build interest in the subject?", font5, Brushes.Black, 10, 945)
            e.Graphics.DrawString("Q9) Does the faculty help the students from the examination" + vbNewLine + "       point of view (Question paper, relevant material etc.)", font5, Brushes.Black, 410, 960)

            e.Graphics.DrawString("Q4) Does the faculty maintain punctuality and engage the" + vbNewLine + "       entire hour productively?", font5, Brushes.Black, 10, 980)
            e.Graphics.DrawString("Q10) The overall rating of the faculty is", font5, Brushes.Black, 410, 1010)

            e.Graphics.DrawString("Q5) Does the faculty address subject related queries / doubts" + vbNewLine + "       and provide convincing solutions?", font5, Brushes.Black, 10, 1015)

            e.Graphics.DrawString("Q6) Does the assignments / worked-out problems / case studies /" + vbNewLine + "       presentation provided in each of the concepts help students to develop" + vbNewLine + "       practical knowledge?", font5, Brushes.Black, 10, 1050)

            Dim p111 As New Point(190, 1100)
            Dim p222 As New Point(580, 1100)
            e.Graphics.DrawLine(Pens.Black, p111, p222)
            Dim font6 As New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            Dim font7 As New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            e.Graphics.DrawString("Software Solutions by Azlan Soft Works", font6, Brushes.Black, 260, 1110)
            e.Graphics.DrawImage(PictureBox3.Image, 650, 1068)
            e.Graphics.DrawString("Report generated using ♥iguess", font7, Brushes.Black, 10, 1110)
            Dim bpen As Pen = New Pen(Color.FromArgb(255, 0, 0, 0), 5) ''border
            e.Graphics.DrawRectangle(bpen, 5, 5, 775, 1126) ''border

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            PrintDialog1.Document = PrintDocument1
            StringToPrint = TextBox1.Text

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd1 As New OleDbCommand("update FacultyReport set Pri_Remarks='" & TextBox1.Text & "' where Fac_Code='" & DG1.CurrentRow.Cells(0).Value & "' and sub='" & DG1.CurrentRow.Cells(2).Value & "' and Eval_date='" & DG1.CurrentRow.Cells(3).Value & "' and Course='" & DG1.CurrentRow.Cells(4).Value & "' and Stream='" & DG1.CurrentRow.Cells(5).Value & "'", conn)
            Try
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            If PrintDialog1.ShowDialog = DialogResult.OK Then
                PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
                Dim new_paper As New PaperSize("", 500, 500)
                new_paper.PaperName = PaperKind.Custom

                Dim new_margin As New Printing.Margins
                new_margin.Left = 0
                new_margin.Top = 50

                With PrintDocument1
                    .DefaultPageSettings.PaperSize = new_paper
                    .DefaultPageSettings.Margins = new_margin
                    .PrinterSettings.DefaultPageSettings.Landscape = False
                    .Print()
                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DG1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellContentClick
        DG1.ReadOnly = True
    End Sub

    Private Sub BunifuImageButton1_MouseEnter(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseEnter
        ttp.Show("Print", BunifuImageButton1)
    End Sub

    Private Sub BunifuImageButton1_MouseLeave(sender As Object, e As EventArgs) Handles BunifuImageButton1.MouseLeave
        ttp.Hide(BunifuImageButton1)
    End Sub
End Class
