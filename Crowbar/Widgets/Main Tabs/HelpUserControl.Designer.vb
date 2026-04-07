<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpUserControl
	Inherits BaseUserControl

	''UserControl overrides dispose to clean up the component list.
	'<System.Diagnostics.DebuggerNonUserCode()> _
	'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	'    Try
	'        If disposing AndAlso components IsNot Nothing Then
	'            components.Dispose()
	'        End If
	'    Finally
	'        MyBase.Dispose(disposing)
	'    End Try
	'End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TutorialLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ContentsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.IndexLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TipsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CrowbarGuideButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TutorialLinkLabel
        '
        Me.TutorialLinkLabel.ActiveLinkColor = System.Drawing.Color.Lime
        Me.TutorialLinkLabel.AutoSize = True
        Me.TutorialLinkLabel.Font = New System.Drawing.Font("Maple UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutorialLinkLabel.LinkColor = System.Drawing.Color.Green
        Me.TutorialLinkLabel.Location = New System.Drawing.Point(7, 17)
        Me.TutorialLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TutorialLinkLabel.Name = "TutorialLinkLabel"
        Me.TutorialLinkLabel.Size = New System.Drawing.Size(54, 27)
        Me.TutorialLinkLabel.TabIndex = 1
        Me.TutorialLinkLabel.TabStop = True
        Me.TutorialLinkLabel.Text = "教程"
        Me.TutorialLinkLabel.VisitedLinkColor = System.Drawing.Color.Green
        '
        'ContentsLinkLabel
        '
        Me.ContentsLinkLabel.ActiveLinkColor = System.Drawing.Color.Lime
        Me.ContentsLinkLabel.AutoSize = True
        Me.ContentsLinkLabel.Font = New System.Drawing.Font("Maple UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContentsLinkLabel.LinkColor = System.Drawing.Color.Green
        Me.ContentsLinkLabel.Location = New System.Drawing.Point(7, 44)
        Me.ContentsLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ContentsLinkLabel.Name = "ContentsLinkLabel"
        Me.ContentsLinkLabel.Size = New System.Drawing.Size(54, 27)
        Me.ContentsLinkLabel.TabIndex = 2
        Me.ContentsLinkLabel.TabStop = True
        Me.ContentsLinkLabel.Text = "目录"
        Me.ContentsLinkLabel.VisitedLinkColor = System.Drawing.Color.Green
        '
        'IndexLinkLabel
        '
        Me.IndexLinkLabel.ActiveLinkColor = System.Drawing.Color.Lime
        Me.IndexLinkLabel.AutoSize = True
        Me.IndexLinkLabel.Font = New System.Drawing.Font("Maple UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexLinkLabel.LinkColor = System.Drawing.Color.Green
        Me.IndexLinkLabel.Location = New System.Drawing.Point(7, 71)
        Me.IndexLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IndexLinkLabel.Name = "IndexLinkLabel"
        Me.IndexLinkLabel.Size = New System.Drawing.Size(54, 27)
        Me.IndexLinkLabel.TabIndex = 3
        Me.IndexLinkLabel.TabStop = True
        Me.IndexLinkLabel.Text = "索引"
        Me.IndexLinkLabel.VisitedLinkColor = System.Drawing.Color.Green
        '
        'TipsLinkLabel
        '
        Me.TipsLinkLabel.ActiveLinkColor = System.Drawing.Color.Lime
        Me.TipsLinkLabel.AutoSize = True
        Me.TipsLinkLabel.Font = New System.Drawing.Font("Maple UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipsLinkLabel.LinkColor = System.Drawing.Color.Green
        Me.TipsLinkLabel.Location = New System.Drawing.Point(7, 98)
        Me.TipsLinkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TipsLinkLabel.Name = "TipsLinkLabel"
        Me.TipsLinkLabel.Size = New System.Drawing.Size(54, 27)
        Me.TipsLinkLabel.TabIndex = 4
        Me.TipsLinkLabel.TabStop = True
        Me.TipsLinkLabel.Text = "提示"
        Me.TipsLinkLabel.VisitedLinkColor = System.Drawing.Color.Green
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TutorialLinkLabel)
        Me.GroupBox1.Controls.Add(Me.TipsLinkLabel)
        Me.GroupBox1.Controls.Add(Me.ContentsLinkLabel)
        Me.GroupBox1.Controls.Add(Me.IndexLinkLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 418)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(747, 142)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maple UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "使用Crowbar的方法可能并不明显."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Maple UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "重要词汇和短语使用的链接."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maple UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "文档按章节整理."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maple UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "详细指南 讲解如何使用大部分功能."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maple UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 363)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(419, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Crowbar让你可以快速访问许多用于为Source引擎游戏建模的模组工具."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maple UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 389)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "(以下均为无效链接 将在默认网页浏览器中打开.)"
        '
        'CrowbarGuideButton
        '
        Me.CrowbarGuideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CrowbarGuideButton.Image = Global.Crowbar.My.Resources.Resources.CrowbarGuideBanner
        Me.CrowbarGuideButton.Location = New System.Drawing.Point(4, 3)
        Me.CrowbarGuideButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CrowbarGuideButton.Name = "CrowbarGuideButton"
        Me.CrowbarGuideButton.Size = New System.Drawing.Size(618, 158)
        Me.CrowbarGuideButton.TabIndex = 9
        Me.CrowbarGuideButton.UseVisualStyleBackColor = True
        '
        'HelpUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrowbarGuideButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HelpUserControl"
        Me.Size = New System.Drawing.Size(905, 577)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TutorialLinkLabel As System.Windows.Forms.LinkLabel
	Friend WithEvents ContentsLinkLabel As System.Windows.Forms.LinkLabel
	Friend WithEvents IndexLinkLabel As System.Windows.Forms.LinkLabel
	Friend WithEvents TipsLinkLabel As System.Windows.Forms.LinkLabel
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents CrowbarGuideButton As System.Windows.Forms.Button

End Class
