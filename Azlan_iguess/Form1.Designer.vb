<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.p1 = New Bunifu.Framework.UI.BunifuCards()
        Me.butabout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.butprint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.butreport = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.buteval = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.About1 = New Azlan_iguess.about()
        Me.Lets1 = New Azlan_iguess.lets()
        Me.PrintAll1 = New Azlan_iguess.PrintAll()
        Me.Report1 = New Azlan_iguess.Report()
        Me.Evaluation1 = New Azlan_iguess.evaluation()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(267, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1104, 58)
        Me.Panel2.TabIndex = 5
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 50)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1349, 10)
        Me.BunifuSeparator1.TabIndex = 5
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FeedBack System"
        '
        'PictureBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Image = Global.Azlan_iguess.My.Resources.Resources.feedback
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(73, 58)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Image = Global.Azlan_iguess.My.Resources.Resources.jain_college_logo_iguess
        Me.PictureBox4.Location = New System.Drawing.Point(519, 4)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(275, 46)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.Azlan_iguess.My.Resources.Resources.minimize
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1215, 12)
        Me.BunifuImageButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(45, 37)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.Azlan_iguess.My.Resources.Resources._exit
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1268, 12)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(45, 37)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 3
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(50)
        Animation1.RotateCoeff = 1.0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        Me.BunifuTransition1.TimeStep = 0.06!
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Azlan_iguess.My.Resources.Resources.download__1_
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.p1)
        Me.Panel1.Controls.Add(Me.butabout)
        Me.Panel1.Controls.Add(Me.butprint)
        Me.Panel1.Controls.Add(Me.butreport)
        Me.Panel1.Controls.Add(Me.buteval)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 753)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = Global.Azlan_iguess.My.Resources.Resources.ASW31
        Me.PictureBox3.Location = New System.Drawing.Point(7, 795)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 85)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.Snow
        Me.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p1.BorderRadius = 25
        Me.p1.BottomSahddow = True
        Me.p1.color = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.p1, BunifuAnimatorNS.DecorationType.None)
        Me.p1.LeftSahddow = True
        Me.p1.Location = New System.Drawing.Point(237, 210)
        Me.p1.Margin = New System.Windows.Forms.Padding(4)
        Me.p1.Name = "p1"
        Me.p1.RightSahddow = True
        Me.p1.ShadowDepth = 50
        Me.p1.Size = New System.Drawing.Size(13, 65)
        Me.p1.TabIndex = 5
        '
        'butabout
        '
        Me.butabout.Activecolor = System.Drawing.Color.Plum
        Me.butabout.BackColor = System.Drawing.Color.Transparent
        Me.butabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butabout.BorderRadius = 0
        Me.butabout.ButtonText = "About"
        Me.butabout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.butabout, BunifuAnimatorNS.DecorationType.None)
        Me.butabout.DisabledColor = System.Drawing.Color.Gray
        Me.butabout.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.butabout.Iconcolor = System.Drawing.Color.Transparent
        Me.butabout.Iconimage = Global.Azlan_iguess.My.Resources.Resources.icon_09_512
        Me.butabout.Iconimage_right = Nothing
        Me.butabout.Iconimage_right_Selected = Nothing
        Me.butabout.Iconimage_Selected = Nothing
        Me.butabout.IconMarginLeft = 0
        Me.butabout.IconMarginRight = 0
        Me.butabout.IconRightVisible = True
        Me.butabout.IconRightZoom = 0R
        Me.butabout.IconVisible = True
        Me.butabout.IconZoom = 100.0R
        Me.butabout.IsTab = False
        Me.butabout.Location = New System.Drawing.Point(-3, 543)
        Me.butabout.Margin = New System.Windows.Forms.Padding(5)
        Me.butabout.Name = "butabout"
        Me.butabout.Normalcolor = System.Drawing.Color.Transparent
        Me.butabout.OnHovercolor = System.Drawing.Color.Plum
        Me.butabout.OnHoverTextColor = System.Drawing.Color.White
        Me.butabout.selected = False
        Me.butabout.Size = New System.Drawing.Size(299, 59)
        Me.butabout.TabIndex = 2
        Me.butabout.Text = "About"
        Me.butabout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butabout.Textcolor = System.Drawing.Color.Lavender
        Me.butabout.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'butprint
        '
        Me.butprint.Activecolor = System.Drawing.Color.Plum
        Me.butprint.BackColor = System.Drawing.Color.Transparent
        Me.butprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butprint.BorderRadius = 0
        Me.butprint.ButtonText = "Print"
        Me.butprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.butprint, BunifuAnimatorNS.DecorationType.None)
        Me.butprint.DisabledColor = System.Drawing.Color.Gray
        Me.butprint.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.butprint.Iconcolor = System.Drawing.Color.Transparent
        Me.butprint.Iconimage = Global.Azlan_iguess.My.Resources.Resources.print
        Me.butprint.Iconimage_right = Nothing
        Me.butprint.Iconimage_right_Selected = Nothing
        Me.butprint.Iconimage_Selected = Nothing
        Me.butprint.IconMarginLeft = 0
        Me.butprint.IconMarginRight = 0
        Me.butprint.IconRightVisible = True
        Me.butprint.IconRightZoom = 0R
        Me.butprint.IconVisible = True
        Me.butprint.IconZoom = 80.0R
        Me.butprint.IsTab = False
        Me.butprint.Location = New System.Drawing.Point(0, 443)
        Me.butprint.Margin = New System.Windows.Forms.Padding(5)
        Me.butprint.Name = "butprint"
        Me.butprint.Normalcolor = System.Drawing.Color.Transparent
        Me.butprint.OnHovercolor = System.Drawing.Color.Plum
        Me.butprint.OnHoverTextColor = System.Drawing.Color.White
        Me.butprint.selected = False
        Me.butprint.Size = New System.Drawing.Size(299, 59)
        Me.butprint.TabIndex = 2
        Me.butprint.Text = "Print"
        Me.butprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butprint.Textcolor = System.Drawing.Color.Lavender
        Me.butprint.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'butreport
        '
        Me.butreport.Activecolor = System.Drawing.Color.Plum
        Me.butreport.BackColor = System.Drawing.Color.Transparent
        Me.butreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butreport.BorderRadius = 0
        Me.butreport.ButtonText = "Report"
        Me.butreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.butreport, BunifuAnimatorNS.DecorationType.None)
        Me.butreport.DisabledColor = System.Drawing.Color.Gray
        Me.butreport.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.butreport.Iconcolor = System.Drawing.Color.Transparent
        Me.butreport.Iconimage = Global.Azlan_iguess.My.Resources.Resources.report
        Me.butreport.Iconimage_right = Nothing
        Me.butreport.Iconimage_right_Selected = Nothing
        Me.butreport.Iconimage_Selected = Nothing
        Me.butreport.IconMarginLeft = 0
        Me.butreport.IconMarginRight = 0
        Me.butreport.IconRightVisible = True
        Me.butreport.IconRightZoom = 0R
        Me.butreport.IconVisible = True
        Me.butreport.IconZoom = 80.0R
        Me.butreport.IsTab = False
        Me.butreport.Location = New System.Drawing.Point(0, 324)
        Me.butreport.Margin = New System.Windows.Forms.Padding(5)
        Me.butreport.Name = "butreport"
        Me.butreport.Normalcolor = System.Drawing.Color.Transparent
        Me.butreport.OnHovercolor = System.Drawing.Color.Plum
        Me.butreport.OnHoverTextColor = System.Drawing.Color.White
        Me.butreport.selected = False
        Me.butreport.Size = New System.Drawing.Size(299, 59)
        Me.butreport.TabIndex = 2
        Me.butreport.Text = "Report"
        Me.butreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butreport.Textcolor = System.Drawing.Color.Lavender
        Me.butreport.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'buteval
        '
        Me.buteval.Activecolor = System.Drawing.Color.Plum
        Me.buteval.BackColor = System.Drawing.Color.Transparent
        Me.buteval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buteval.BorderRadius = 0
        Me.buteval.ButtonText = "Evaluation"
        Me.buteval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.buteval, BunifuAnimatorNS.DecorationType.None)
        Me.buteval.DisabledColor = System.Drawing.Color.Gray
        Me.buteval.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.buteval.Iconcolor = System.Drawing.Color.Transparent
        Me.buteval.Iconimage = Global.Azlan_iguess.My.Resources.Resources.Evaluation
        Me.buteval.Iconimage_right = Nothing
        Me.buteval.Iconimage_right_Selected = Nothing
        Me.buteval.Iconimage_Selected = Nothing
        Me.buteval.IconMarginLeft = 0
        Me.buteval.IconMarginRight = 0
        Me.buteval.IconRightVisible = True
        Me.buteval.IconRightZoom = 0R
        Me.buteval.IconVisible = True
        Me.buteval.IconZoom = 90.0R
        Me.buteval.IsTab = False
        Me.buteval.Location = New System.Drawing.Point(0, 217)
        Me.buteval.Margin = New System.Windows.Forms.Padding(5)
        Me.buteval.Name = "buteval"
        Me.buteval.Normalcolor = System.Drawing.Color.Transparent
        Me.buteval.OnHovercolor = System.Drawing.Color.Plum
        Me.buteval.OnHoverTextColor = System.Drawing.Color.White
        Me.buteval.selected = False
        Me.buteval.Size = New System.Drawing.Size(299, 59)
        Me.buteval.TabIndex = 2
        Me.buteval.Text = "Evaluation"
        Me.buteval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buteval.Textcolor = System.Drawing.Color.Lavender
        Me.buteval.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.Azlan_iguess.My.Resources.Resources.iguessIcons
        Me.PictureBox1.Location = New System.Drawing.Point(100, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.Azlan_iguess.My.Resources.Resources.iguesstxt
        Me.PictureBox2.Location = New System.Drawing.Point(81, 66)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'About1
        '
        Me.About1.BackColor = System.Drawing.Color.Transparent
        Me.About1.BackgroundImage = CType(resources.GetObject("About1.BackgroundImage"), System.Drawing.Image)
        Me.About1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.About1, BunifuAnimatorNS.DecorationType.None)
        Me.About1.Location = New System.Drawing.Point(571, 159)
        Me.About1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.About1.Name = "About1"
        Me.About1.Size = New System.Drawing.Size(685, 546)
        Me.About1.TabIndex = 9
        Me.About1.Visible = False
        '
        'Lets1
        '
        Me.Lets1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.Lets1, BunifuAnimatorNS.DecorationType.None)
        Me.Lets1.Location = New System.Drawing.Point(587, 159)
        Me.Lets1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lets1.Name = "Lets1"
        Me.Lets1.Size = New System.Drawing.Size(645, 470)
        Me.Lets1.TabIndex = 8
        '
        'PrintAll1
        '
        Me.PrintAll1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.PrintAll1, BunifuAnimatorNS.DecorationType.None)
        Me.PrintAll1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintAll1.Location = New System.Drawing.Point(267, 58)
        Me.PrintAll1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintAll1.Name = "PrintAll1"
        Me.PrintAll1.Size = New System.Drawing.Size(1104, 695)
        Me.PrintAll1.TabIndex = 7
        Me.PrintAll1.Visible = False
        '
        'Report1
        '
        Me.Report1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.Report1, BunifuAnimatorNS.DecorationType.None)
        Me.Report1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Report1.Location = New System.Drawing.Point(267, 58)
        Me.Report1.Margin = New System.Windows.Forms.Padding(5)
        Me.Report1.Name = "Report1"
        Me.Report1.Size = New System.Drawing.Size(1104, 695)
        Me.Report1.TabIndex = 6
        Me.Report1.Visible = False
        '
        'Evaluation1
        '
        Me.Evaluation1.BackColor = System.Drawing.Color.White
        Me.Evaluation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuTransition1.SetDecoration(Me.Evaluation1, BunifuAnimatorNS.DecorationType.None)
        Me.Evaluation1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evaluation1.Location = New System.Drawing.Point(288, 54)
        Me.Evaluation1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Evaluation1.Name = "Evaluation1"
        Me.Evaluation1.Size = New System.Drawing.Size(1492, 1108)
        Me.Evaluation1.TabIndex = 4
        Me.Evaluation1.Visible = False
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Panel1
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 50
        Me.BunifuElipse2.TargetControl = Me.About1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1371, 753)
        Me.Controls.Add(Me.About1)
        Me.Controls.Add(Me.Lets1)
        Me.Controls.Add(Me.PrintAll1)
        Me.Controls.Add(Me.Report1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Evaluation1)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buteval As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents butprint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents butreport As Bunifu.Framework.UI.BunifuFlatButton

    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Evaluation1 As evaluation
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents p1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Report1 As Report
    Friend WithEvents PrintAll1 As PrintAll
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Lets1 As lets
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents About1 As about
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents butabout As Bunifu.Framework.UI.BunifuFlatButton
End Class
