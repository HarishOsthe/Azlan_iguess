Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class evaluation

    Dim DS1 As New DataSet
    Dim hr As Integer = -1
    Dim har, har1, har2, har3, har4, har5, har6, har7, har8, har9, har10, har11, har12 As String
    Dim ttp As New ToolTip

    Sub fac_names_load()
        Try
            ComboBox2.Items.Clear()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("Select Fac_Name from FacultyDB where Dept_Name='" & ComboBox1.Text & "'", conn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read
                ComboBox2.Items.Add(reader.GetValue(0).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub dept_names_load()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As New OleDbCommand("Select * from Department", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read
                ComboBox1.Items.Add(reader.GetValue(0).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub but(ByVal s As Boolean)
        h1.Value = s
        h2.Value = s
        h3.Value = s
        h4.Value = s
        h5.Value = s
        h6.Value = s
        h7.Value = s

        a1.Value = s
        a2.Value = s
        a3.Value = s
        a4.Value = s
        a5.Value = s
        a6.Value = s
        a7.Value = s

        r1.Value = s
        r2.Value = s
        r3.Value = s
        r4.Value = s
        r5.Value = s
        r6.Value = s
        r7.Value = s

        s1.Value = s
        s2.Value = s
        s3.Value = s
        s4.Value = s
        s5.Value = s
        s6.Value = s
        s7.Value = s

        hh1.Value = s
        hh2.Value = s
        hh3.Value = s
        hh4.Value = s
        hh5.Value = s
        hh6.Value = s
        hh7.Value = s
        i1.Value = s
        i2.Value = s
        i3.Value = s
        i4.Value = s
        i5.Value = s
        i6.Value = s
        i7.Value = s

        n1.Value = s
        n2.Value = s
        n3.Value = s
        n4.Value = s
        n5.Value = s
        n6.Value = s
        n7.Value = s
        ii1.Value = s
        ii2.Value = s
        ii3.Value = s
        ii4.Value = s
        ii5.Value = s
        ii6.Value = s
        ii7.Value = s

        l1.Value = s
        l2.Value = s
        l3.Value = s
        l4.Value = s
        l5.Value = s
        l6.Value = s
        l7.Value = s

        o1.Value = s
        o2.Value = s
        o3.Value = s
        o4.Value = s
        o5.Value = s
        o6.Value = s
        o7.Value = s
        v1.Value = s
        v2.Value = s
        v3.Value = s
        v4.Value = s
        v5.Value = s
        v6.Value = s
        v7.Value = s

        e1.Value = s
        e2.Value = s
        e3.Value = s
        e4.Value = s
        e5.Value = s
        e6.Value = s
        e7.Value = s
    End Sub
    Sub clear_data2(ByVal s As Boolean)

        ComboBox1.Enabled = s
        ComboBox2.Enabled = s
        ComboBox3.Enabled = s
        ComboBox4.Enabled = s
        TextBox1.Enabled = s
        TextBox2.Enabled = s
        TextBox3.Enabled = s
        sectxt.Enabled = s
        DateTimePicker1.Enabled = s
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Button1.Enabled = s
        Button2.Enabled = s

        but(s)
    End Sub
    Sub clear_data(ByVal s As Boolean)
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = 1
        TextBox1.Enabled = False
        If Label23.Text = "Add Faculty" Then
            Label23.Text = "New Faculty"
        Else
            Label23.Text = "New Faculty"
        End If
        TextBox2.Enabled = s
        TextBox3.Enabled = s
        sectxt.Enabled = s
        ComboBox1.Enabled = s
        ComboBox2.Enabled = s
        ComboBox3.Enabled = s
        ComboBox4.Enabled = s
        DateTimePicker1.Enabled = s
        TextBox3.Text = ""
        TextBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        sectxt.Text = ""
        DateTimePicker1.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        Button1.Enabled = s
        Button2.Enabled = s
        Button6.Enabled = s
        Button5.Enabled = s
        Button4.Enabled = s
        Button7.Enabled = s


        BunifuCards24.Enabled = s
        BunifuCards23.Enabled = s
        BunifuCards22.Enabled = s
        BunifuCards21.Enabled = s
        BunifuCards20.Enabled = s
        BunifuCards19.Enabled = s
        BunifuCards18.Enabled = s
        BunifuCards17.Enabled = s
        BunifuCards16.Enabled = s
        BunifuCards15.Enabled = s
        BunifuCards14.Enabled = s
        BunifuCards13.Enabled = s
    End Sub

    Sub record1_check()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("select Std_no from Record order by Std_no", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            While dr.Read()
                Label22.Text = dr(0).ToString + 1 ''number
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub record_check()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As New OleDbCommand("select * from Record", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            dr.Read()
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
            '' dr(2).ToString
            ComboBox2.Text = dr(2).ToString ''fac name
            TextBox3.Text = dr(8).ToString
            TextBox1.Text = dr(1).ToString ''fac code
            sectxt.Text = dr(21).ToString
            TextBox2.Text = dr(3).ToString '' sub
            DateTimePicker1.Value = dr(4).ToString '' date
            ComboBox3.Text = dr(5).ToString '' course
            ComboBox4.Text = dr(6).ToString '' stream
            ComboBox1.Text = dr(7).ToString '' det name

            ''sectxt.Text = dr(21).ToString
            clear_data2(False)
            dr.Close()

            record1_check()
            facsub()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub facsub()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            DS1 = New DataSet
            Dim cmd As New OleDbDataAdapter("Select * From Record order by Std_no", conn)
            cmd.Fill(DS1)

            DG1.DataSource = DS1.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Function calculate(ByVal col As String) As Double
        Try
            Dim rows As Integer = DG1.RowCount
            Dim stdno As Integer = DG1.Rows(rows - 2).Cells(0).Value
            Dim avg As Double

            Dim h1, h2, h3, h4, h5, h6, h7 As Integer

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("select " & col & " from Record", conn) ''avg(" & col & ")

            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read()

                Select Case dr.GetValue(0).ToString
                    Case 1
                        h1 += 1
                    Case 2
                        ''MsgBox("hey 2")
                        h2 += 1
                    Case 3
                        ''MsgBox("hey 3")
                        h3 += 1
                    Case 4
                        ''MsgBox("hey 4")
                        h4 += 1
                    Case 5
                        ''MsgBox("hey 5")
                        h5 += 1
                    Case 6
                        ''MsgBox("hey 6")
                        h6 += 1
                    Case 7
                        ''MsgBox("hey 7")
                        h7 += 1
                End Select
            End While

            avg = ((h1 * 1) + (h2 * 2) + (h3 * 3) + (h4 * 4) + (h5 * 5) + (h6 * 6) + (h7 * 7)) / stdno '' Val(Label22.Text)

            Select Case col
                Case "q12"
                    har12 = ""
                    har12 = h1 & "," & h2 & "," & h3 & "," & h4 & "," & h5 & "," & h6 & "," & h7
            End Select


            '' MsgBox(har)
            ''MsgBox(avg)
            Return avg
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Function

    Private Sub evaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            dept_names_load()
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Dim cmd As New OleDbCommand("select * from Record", conn)


            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                record_check()
            End If

            Label109.Text = "Faculty explains the concepts very clearly and speaks fluently on" + vbNewLine + "the subject."
            Label110.Text = "Faculty uses of instructional aids like charts, presentation visuals," + vbNewLine + "etc, are exceptionally good and creative."
            Label111.Text = "The faculty has updated knowledge on the subject and hence" + vbNewLine + "could co-relate the concepts with current trends in the field."
            Label112.Text = "Faculty has eagerness to learn updating knowledge enables" + vbNewLine + "them to impart better understanding level on the subject to every student."
            Label113.Text = "Every minute details of the concepts are being discussed" + vbNewLine + "which enables the students to practice for consecutive classes."
            Label114.Text = "Query from students are well received, appreciated and" + vbNewLine + "convinving solutions are provided within the class hour without fail."
            Label115.Text = "The assignments and workout problems provided in each of" + vbNewLine + "the concepts help a student to do their studies on day-to-day basis."
            Label116.Text = "Teaching the concepts of study and the objective of the" + vbNewLine + "course are well turned to the needs of the student."
            Label117.Text = "Faculty's listening skills enables every student to approach" + vbNewLine + "and ensure the student confidence level in understanding the concepts."
            Label118.Text = "Faculty is able to control the class well and deals with the" + vbNewLine + "student maturity and professionally."
            Label119.Text = "Faculty is very punctual and maintains class decorum."
            Label120.Text = "The overall rating of the faculty."

            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "MMMM yyyy"
            Label8.Text = DateTimePicker1.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Label23.Text = "New Faculty" Then
                TextBox1.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox2.DropDownStyle = ComboBoxStyle.DropDown
                TextBox1.Enabled = True
                ComboBox1.Enabled = True
                ComboBox2.Enabled = True
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                sectxt.Enabled = False
                ComboBox3.Enabled = False
                ComboBox4.Enabled = False
                DateTimePicker1.Enabled = False
                Button2.Enabled = False
                Button6.Enabled = False
                Button5.Enabled = False
                Button4.Enabled = False
                Button7.Enabled = False

                BunifuCards24.Enabled = False
                BunifuCards23.Enabled = False
                BunifuCards22.Enabled = False
                BunifuCards21.Enabled = False
                BunifuCards20.Enabled = False
                BunifuCards19.Enabled = False
                BunifuCards18.Enabled = False
                BunifuCards17.Enabled = False
                BunifuCards16.Enabled = False
                BunifuCards15.Enabled = False
                BunifuCards14.Enabled = False
                BunifuCards13.Enabled = False

                Label23.Text = "ADD Faculty*"
            End If


            If Label23.Text = "ADD Faculty*" And TextBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox1.Text <> "" Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()

                Dim cmd As New OleDbCommand("insert into FacultyDB(Fac_Code, Fac_Name, Dept_Name) values(?,?,?)", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("Fac_Code", TextBox1.Text)
                cmd.Parameters.AddWithValue("Fac_Name", ComboBox2.Text)
                cmd.Parameters.AddWithValue("Dept_Name", ComboBox1.Text)

                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("New* Faculty " + ComboBox2.Text + "'s details added successfully!", MsgBoxStyle.Information)
                    cmd.Dispose()
                    conn.Close()
                    ComboBox2.Text = ""
                    TextBox1.Text = ""
                    Label23.Text = "New Faculty"
                    TextBox1.Enabled = False
                    Button2.Enabled = True
                    Button6.Enabled = True
                    Button5.Enabled = True
                    Button4.Enabled = True
                    Button7.Enabled = True
                    TextBox2.Enabled = True
                    sectxt.Enabled = True
                    ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
                    ComboBox3.Enabled = True
                    ComboBox4.Enabled = True
                    DateTimePicker1.Enabled = True
                    TextBox3.Enabled = True

                    BunifuCards24.Enabled = True
                    BunifuCards23.Enabled = True
                    BunifuCards22.Enabled = True
                    BunifuCards21.Enabled = True
                    BunifuCards20.Enabled = True
                    BunifuCards19.Enabled = True
                    BunifuCards18.Enabled = True
                    BunifuCards17.Enabled = True
                    BunifuCards16.Enabled = True
                    BunifuCards15.Enabled = True
                    BunifuCards14.Enabled = True
                    BunifuCards13.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ''Button3.Text = "ADD Faculty"
    End Sub ''checked

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim mg As Integer
            If TextBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox1.Text <> "" Then
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()

                Try
                    Dim cmd As New OleDbCommand("delete from FacultyDB where Fac_Code='" & TextBox1.Text & "'", conn)
                    cmd.ExecuteNonQuery()
                    mg = MsgBox("Are You Sure! you want to DELETE FeedBacks & Details of " + ComboBox2.Text + " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel)


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    If mg = DialogResult.OK Then
                        If conn.State = ConnectionState.Open Then conn.Close()
                        conn.Open()

                        Dim cmd1 As New OleDbCommand("delete from FacultyReport where Fac_Code='" & TextBox1.Text & "'", conn)
                        cmd1.ExecuteNonQuery()
                        ComboBox1.Text = ""
                        ComboBox2.Text = ""
                        TextBox1.Text = ""
                        MsgBox("Feedbacks & Details of " + ComboBox2.Text + " are been Removed* successfully! from the DataBase", MsgBoxStyle.Information)

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub '' checked

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If ComboBox1.Text <> "" And ComboBox2.Text <> "" And TextBox1.Text <> "" And TextBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "" And TextBox3.Text <> "" And Label8.Text <> "" And Label10.Text <> "" And Label11.Text <> "" And Label12.Text <> "" And Label13.Text <> "" And Label14.Text <> "" And Label15.Text <> "" And Label16.Text <> "" And Label17.Text <> "" And Label18.Text <> "" And Label19.Text <> "" And Label20.Text <> "" And Label21.Text <> "" Then
                If sectxt.Text = "" Then
                    sectxt.Text = "-"
                End If

                Try
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    Dim cmd1 As New OleDbCommand("Delete from Record Where Std_no=" & Val(Label22.Text) & "", conn)
                    cmd1.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                Dim cmd As New OleDbCommand("insert into Record(Std_no,Fac_Code,Fac_Name,sub,Eval_date,Course,Stream,Dept_Name,total_strength,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,Sec) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("Std_no", Label22.Text)
                cmd.Parameters.AddWithValue("Fac_Code", TextBox1.Text)
                cmd.Parameters.AddWithValue("Fac_Name", ComboBox2.Text)
                cmd.Parameters.AddWithValue("sub", TextBox2.Text)
                cmd.Parameters.AddWithValue("Eval_Date", Label8.Text)
                cmd.Parameters.AddWithValue("Course", ComboBox3.Text)
                cmd.Parameters.AddWithValue("Stream", ComboBox4.Text)
                cmd.Parameters.AddWithValue("Dept_Name", ComboBox1.Text)
                cmd.Parameters.AddWithValue("total_strength", TextBox3.Text)
                cmd.Parameters.AddWithValue("q1", Label10.Text)
                cmd.Parameters.AddWithValue("q2", Label11.Text)
                cmd.Parameters.AddWithValue("q3", Label12.Text)
                cmd.Parameters.AddWithValue("q4", Label13.Text)
                cmd.Parameters.AddWithValue("q5", Label14.Text)
                cmd.Parameters.AddWithValue("q6", Label15.Text)
                cmd.Parameters.AddWithValue("q7", Label16.Text)
                cmd.Parameters.AddWithValue("q8", Label17.Text)
                cmd.Parameters.AddWithValue("q9", Label18.Text)
                cmd.Parameters.AddWithValue("q10", Label19.Text)
                cmd.Parameters.AddWithValue("q11", Label20.Text)
                cmd.Parameters.AddWithValue("q12", Label21.Text)
                cmd.Parameters.AddWithValue("Sec", sectxt.Text)
                Try
                    cmd.ExecuteNonQuery()
                    clear_data2(False)
                    facsub()
                    Label22.Text = (DS1.Tables(0).Rows(DG1.RowCount - 2)("Std_no").ToString) + 1 ''Val(Label22.Text) + 1
                    cmd.Dispose()
                    conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Make sure you have filled* all Data", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        fac_names_load()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            TextBox1.Text = ""
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As New OleDbCommand("select Fac_Code from FacultyDB where Fac_Name='" & ComboBox2.Text & "' and Dept_Name='" & ComboBox1.Text & "'", conn)

            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            dr.Read()
            TextBox1.Text = dr.GetValue(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            ComboBox4.Items.Clear()
            If ComboBox3.Text = "PUC" Then
                ComboBox4.Items.Add("I ABMS")
                ComboBox4.Items.Add("I ABEM")
                ComboBox4.Items.Add("I ABES")
                ComboBox4.Items.Add("I PCMB")
                ComboBox4.Items.Add("I PCME")
                ComboBox4.Items.Add("I PCMC")

                ComboBox4.Items.Add("II ABMS")
                ComboBox4.Items.Add("II ABEM")
                ComboBox4.Items.Add("II ABES")
                ComboBox4.Items.Add("II PCMB")
                ComboBox4.Items.Add("II PCME")
                ComboBox4.Items.Add("II PCMC")
            Else
                ComboBox4.Items.Add("I SEM")
                ComboBox4.Items.Add("II SEM")
                ComboBox4.Items.Add("III SEM")
                ComboBox4.Items.Add("IV SEM")
                ComboBox4.Items.Add("V SEM")
                ComboBox4.Items.Add("VI SEM")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ''  If hr <> 0 Then
        ''   MsgBox(DG1.RowCount)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd11 As New OleDbCommand("select * from Record", conn)

            Dim d1 As OleDbDataReader = cmd11.ExecuteReader()

            If d1.HasRows Then
                '' If (DG1.RowCount <> 0) Then
                ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
                Dim stdno As Integer = DG1.RowCount - 1
                Dim q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12 As Double
                q1 = q2 = q3 = q4 = q5 = q6 = q7 = q8 = q9 = q10 = q11 = q12 = 0

                q1 = Math.Round(calculate("q1"))
                q2 = Math.Round(calculate("q2"))
                q3 = Math.Round(calculate("q3"))
                q4 = Math.Round(calculate("q4"))
                q5 = Math.Round(calculate("q5"))
                q6 = Math.Round(calculate("q6"))
                q7 = Math.Round(calculate("q7"))
                q8 = Math.Round(calculate("q8"))
                q9 = Math.Round(calculate("q9"))
                q10 = Math.Round(calculate("q10"))
                q11 = Math.Round(calculate("q11"))
                q12 = Math.Round(calculate("q12"))
                har = har12 ''har1 & har2 & har3 & har4 & har5 & har6 & har7 & har8 & har9 & har10 & har11 &
                ''MsgBox(har)

                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()

                Dim cmd As New OleDbCommand("insert into FacultyReport(Fac_Code,Fac_Name,sub,Eval_date,Course,Stream,Dept_Name,total_strength,no_of_present,Ratings,q1,q2,q3,q4,q5,q6,q7,q8,q9,q10,q11,q12,Sec) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("Fac_Code", DG1.Rows(0).Cells(1).Value)
                cmd.Parameters.AddWithValue("Fac_Name", DG1.Rows(0).Cells(2).Value)
                cmd.Parameters.AddWithValue("sub", DG1.Rows(0).Cells(3).Value)
                cmd.Parameters.AddWithValue("Eval_Date", DG1.Rows(0).Cells(4).Value)
                cmd.Parameters.AddWithValue("Course", DG1.Rows(0).Cells(5).Value)
                cmd.Parameters.AddWithValue("Stream", DG1.Rows(0).Cells(6).Value)
                cmd.Parameters.AddWithValue("Dept_Name", DG1.Rows(0).Cells(7).Value)
                cmd.Parameters.AddWithValue("total_strength", DG1.Rows(0).Cells(8).Value)
                cmd.Parameters.AddWithValue("no_of_present", stdno)
                cmd.Parameters.AddWithValue("Ratings", har)
                cmd.Parameters.AddWithValue("q1", q1)
                cmd.Parameters.AddWithValue("q2", q2)
                cmd.Parameters.AddWithValue("q3", q3)
                cmd.Parameters.AddWithValue("q4", q4)
                cmd.Parameters.AddWithValue("q5", q5)
                cmd.Parameters.AddWithValue("q6", q6)
                cmd.Parameters.AddWithValue("q7", q7)
                cmd.Parameters.AddWithValue("q8", q8)
                cmd.Parameters.AddWithValue("q9", q9)
                cmd.Parameters.AddWithValue("q10", q10)
                cmd.Parameters.AddWithValue("q11", q11)
                cmd.Parameters.AddWithValue("q12", q12)
                cmd.Parameters.AddWithValue("Sec", sectxt.Text)
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox(stdno.ToString + " Feedbacks of " + DG1.Rows(0).Cells(2).Value.ToString + " is stored* successfully!", MsgBoxStyle.Information)
                    cmd.Dispose()
                    conn.Close()


                    Try
                        If conn.State = ConnectionState.Open Then conn.Close()
                        conn.Open()
                        Dim cmd1 As New OleDbCommand("delete from Record", conn)
                        cmd1.ExecuteNonQuery()
                        facsub()
                        clear_data(True)
                        but(False)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Make sure you have filled* all Data", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        '' If (DG1.RowCount <> 0) Then
        Try
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As New OleDbCommand("delete from Record", conn)

            cmd.ExecuteNonQuery()
            facsub()
            clear_data(True)
            but(False)

            '' MsgBox("records deletd")
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
        ''End If
    End Sub
    Sub light_val(ByVal h As String, ByVal val As Integer)
        Try
            Select Case h
                Case "h"
                    h1.Value = False
                    h2.Value = False
                    h3.Value = False
                    h4.Value = False
                    h5.Value = False
                    h6.Value = False
                    h7.Value = False
                    Select Case val
                        Case 1
                            h1.Value = True
                        Case 2
                            h2.Value = True
                        Case 3
                            h3.Value = True
                        Case 4
                            h4.Value = True
                        Case 5
                            h5.Value = True
                        Case 6
                            h6.Value = True
                        Case 7
                            h7.Value = True
                    End Select
                Case "a"
                    a1.Value = False
                    a2.Value = False
                    a3.Value = False
                    a4.Value = False
                    a5.Value = False
                    a6.Value = False
                    a7.Value = False
                    Select Case val
                        Case 1
                            a1.Value = True
                        Case 2
                            a2.Value = True
                        Case 3
                            a3.Value = True
                        Case 4
                            a4.Value = True
                        Case 5
                            a5.Value = True
                        Case 6
                            a6.Value = True
                        Case 7
                            a7.Value = True
                    End Select
                Case "r"
                    r1.Value = False
                    r2.Value = False
                    r3.Value = False
                    r4.Value = False
                    r5.Value = False
                    r6.Value = False
                    r7.Value = False
                    Select Case val
                        Case 1
                            r1.Value = True
                        Case 2
                            r2.Value = True
                        Case 3
                            r3.Value = True
                        Case 4
                            r4.Value = True
                        Case 5
                            r5.Value = True
                        Case 6
                            r6.Value = True
                        Case 7
                            r7.Value = True
                    End Select
                Case "s"
                    s1.Value = False
                    s2.Value = False
                    s3.Value = False
                    s4.Value = False
                    s5.Value = False
                    s6.Value = False
                    s7.Value = False
                    Select Case val
                        Case 1
                            s1.Value = True
                        Case 2
                            s2.Value = True
                        Case 3
                            s3.Value = True
                        Case 4
                            s4.Value = True
                        Case 5
                            s5.Value = True
                        Case 6
                            s6.Value = True
                        Case 7
                            s7.Value = True
                    End Select
                Case "hh"
                    hh1.Value = False
                    hh2.Value = False
                    hh3.Value = False
                    hh4.Value = False
                    hh5.Value = False
                    hh6.Value = False
                    hh7.Value = False
                    Select Case val
                        Case 1
                            hh1.Value = True
                        Case 2
                            hh2.Value = True
                        Case 3
                            hh3.Value = True
                        Case 4
                            hh4.Value = True
                        Case 5
                            hh5.Value = True
                        Case 6
                            hh6.Value = True
                        Case 7
                            hh7.Value = True
                    End Select
                Case "i"
                    i1.Value = False
                    i2.Value = False
                    i3.Value = False
                    i4.Value = False
                    i5.Value = False
                    i6.Value = False
                    i7.Value = False
                    Select Case val
                        Case 1
                            i1.Value = True
                        Case 2
                            i2.Value = True
                        Case 3
                            i3.Value = True
                        Case 4
                            i4.Value = True
                        Case 5
                            i5.Value = True
                        Case 6
                            i6.Value = True
                        Case 7
                            i7.Value = True
                    End Select
                Case "n"
                    n1.Value = False
                    n2.Value = False
                    n3.Value = False
                    n4.Value = False
                    n5.Value = False
                    n6.Value = False
                    n7.Value = False
                    Select Case val
                        Case 1
                            n1.Value = True
                        Case 2
                            n2.Value = True
                        Case 3
                            n3.Value = True
                        Case 4
                            n4.Value = True
                        Case 5
                            n5.Value = True
                        Case 6
                            n6.Value = True
                        Case 7
                            n7.Value = True
                    End Select
                Case "ii"
                    ii1.Value = False
                    ii2.Value = False
                    ii3.Value = False
                    ii4.Value = False
                    ii5.Value = False
                    ii6.Value = False
                    ii7.Value = False
                    Select Case val
                        Case 1
                            ii1.Value = True
                        Case 2
                            ii2.Value = True
                        Case 3
                            ii3.Value = True
                        Case 4
                            ii4.Value = True
                        Case 5
                            ii5.Value = True
                        Case 6
                            ii6.Value = True
                        Case 7
                            ii7.Value = True
                    End Select
                Case "l"
                    l1.Value = False
                    l2.Value = False
                    l3.Value = False
                    l4.Value = False
                    l5.Value = False
                    l6.Value = False
                    l7.Value = False
                    Select Case val
                        Case 1
                            l1.Value = True
                        Case 2
                            l2.Value = True
                        Case 3
                            l3.Value = True
                        Case 4
                            l4.Value = True
                        Case 5
                            l5.Value = True
                        Case 6
                            l6.Value = True
                        Case 7
                            l7.Value = True
                    End Select
                Case "o"
                    o1.Value = False
                    o2.Value = False
                    o3.Value = False
                    o4.Value = False
                    o5.Value = False
                    o6.Value = False
                    o7.Value = False
                    Select Case val
                        Case 1
                            o1.Value = True
                        Case 2
                            o2.Value = True
                        Case 3
                            o3.Value = True
                        Case 4
                            o4.Value = True
                        Case 5
                            o5.Value = True
                        Case 6
                            o6.Value = True
                        Case 7
                            o7.Value = True
                    End Select
                Case "v"
                    v1.Value = False
                    v2.Value = False
                    v3.Value = False
                    v4.Value = False
                    v5.Value = False
                    v6.Value = False
                    v7.Value = False
                    Select Case val
                        Case 1
                            v1.Value = True
                        Case 2
                            v2.Value = True
                        Case 3
                            v3.Value = True
                        Case 4
                            v4.Value = True
                        Case 5
                            v5.Value = True
                        Case 6
                            v6.Value = True
                        Case 7
                            v7.Value = True
                    End Select
                Case "e"
                    e1.Value = False
                    e2.Value = False
                    e3.Value = False
                    e4.Value = False
                    e5.Value = False
                    e6.Value = False
                    e7.Value = False
                    Select Case val
                        Case 1
                            e1.Value = True
                        Case 2
                            e2.Value = True
                        Case 3
                            e3.Value = True
                        Case 4
                            e4.Value = True
                        Case 5
                            e5.Value = True
                        Case 6
                            e6.Value = True
                        Case 7
                            e7.Value = True
                    End Select
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub sectxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sectxt.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            ''  If hr <> 0 Then
            ''MsgBox(DG1)
            '' MsgBox(hr)
            ''MsgBox(DS1.Tables(0).Rows.Count)

            If (DG1.RowCount <> 0) Then
                If (hr < DS1.Tables(0).Rows.Count) Then ''DS1.Tables(0).Rows.Count) Then
                    hr += 1
                    Label22.Text = DS1.Tables(0).Rows(hr)("Std_no").ToString()
                    Label10.Text = DS1.Tables(0).Rows(hr)("q1").ToString()
                    light_val("h", Val(Label10.Text))

                    Label11.Text = DS1.Tables(0).Rows(hr)("q2").ToString()
                    light_val("a", Val(Label11.Text))

                    Label12.Text = DS1.Tables(0).Rows(hr)("q3").ToString()
                    light_val("r", Val(Label12.Text))

                    Label13.Text = DS1.Tables(0).Rows(hr)("q4").ToString()
                    light_val("s", Val(Label13.Text))

                    Label14.Text = DS1.Tables(0).Rows(hr)("q5").ToString()
                    light_val("hh", Val(Label14.Text))

                    Label15.Text = DS1.Tables(0).Rows(hr)("q6").ToString()
                    light_val("i", Val(Label15.Text))

                    Label16.Text = DS1.Tables(0).Rows(hr)("q7").ToString()
                    light_val("n", Val(Label16.Text))

                    Label17.Text = DS1.Tables(0).Rows(hr)("q8").ToString()
                    light_val("ii", Val(Label17.Text))

                    Label18.Text = DS1.Tables(0).Rows(hr)("q9").ToString()
                    light_val("l", Val(Label18.Text))

                    Label19.Text = DS1.Tables(0).Rows(hr)("q10").ToString()
                    light_val("o", Val(Label19.Text))

                    Label20.Text = DS1.Tables(0).Rows(hr)("q11").ToString()
                    light_val("v", Val(Label20.Text))

                    Label21.Text = DS1.Tables(0).Rows(hr)("q12").ToString()
                    light_val("e", Val(Label21.Text))
                End If
            End If
        Catch ex As System.IndexOutOfRangeException
            Label22.Text = Val(Label22.Text) + 1
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""
            Label15.Text = ""
            Label16.Text = ""
            Label17.Text = ""
            Label18.Text = ""
            Label19.Text = ""
            Label20.Text = ""
            Label21.Text = ""
            but(False)
        End Try
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter, Button4.MouseEnter, Button3.MouseEnter, Button2.MouseEnter, Button1.MouseEnter, Button6.MouseEnter, Button7.MouseEnter, sectxt.MouseEnter, TextBox3.MouseEnter
        Try
            Select Case sender.name.ToString
                Case "Button5"
                    ttp.Show("Add", Button5)
                Case "Button1"
                    ttp.Show("Add New Faculty", Button1)
                Case "Button2"
                    ttp.Show("Delete This Faculty", Button2)
                Case "Button3"
                    ttp.Show("Clear", Button3)
                Case "Button4"
                    ttp.Show("Save", Button4)
                Case "Button6"
                    ttp.Show("Previous", Button6)
                Case "Button7"
                    ttp.Show("Next", Button7)
                Case "sectxt"
                    ttp.Show("Section", sectxt)
                Case "TextBox3"
                    ttp.Show("Total Strength", TextBox3)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try  ''MsgBox(sender.name.ToString)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If (hr = 0 Or hr = -1) Then
                hr = 1
            End If

            '' MsgBox(hr)
            ''MsgBox(DS1.Tables(0).Rows.Count)
            If (DG1.RowCount <> 0) Then
                If (hr <= DS1.Tables(0).Rows.Count) Then
                    hr -= 1
                    Label22.Text = DS1.Tables(0).Rows(hr)("Std_no").ToString()
                    Label10.Text = DS1.Tables(0).Rows(hr)("q1").ToString()
                    light_val("h", Val(Label10.Text))

                    Label11.Text = DS1.Tables(0).Rows(hr)("q2").ToString()
                    light_val("a", Val(Label11.Text))

                    Label12.Text = DS1.Tables(0).Rows(hr)("q3").ToString()
                    light_val("r", Val(Label12.Text))

                    Label13.Text = DS1.Tables(0).Rows(hr)("q4").ToString()
                    light_val("s", Val(Label13.Text))

                    Label14.Text = DS1.Tables(0).Rows(hr)("q5").ToString()
                    light_val("hh", Val(Label14.Text))

                    Label15.Text = DS1.Tables(0).Rows(hr)("q6").ToString()
                    light_val("i", Val(Label15.Text))

                    Label16.Text = DS1.Tables(0).Rows(hr)("q7").ToString()
                    light_val("n", Val(Label16.Text))

                    Label17.Text = DS1.Tables(0).Rows(hr)("q8").ToString()
                    light_val("ii", Val(Label17.Text))

                    Label18.Text = DS1.Tables(0).Rows(hr)("q9").ToString()
                    light_val("l", Val(Label18.Text))

                    Label19.Text = DS1.Tables(0).Rows(hr)("q10").ToString()
                    light_val("o", Val(Label19.Text))

                    Label20.Text = DS1.Tables(0).Rows(hr)("q11").ToString()
                    light_val("v", Val(Label20.Text))

                    Label21.Text = DS1.Tables(0).Rows(hr)("q12").ToString()
                    light_val("e", Val(Label21.Text))
                End If
            End If
            ''S  End If
        Catch ex As System.IndexOutOfRangeException
            Label22.Text = Val(Label22.Text) + 1
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""
            Label15.Text = ""
            Label16.Text = ""
            Label17.Text = ""
            Label18.Text = ""
            Label19.Text = ""
            Label20.Text = ""
            Label21.Text = ""
            but(False)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label8.Text = DateTimePicker1.Text
    End Sub
    Private Sub h7_MouseClick(sender As Object, e As MouseEventArgs) Handles h7.MouseClick, h6.MouseClick, h5.MouseClick, h4.MouseClick, h3.MouseClick, h2.MouseClick, h1.MouseClick, a7.MouseClick, a6.MouseClick, a5.MouseClick, a4.MouseClick, a3.MouseClick, a2.MouseClick, a1.MouseClick, r7.MouseClick, r6.MouseClick, r5.MouseClick, r4.MouseClick, r3.MouseClick, r2.MouseClick, r1.MouseClick, s7.MouseClick, s6.MouseClick, s5.MouseClick, s4.MouseClick, s3.MouseClick, s2.MouseClick, s1.MouseClick, hh7.MouseClick, hh6.MouseClick, hh5.MouseClick, hh4.MouseClick, hh3.MouseClick, hh2.MouseClick, hh1.MouseClick, i7.MouseClick, i6.MouseClick, i5.MouseClick, i4.MouseClick, i3.MouseClick, i2.MouseClick, i1.MouseClick, n7.MouseClick, n6.MouseClick, n5.MouseClick, n4.MouseClick, n3.MouseClick, n2.MouseClick, n1.MouseClick, ii7.MouseClick, ii6.MouseClick, ii5.MouseClick, ii4.MouseClick, ii3.MouseClick, ii2.MouseClick, ii1.MouseClick, l7.MouseClick, l6.MouseClick, l5.MouseClick, l4.MouseClick, l3.MouseClick, l2.MouseClick, l1.MouseClick, o7.MouseClick, o6.MouseClick, o5.MouseClick, o4.MouseClick, o3.MouseClick, o2.MouseClick, o1.MouseClick, v7.MouseClick, v6.MouseClick, v5.MouseClick, v4.MouseClick, v3.MouseClick, v2.MouseClick, v1.MouseClick, e7.MouseClick, e6.MouseClick, e5.MouseClick, e4.MouseClick, e3.MouseClick, e2.MouseClick, e1.MouseClick
        Try
            Dim str As String = sender.name.ToString
            Select Case str
                Case "h1", "h2", "h3", "h4", "h5", "h6", "h7"
                    h1.Value = False
                    h2.Value = False
                    h3.Value = False
                    h4.Value = False
                    h5.Value = False
                    h6.Value = False
                    h7.Value = False
                    sender.value = True
                    Label10.Text = sender.name.ToString.Substring(1)
                Case "a1", "a2", "a3", "a4", "a5", "a6", "a7"
                    a1.Value = False
                    a2.Value = False
                    a3.Value = False
                    a4.Value = False
                    a5.Value = False
                    a6.Value = False
                    a7.Value = False
                    sender.value = True
                    Label11.Text = sender.name.ToString.Substring(1)
                Case "r1", "r2", "r3", "r4", "r5", "r6", "r7"
                    r1.Value = False
                    r2.Value = False
                    r3.Value = False
                    r4.Value = False
                    r5.Value = False
                    r6.Value = False
                    r7.Value = False
                    sender.value = True
                    Label12.Text = sender.name.ToString.Substring(1)
                Case "s1", "s2", "s3", "s4", "s5", "s6", "s7"
                    s1.Value = False
                    s2.Value = False
                    s3.Value = False
                    s4.Value = False
                    s5.Value = False
                    s6.Value = False
                    s7.Value = False
                    sender.value = True
                    Label13.Text = sender.name.ToString.Substring(1)
                Case "hh1", "hh2", "hh3", "hh4", "hh5", "hh6", "hh7"
                    hh1.Value = False
                    hh2.Value = False
                    hh3.Value = False
                    hh4.Value = False
                    hh5.Value = False
                    hh6.Value = False
                    hh7.Value = False
                    sender.value = True
                    Label14.Text = sender.name.ToString.Substring(2)
                Case "i1", "i2", "i3", "i4", "i5", "i6", "i7"
                    i1.Value = False
                    i2.Value = False
                    i3.Value = False
                    i4.Value = False
                    i5.Value = False
                    i6.Value = False
                    i7.Value = False
                    sender.value = True
                    Label15.Text = sender.name.ToString.Substring(1)
                Case "n1", "n2", "n3", "n4", "n5", "n6", "n7"
                    n1.Value = False
                    n2.Value = False
                    n3.Value = False
                    n4.Value = False
                    n5.Value = False
                    n6.Value = False
                    n7.Value = False
                    sender.value = True
                    Label16.Text = sender.name.ToString.Substring(1)
                Case "ii1", "ii2", "ii3", "ii4", "ii5", "ii6", "ii7"
                    ii1.Value = False
                    ii2.Value = False
                    ii3.Value = False
                    ii4.Value = False
                    ii5.Value = False
                    ii6.Value = False
                    ii7.Value = False
                    sender.value = True
                    Label17.Text = sender.name.ToString.Substring(2)
                Case "l1", "l2", "l3", "l4", "l5", "l6", "l7"
                    l1.Value = False
                    l2.Value = False
                    l3.Value = False
                    l4.Value = False
                    l5.Value = False
                    l6.Value = False
                    l7.Value = False
                    sender.value = True
                    Label18.Text = sender.name.ToString.Substring(1)
                Case "o1", "o2", "o3", "o4", "o5", "o6", "o7"
                    o1.Value = False
                    o2.Value = False
                    o3.Value = False
                    o4.Value = False
                    o5.Value = False
                    o6.Value = False
                    o7.Value = False
                    sender.value = True
                    Label19.Text = sender.name.ToString.Substring(1)
                Case "v1", "v2", "v3", "v4", "v5", "v6", "v7"
                    v1.Value = False
                    v2.Value = False
                    v3.Value = False
                    v4.Value = False
                    v5.Value = False
                    v6.Value = False
                    v7.Value = False
                    sender.value = True
                    Label20.Text = sender.name.ToString.Substring(1)
                Case "e1", "e2", "e3", "e4", "e5", "e6", "e7"
                    e1.Value = False
                    e2.Value = False
                    e3.Value = False
                    e4.Value = False
                    e5.Value = False
                    e6.Value = False
                    e7.Value = False
                    sender.value = True
                    Label21.Text = sender.name.ToString.Substring(1)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuCards24_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCards24.MouseEnter, BunifuCards23.MouseEnter, BunifuCards22.MouseEnter, BunifuCards21.MouseEnter, BunifuCards20.MouseEnter, BunifuCards19.MouseEnter, BunifuCards18.MouseEnter, BunifuCards17.MouseEnter, BunifuCards16.MouseEnter, BunifuCards15.MouseEnter, BunifuCards14.MouseEnter, BunifuCards13.MouseEnter
        sender.BackColor = Color.Gainsboro
    End Sub
    Private Sub BunifuCards24_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCards24.MouseLeave, BunifuCards23.MouseLeave, BunifuCards22.MouseLeave, BunifuCards21.MouseLeave, BunifuCards20.MouseLeave, BunifuCards19.MouseLeave, BunifuCards18.MouseLeave, BunifuCards17.MouseLeave, BunifuCards16.MouseLeave, BunifuCards15.MouseLeave, BunifuCards14.MouseLeave, BunifuCards13.MouseLeave
        sender.BackColor = Color.White
    End Sub

    Private Sub h7_MouseEnter(sender As Object, e As EventArgs) Handles h7.MouseEnter, h6.MouseEnter, h5.MouseEnter, h4.MouseEnter, h3.MouseEnter, h2.MouseEnter, h1.MouseEnter, a7.MouseEnter, a6.MouseEnter, a5.MouseEnter, a4.MouseEnter, a3.MouseEnter, a2.MouseEnter, a1.MouseEnter, r7.MouseEnter, r6.MouseEnter, r5.MouseEnter, r4.MouseEnter, r3.MouseEnter, r2.MouseEnter, r1.MouseEnter, s7.MouseEnter, s6.MouseEnter, s5.MouseEnter, s4.MouseEnter, s3.MouseEnter, s2.MouseEnter, s1.MouseEnter, hh7.MouseEnter, hh6.MouseEnter, hh5.MouseEnter, hh4.MouseEnter, hh3.MouseEnter, hh2.MouseEnter, hh1.MouseEnter, i7.MouseEnter, i6.MouseEnter, i5.MouseEnter, i4.MouseEnter, i3.MouseEnter, i2.MouseEnter, i1.MouseEnter, n7.MouseEnter, n6.MouseEnter, n5.MouseEnter, n4.MouseEnter, n3.MouseEnter, n2.MouseEnter, n1.MouseEnter, ii7.MouseEnter, ii6.MouseEnter, ii5.MouseEnter, ii4.MouseEnter, ii3.MouseEnter, ii2.MouseEnter, ii1.MouseEnter, l7.MouseEnter, l6.MouseEnter, l5.MouseEnter, l4.MouseEnter, l3.MouseEnter, l2.MouseEnter, l1.MouseEnter, o7.MouseEnter, o6.MouseEnter, o5.MouseEnter, o4.MouseEnter, o3.MouseEnter, o2.MouseEnter, o1.MouseEnter, v7.MouseEnter, v6.MouseEnter, v5.MouseEnter, v4.MouseEnter, v3.MouseEnter, v2.MouseEnter, v1.MouseEnter, e7.MouseEnter, e6.MouseEnter, e5.MouseEnter, e4.MouseEnter, e3.MouseEnter, e2.MouseEnter, e1.MouseEnter, Label109.MouseEnter, Label110.MouseEnter, Label111.MouseEnter, Label112.MouseEnter, Label113.MouseEnter, Label114.MouseEnter, Label115.MouseEnter, Label116.MouseEnter, Label117.MouseEnter, Label118.MouseEnter, Label119.MouseEnter, Label120.MouseEnter
        Try
            Select Case sender.name.ToString
                Case "h1", "h2", "h3", "h4", "h5", "h6", "h7", "Label109"
                    BunifuCards24.BackColor = Color.Gainsboro
                Case "a1", "a2", "a3", "a4", "a5", "a6", "a7", "Label110"
                    BunifuCards23.BackColor = Color.Gainsboro
                Case "r1", "r2", "r3", "r4", "r5", "r6", "r7", "Label111"
                    BunifuCards22.BackColor = Color.Gainsboro
                Case "s1", "s2", "s3", "s4", "s5", "s6", "s7", "Label112"
                    BunifuCards21.BackColor = Color.Gainsboro
                Case "hh1", "hh2", "hh3", "hh4", "hh5", "hh6", "hh7", "Label113"
                    BunifuCards20.BackColor = Color.Gainsboro
                Case "i1", "i2", "i3", "i4", "i5", "i6", "i7", "Label114"
                    BunifuCards19.BackColor = Color.Gainsboro
                Case "n1", "n2", "n3", "n4", "n5", "n6", "n7", "Label115"
                    BunifuCards18.BackColor = Color.Gainsboro
                Case "ii1", "ii2", "ii3", "ii4", "ii5", "ii6", "ii7", "Label116"
                    BunifuCards17.BackColor = Color.Gainsboro
                Case "l1", "l2", "l3", "l4", "l5", "l6", "l7", "Label117"
                    BunifuCards16.BackColor = Color.Gainsboro
                Case "o1", "o2", "o3", "o4", "o5", "o6", "o7", "Label118"
                    BunifuCards15.BackColor = Color.Gainsboro
                Case "v1", "v2", "v3", "v4", "v5", "v6", "v7", "Label119"
                    BunifuCards14.BackColor = Color.Gainsboro
                Case "e1", "e2", "e3", "e4", "e5", "e6", "e7", "Label120"
                    BunifuCards13.BackColor = Color.Gainsboro
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub h7_MouseLeave(sender As Object, e As EventArgs) Handles h7.MouseLeave, h6.MouseLeave, h5.MouseLeave, h4.MouseLeave, h3.MouseLeave, h2.MouseLeave, h1.MouseLeave, a7.MouseLeave, a6.MouseLeave, a5.MouseLeave, a4.MouseLeave, a3.MouseLeave, a2.MouseLeave, a1.MouseLeave, r7.MouseLeave, r6.MouseLeave, r5.MouseLeave, r4.MouseLeave, r3.MouseLeave, r2.MouseLeave, r1.MouseLeave, s7.MouseLeave, s6.MouseLeave, s5.MouseLeave, s4.MouseLeave, s3.MouseLeave, s2.MouseLeave, s1.MouseLeave, hh7.MouseLeave, hh6.MouseLeave, hh5.MouseLeave, hh4.MouseLeave, hh3.MouseLeave, hh2.MouseLeave, hh1.MouseLeave, i7.MouseLeave, i6.MouseLeave, i5.MouseLeave, i4.MouseLeave, i3.MouseLeave, i2.MouseLeave, i1.MouseLeave, n7.MouseLeave, n6.MouseLeave, n5.MouseLeave, n4.MouseLeave, n3.MouseLeave, n2.MouseLeave, n1.MouseLeave, ii7.MouseLeave, ii6.MouseLeave, ii5.MouseLeave, ii4.MouseLeave, ii3.MouseLeave, ii2.MouseLeave, ii1.MouseLeave, l7.MouseLeave, l6.MouseLeave, l5.MouseLeave, l4.MouseLeave, l3.MouseLeave, l2.MouseLeave, l1.MouseLeave, o7.MouseLeave, o6.MouseLeave, o5.MouseLeave, o4.MouseLeave, o3.MouseLeave, o2.MouseLeave, o1.MouseLeave, v7.MouseLeave, v6.MouseLeave, v5.MouseLeave, v4.MouseLeave, v3.MouseLeave, v2.MouseLeave, v1.MouseLeave, e7.MouseLeave, e6.MouseLeave, e5.MouseLeave, e4.MouseLeave, e3.MouseLeave, e2.MouseLeave, e1.MouseLeave, Label109.MouseLeave, Label110.MouseLeave, Label111.MouseLeave, Label112.MouseLeave, Label113.MouseLeave, Label114.MouseLeave, Label115.MouseLeave, Label116.MouseLeave, Label117.MouseLeave, Label118.MouseLeave, Label119.MouseLeave, Label120.MouseLeave
        Try
            Select Case sender.name.ToString
                Case "h1", "h2", "h3", "h4", "h5", "h6", "h7", "Label109"
                    BunifuCards24.BackColor = Color.White
                Case "a1", "a2", "a3", "a4", "a5", "a6", "a7", "Label110"
                    BunifuCards23.BackColor = Color.White
                Case "r1", "r2", "r3", "r4", "r5", "r6", "r7", "Label111"
                    BunifuCards22.BackColor = Color.White
                Case "s1", "s2", "s3", "s4", "s5", "s6", "s7", "Label112"
                    BunifuCards21.BackColor = Color.White
                Case "hh1", "hh2", "hh3", "hh4", "hh5", "hh6", "hh7", "Label113"
                    BunifuCards20.BackColor = Color.White
                Case "i1", "i2", "i3", "i4", "i5", "i6", "i7", "Label114"
                    BunifuCards19.BackColor = Color.White
                Case "n1", "n2", "n3", "n4", "n5", "n6", "n7", "Label115"
                    BunifuCards18.BackColor = Color.White
                Case "ii1", "ii2", "ii3", "ii4", "ii5", "ii6", "ii7", "Label116"
                    BunifuCards17.BackColor = Color.White
                Case "l1", "l2", "l3", "l4", "l5", "l6", "l7", "Label117"
                    BunifuCards16.BackColor = Color.White
                Case "o1", "o2", "o3", "o4", "o5", "o6", "o7", "Label118"
                    BunifuCards15.BackColor = Color.White
                Case "v1", "v2", "v3", "v4", "v5", "v6", "v7", "Label119"
                    BunifuCards14.BackColor = Color.White
                Case "e1", "e2", "e3", "e4", "e5", "e6", "e7", "Label120"
                    BunifuCards13.BackColor = Color.White
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        '' MsgBox(Asc(e.KeyChar))
        Try
            If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub sectxt_KeyDown(sender As Object, e As KeyEventArgs) Handles sectxt.KeyDown
        If sectxt.Text = "" Then
        Else
            sectxt.Text = ""
        End If
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button1.MouseLeave, Button6.MouseLeave, Button7.MouseLeave, sectxt.MouseLeave, TextBox3.MouseLeave
        Try
            Select Case sender.Name
                Case "Button5"
                    ttp.Hide(Button5)
                Case "Button1"
                    ttp.Hide(Button1)
                Case "Button2"
                    ttp.Hide(Button2)
                Case "Button3"
                    ttp.Hide(Button3)
                Case "Button4"
                    ttp.Hide(Button4)
                Case "Button6"
                    ttp.Hide(Button6)
                Case "Button7"
                    ttp.Hide(Button7)
                Case "sectxt"
                    ttp.Hide(sectxt)
                Case "TextBox3"
                    ttp.Hide(TextBox3)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class
