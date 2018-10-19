Imports System.Data.OleDb
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

            ''If ComboBox2.Text <> "" Then
            ComboBox1.Items.Clear()
            Dim cmd As New OleDbCommand("Select distinct Dept_Name From FacultyReport", conn)


            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read
                ComboBox1.Items.Add(reader.GetValue(0).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''End If
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
        '' MsgBox(DG1.RowCount)
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            For hari = osthe To DG1.RowCount - 1
                Dim x, y As Long
                Dim p1 As New Point(5, 100)
                Dim p2 As New Point(780, 100)
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


                e.Graphics.DrawLine(Pens.Black, p1, p2)

                y = 15
                x = 315
                Dim font As New Font("Arial", 30, FontStyle.Bold)
                e.Graphics.DrawString("Jain College", font, Brushes.Black, x, y)

                e.Graphics.DrawImage(PictureBox1.Image, 235, 10) ''logo

                y = 65
                x = 315
                Dim font1 As New Font("Arial", 9, FontStyle.Bold)
                e.Graphics.DrawString("#463/465, 18th Main, SS Royal,80 Feet Road,", font1, Brushes.Black, x, y)
                e.Graphics.DrawString(" Rajarajeshwari Nagar, Bangalore - 560 098", font1, Brushes.Black, 325, 80)

                Dim font2 As New Font("Arial", 20, FontStyle.Bold)
                e.Graphics.DrawString("Chart Showing Faculty Evaluation", font2, Brushes.Black, 180, 120)

                Chart1.ChartAreas(0).AxisY.Title = ""
                Chart1.ChartAreas(0).AxisX.Title = ""
                Chart1.Titles.Clear()

                Dim bm As New Bitmap(Chart1.Width, Chart1.Height)
                Dim rec As New Rectangle(0, 0, Chart1.Width, Chart1.Height)
                Chart1.DrawToBitmap(bm, rec)
                Clipboard.SetImage(bm)
                PictureBox2.Image = bm
                e.Graphics.DrawImage(PictureBox2.Image, 60, 155)
                '' e.Graphics.DrawImage()
                bm.Dispose()

                Chart1.ChartAreas(0).AxisY.Title = "Ratings"
                Chart1.ChartAreas(0).AxisX.Title = "Questions"
                Chart1.Titles.Add(babe)

                Dim font3 As New Font("Arial", 12, FontStyle.Bold)
                e.Graphics.DrawString("Faculty Name :", font3, Brushes.Black, 30, 500)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(1).Value, font3, Brushes.Black, 150, 500) ''Name
                e.Graphics.DrawString("Faculty Code :", font3, Brushes.Black, 520, 500)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(0).Value, font3, Brushes.Black, 640, 500) ''Code
                e.Graphics.DrawString("Subject      ", font3, Brushes.Black, 30, 560)
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(2).Value, font3, Brushes.Black, 145, 560) ''subject
                e.Graphics.DrawString("Evaluation Period", font3, Brushes.Black, 450, 530)
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(3).Value, font3, Brushes.Black, 600, 530) ''eval period
                Dim str As String = ""
                If DG1.Rows(hari).Cells(23).Value.ToString = "-" Then
                    str = ""
                Else
                    str = "'" & DG1.Rows(hari).Cells(23).Value.ToString & "'"
                End If
                e.Graphics.DrawString("Class      ", font3, Brushes.Black, 30, 530)
                e.Graphics.DrawString(": " + DG1.Rows(hari).Cells(4).Value + " " + DG1.Rows(hari).Cells(5).Value + " " + str, font3, Brushes.Black, 145, 530) ''class
                ''x,y,xt,yt
                ''e.Graphics.DrawRectangle(Pens.Black, 40, 600, 750, 80)


                Dim xs As Integer = 30
                For i = 1 To 12
                    e.Graphics.DrawRectangle(cute, 30, 600, xs, 35)
                    e.Graphics.DrawRectangle(cute, 30, 600, xs, 80)
                    xs += 40
                Next
                e.Graphics.DrawRectangle(cute, 500, 600, 255, 35)
                e.Graphics.DrawRectangle(cute, 500, 600, 100, 80)
                e.Graphics.DrawRectangle(cute, 500, 600, 255, 80)
                Dim c As String = "Q1"
                Dim pk As Integer = 32
                For i = 1 To 12
                    e.Graphics.DrawString(c, font3, Brushes.Black, pk, 610)
                    c = c.Substring(1) + 1
                    c = "Q" & c
                    pk += 39
                Next
                e.Graphics.DrawString("Total Class", font3, Brushes.Black, pk, 600)
                e.Graphics.DrawString("Strength", font3, Brushes.Black, pk + 5, 615)

                e.Graphics.DrawString("No. Of students", font3, Brushes.Black, pk + 120, 600)
                e.Graphics.DrawString("present", font3, Brushes.Black, pk + 140, 615)

                Dim va As Integer = 38
                For i = 1 To 12
                    e.Graphics.DrawString(DG1.Rows(0).Cells(10 + i).Value, font3, Brushes.Black, va, 650)
                    va += 39
                Next

                e.Graphics.DrawString(DG1.Rows(hari).Cells(7).Value, font3, Brushes.Black, va + 20, 650)
                e.Graphics.DrawString(DG1.Rows(hari).Cells(8).Value, font3, Brushes.Black, va + 150, 650)

                StringToPrint = DG1.Rows(hari).Cells(10).Value.ToString

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
                e.Graphics.DrawLine(Pens.Black, p11, p22)
                Dim font5 As New Font("Microsoft Sans Serif", 9.5)
                e.Graphics.DrawString("1)Faculty explains the concepts very clearly and speaks fluently on" + vbNewLine + "    the subject.", font5, Brushes.Black, 10, 875)
                e.Graphics.DrawString("7)The assignments and workout problems provided in each" + vbNewLine + "     of the concepts help a student to do their studies on" + vbNewLine + "     day-to-day basis.", font5, Brushes.Black, 422, 875)

                e.Graphics.DrawString("2)Faculty uses of instructional aids like charts, presentation visuals," + vbNewLine + "    etc, are exceptionally good and creative.", font5, Brushes.Black, 10, 910)
                e.Graphics.DrawString("8)Teaching the concepts of study and the objective of the" + vbNewLine + "    course are well turned to the needs of the student.", font5, Brushes.Black, 422, 925)

                e.Graphics.DrawString("3)The faculty has updated knowledge on the subject and hence" + vbNewLine + "    could co-relate the concepts with current trends in the field.", font5, Brushes.Black, 10, 945)
                e.Graphics.DrawString("9)Faculty's listening skills enables every student to approach" + vbNewLine + "    and ensure the student confidence level in understanding" + vbNewLine + "    the concepts.", font5, Brushes.Black, 422, 960)

                e.Graphics.DrawString("4)Faculty has eagerness to learn updating knowledge enables them" + vbNewLine + "    to impart better understanding level on the subject to every student.", font5, Brushes.Black, 10, 980)
                e.Graphics.DrawString("10)Faculty is able to control the class well and deals with" + vbNewLine + "      the student maturity and professionally.", font5, Brushes.Black, 422, 1010)

                e.Graphics.DrawString("5)Every minute details of the concepts are being discussed" + vbNewLine + "    which enables the students to practice for consecutive classes.", font5, Brushes.Black, 10, 1015)
                e.Graphics.DrawString("11)Faculty is very punctual and maintains class decorum.", font5, Brushes.Black, 422, 1045)

                e.Graphics.DrawString("6)Query from students are well received, appreciated and" + vbNewLine + "    convinving solutions are provided within the class hour without fail.", font5, Brushes.Black, 10, 1050)
                e.Graphics.DrawString("12)The overall rating of the faculty.", font5, Brushes.Black, 422, 1065)

                Dim p111 As New Point(190, 1100)
                Dim p222 As New Point(580, 1100)
                e.Graphics.DrawLine(Pens.Black, p111, p222)
                Dim font6 As New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                e.Graphics.DrawString("Software Solutions by Azlan Soft Works", font6, Brushes.Black, 260, 1110)
                e.Graphics.DrawString("♥iguess", font6, Brushes.Black, 10, 1110)
                e.Graphics.DrawImage(PictureBox3.Image, 650, 1068)
                Dim bpen As Pen = New Pen(Color.FromArgb(255, 0, 0, 0), 5) ''border
                e.Graphics.DrawRectangle(bpen, 5, 5, 775, 1126) ''border
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
                .AxisX.Maximum = 13
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
            Dim cmd As New OleDbCommand("select Fac_Name,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12 from FacultyReport where Fac_Code='" & charval & "' and sub='" & charsub & "' and Eval_date='" & charevaldate & "' and Course='" & charcourse & "' and Stream='" & charsem & "' and Dept_Name='" & chardept & "' and no_of_present=" & charnum & "", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            dr.Read()
            '' Dim av As Double = (((Val(dr("q1").ToString) + Val(dr("q2").ToString) + Val(dr("q3").ToString) + Val(dr("q4").ToString) + Val(dr("q5").ToString) + Val(dr("q6").ToString) + Val(dr("q7").ToString) + Val(dr("q8").ToString) + Val(dr("q9").ToString) + Val(dr("q10").ToString) + Val(dr("q11").ToString) + Val(dr("q12").ToString)) * 12) / 84)

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
                .Points.Add(dr("q11").ToString).Label = dr("q11").ToString
                .Points.Add(dr("q12").ToString).Label = dr("q12").ToString

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
                .Points(10).AxisLabel = "Q11"
                .Points(11).AxisLabel = "Q12"

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
                .Points(10).Color = Color.Violet
                .Points(11).Color = Color.MediumSlateBlue
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
            ''MsgBox("remarks Updated")
            list()

            ''cmd1.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuImageButton1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter, BunifuImageButton1.MouseEnter
        Try
            Select Case sender.Name.ToString
                Case "BunifuImageButton1"
                    ttp.Show("Save the principal's Comment", BunifuImageButton1)
                Case "Button1"
                    ttp.Show("Print All", Button1)
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
