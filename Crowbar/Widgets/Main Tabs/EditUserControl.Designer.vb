<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUserControl
	Inherits BaseUserControl

	''UserControl overrides dispose to clean up the component list.
	'<System.Diagnostics.DebuggerNonUserCode()> _
	'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	'	Try
	'		If disposing AndAlso components IsNot Nothing Then
	'			components.Dispose()
	'		End If
	'	Finally
	'		MyBase.Dispose(disposing)
	'	End Try
	'End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GotoQcButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.QcPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.BrowseForQcPathFolderOrFileNameButton = New System.Windows.Forms.Button()
        Me.UseInCompileButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GotoQcButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.QcPathFileNameTextBox)
        Me.Panel1.Controls.Add(Me.BrowseForQcPathFolderOrFileNameButton)
        Me.Panel1.Controls.Add(Me.UseInCompileButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 577)
        Me.Panel1.TabIndex = 16
        '
        'GotoQcButton
        '
        Me.GotoQcButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoQcButton.Location = New System.Drawing.Point(855, 3)
        Me.GotoQcButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GotoQcButton.Name = "GotoQcButton"
        Me.GotoQcButton.Size = New System.Drawing.Size(47, 25)
        Me.GotoQcButton.TabIndex = 29
        Me.GotoQcButton.Text = "前往"
        Me.GotoQcButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "QC文件或文件夹:"
        '
        'QcPathFileNameTextBox
        '
        Me.QcPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QcPathFileNameTextBox.Location = New System.Drawing.Point(106, 5)
        Me.QcPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.QcPathFileNameTextBox.Name = "QcPathFileNameTextBox"
        Me.QcPathFileNameTextBox.Size = New System.Drawing.Size(647, 22)
        Me.QcPathFileNameTextBox.TabIndex = 27
        '
        'BrowseForQcPathFolderOrFileNameButton
        '
        Me.BrowseForQcPathFolderOrFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForQcPathFolderOrFileNameButton.Location = New System.Drawing.Point(761, 3)
        Me.BrowseForQcPathFolderOrFileNameButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrowseForQcPathFolderOrFileNameButton.Name = "BrowseForQcPathFolderOrFileNameButton"
        Me.BrowseForQcPathFolderOrFileNameButton.Size = New System.Drawing.Size(88, 25)
        Me.BrowseForQcPathFolderOrFileNameButton.TabIndex = 28
        Me.BrowseForQcPathFolderOrFileNameButton.Text = "浏览..."
        Me.BrowseForQcPathFolderOrFileNameButton.UseVisualStyleBackColor = True
        '
        'UseInCompileButton
        '
        Me.UseInCompileButton.Enabled = False
        Me.UseInCompileButton.Location = New System.Drawing.Point(4, 58)
        Me.UseInCompileButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UseInCompileButton.Name = "UseInCompileButton"
        Me.UseInCompileButton.Size = New System.Drawing.Size(105, 25)
        Me.UseInCompileButton.TabIndex = 25
        Me.UseInCompileButton.Text = "转到编译页"
        Me.UseInCompileButton.UseVisualStyleBackColor = True
        '
        'EditUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "EditUserControl"
        Me.Size = New System.Drawing.Size(905, 577)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents UseInCompileButton As System.Windows.Forms.Button
	Friend WithEvents GotoQcButton As System.Windows.Forms.Button
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents QcPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents BrowseForQcPathFolderOrFileNameButton As System.Windows.Forms.Button

End Class
