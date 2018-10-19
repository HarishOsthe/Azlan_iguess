<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintAll
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Button1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards3.SuspendLayout()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 10)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(277, 35)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(3, 12)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(264, 35)
        Me.ComboBox2.TabIndex = 2
        '
        'DG1
        '
        Me.DG1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DG1.Location = New System.Drawing.Point(-7, 2)
        Me.DG1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        Me.DG1.RowTemplate.Height = 24
        Me.DG1.Size = New System.Drawing.Size(627, 407)
        Me.DG1.TabIndex = 4
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Me.Chart1.Location = New System.Drawing.Point(469, 282)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(809, 411)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(581, 221)
        Me.TextBox1.TabIndex = 8
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Violet
        Me.BunifuCards1.Controls.Add(Me.ComboBox1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(35, 66)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 50
        Me.BunifuCards1.Size = New System.Drawing.Size(283, 52)
        Me.BunifuCards1.TabIndex = 9
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Violet
        Me.BunifuCards2.Controls.Add(Me.ComboBox2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(345, 65)
        Me.BunifuCards2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 50
        Me.BunifuCards2.Size = New System.Drawing.Size(269, 54)
        Me.BunifuCards2.TabIndex = 10
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.Violet
        Me.BunifuCards3.Controls.Add(Me.TextBox1)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(37, 252)
        Me.BunifuCards3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 50
        Me.BunifuCards3.Size = New System.Drawing.Size(581, 223)
        Me.BunifuCards3.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(81, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Department Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(411, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Evaluation Date"
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.Violet
        Me.BunifuCards4.Controls.Add(Me.DG1)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(633, 65)
        Me.BunifuCards4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 50
        Me.BunifuCards4.Size = New System.Drawing.Size(620, 407)
        Me.BunifuCards4.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(243, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Principal's Comment"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Azlan_iguess.My.Resources.Resources.animated_loading__by__amiri
        Me.PictureBox4.Location = New System.Drawing.Point(843, 543)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(400, 300)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Azlan_iguess.My.Resources.Resources.ASW2
        Me.PictureBox3.Location = New System.Drawing.Point(567, 670)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(250, 141)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Azlan_iguess.My.Resources.Resources.save
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(213, 512)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(100, 71)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 15
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.Azlan_iguess.My.Resources.Resources.printlo
        Me.Button1.ImageActive = Nothing
        Me.Button1.Location = New System.Drawing.Point(341, 512)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 71)
        Me.Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Button1.TabIndex = 11
        Me.Button1.TabStop = False
        Me.Button1.Zoom = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(697, 658)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Azlan_iguess.My.Resources.Resources.jainlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(697, 583)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(764, 476)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "-"
        '
        'PrintAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuCards4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuCards3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PrintAll"
        Me.Size = New System.Drawing.Size(1273, 832)
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.BunifuCards4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label4 As Label
End Class
