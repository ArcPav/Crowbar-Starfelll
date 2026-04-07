<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateUserControl
	Inherits BaseUserControl

	''UserControl overrides dispose to clean up the component list.
	'<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UpdateUserControlFillPanel = New System.Windows.Forms.Panel()
        Me.CheckForUpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChangelogTextBox = New Crowbar.RichTextBoxEx()
        Me.CurrentVersionLabel = New System.Windows.Forms.Label()
        Me.CheckForUpdateTopPanel = New System.Windows.Forms.Panel()
        Me.CheckForUpdateButton = New System.Windows.Forms.Button()
        Me.CheckForUpdateTextBox = New Crowbar.TextBoxEx()
        Me.CheckForUpdateProgressBar = New Crowbar.ProgressBarEx()
        Me.CancelCheckButton = New System.Windows.Forms.Button()
        Me.DownloadGroupBox = New System.Windows.Forms.GroupBox()
        Me.DownloadFolderTextBox = New Crowbar.TextBoxEx()
        Me.DownloadProgressBarEx = New Crowbar.ProgressBarEx()
        Me.BrowseForDownloadFolderButton = New System.Windows.Forms.Button()
        Me.DownloadFolderLabel = New System.Windows.Forms.Label()
        Me.GotoDownloadFileButton = New System.Windows.Forms.Button()
        Me.CancelDownloadButton = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.UpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.CancelUpdateButton = New System.Windows.Forms.Button()
        Me.BrowseForUpdateFolderButton = New System.Windows.Forms.Button()
        Me.UpdateFolderTextBox = New Crowbar.TextBoxEx()
        Me.UpdateProgressBarEx = New Crowbar.ProgressBarEx()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.UpdateToNewPathCheckBox = New System.Windows.Forms.CheckBox()
        Me.UpdateCopySettingsCheckBox = New System.Windows.Forms.CheckBox()
        Me.UpdateUserControlFillPanel.SuspendLayout()
        Me.CheckForUpdateGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CheckForUpdateTopPanel.SuspendLayout()
        Me.DownloadGroupBox.SuspendLayout()
        Me.UpdateGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpdateUserControlFillPanel
        '
        Me.UpdateUserControlFillPanel.Controls.Add(Me.CheckForUpdateGroupBox)
        Me.UpdateUserControlFillPanel.Controls.Add(Me.DownloadGroupBox)
        Me.UpdateUserControlFillPanel.Controls.Add(Me.UpdateGroupBox)
        Me.UpdateUserControlFillPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateUserControlFillPanel.Location = New System.Drawing.Point(0, 0)
        Me.UpdateUserControlFillPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateUserControlFillPanel.Name = "UpdateUserControlFillPanel"
        Me.UpdateUserControlFillPanel.Size = New System.Drawing.Size(905, 577)
        Me.UpdateUserControlFillPanel.TabIndex = 17
        '
        'CheckForUpdateGroupBox
        '
        Me.CheckForUpdateGroupBox.Controls.Add(Me.Panel1)
        Me.CheckForUpdateGroupBox.Controls.Add(Me.CurrentVersionLabel)
        Me.CheckForUpdateGroupBox.Controls.Add(Me.CheckForUpdateTopPanel)
        Me.CheckForUpdateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckForUpdateGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.CheckForUpdateGroupBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateGroupBox.Name = "CheckForUpdateGroupBox"
        Me.CheckForUpdateGroupBox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateGroupBox.Size = New System.Drawing.Size(905, 393)
        Me.CheckForUpdateGroupBox.TabIndex = 14
        Me.CheckForUpdateGroupBox.TabStop = False
        Me.CheckForUpdateGroupBox.Text = "检查更新-查看最新版本并获取更新日志"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChangelogTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Size = New System.Drawing.Size(897, 344)
        Me.Panel1.TabIndex = 16
        '
        'ChangelogTextBox
        '
        Me.ChangelogTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ChangelogTextBox.CueBannerText = ""
        Me.ChangelogTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangelogTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangelogTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ChangelogTextBox.Location = New System.Drawing.Point(4, 3)
        Me.ChangelogTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ChangelogTextBox.Name = "ChangelogTextBox"
        Me.ChangelogTextBox.Size = New System.Drawing.Size(889, 338)
        Me.ChangelogTextBox.TabIndex = 6
        Me.ChangelogTextBox.Text = ""
        '
        'CurrentVersionLabel
        '
        Me.CurrentVersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentVersionLabel.AutoSize = True
        Me.CurrentVersionLabel.Location = New System.Drawing.Point(769, 0)
        Me.CurrentVersionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CurrentVersionLabel.Name = "CurrentVersionLabel"
        Me.CurrentVersionLabel.Size = New System.Drawing.Size(113, 14)
        Me.CurrentVersionLabel.TabIndex = 14
        Me.CurrentVersionLabel.Text = "当前版本: 0.00"
        '
        'CheckForUpdateTopPanel
        '
        Me.CheckForUpdateTopPanel.Controls.Add(Me.CheckForUpdateButton)
        Me.CheckForUpdateTopPanel.Controls.Add(Me.CheckForUpdateTextBox)
        Me.CheckForUpdateTopPanel.Controls.Add(Me.CheckForUpdateProgressBar)
        Me.CheckForUpdateTopPanel.Controls.Add(Me.CancelCheckButton)
        Me.CheckForUpdateTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckForUpdateTopPanel.Location = New System.Drawing.Point(4, 18)
        Me.CheckForUpdateTopPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateTopPanel.Name = "CheckForUpdateTopPanel"
        Me.CheckForUpdateTopPanel.Size = New System.Drawing.Size(897, 28)
        Me.CheckForUpdateTopPanel.TabIndex = 15
        '
        'CheckForUpdateButton
        '
        Me.CheckForUpdateButton.Location = New System.Drawing.Point(4, 0)
        Me.CheckForUpdateButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateButton.Name = "CheckForUpdateButton"
        Me.CheckForUpdateButton.Size = New System.Drawing.Size(80, 25)
        Me.CheckForUpdateButton.TabIndex = 1
        Me.CheckForUpdateButton.Text = "检查"
        Me.CheckForUpdateButton.UseVisualStyleBackColor = True
        '
        'CheckForUpdateTextBox
        '
        Me.CheckForUpdateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckForUpdateTextBox.CueBannerText = ""
        Me.CheckForUpdateTextBox.Location = New System.Drawing.Point(91, 0)
        Me.CheckForUpdateTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateTextBox.Name = "CheckForUpdateTextBox"
        Me.CheckForUpdateTextBox.ReadOnly = True
        Me.CheckForUpdateTextBox.Size = New System.Drawing.Size(715, 22)
        Me.CheckForUpdateTextBox.TabIndex = 9
        Me.CheckForUpdateTextBox.Text = "[暂未检查]"
        '
        'CheckForUpdateProgressBar
        '
        Me.CheckForUpdateProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckForUpdateProgressBar.Location = New System.Drawing.Point(91, 0)
        Me.CheckForUpdateProgressBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckForUpdateProgressBar.Name = "CheckForUpdateProgressBar"
        Me.CheckForUpdateProgressBar.Size = New System.Drawing.Size(715, 24)
        Me.CheckForUpdateProgressBar.TabIndex = 10
        Me.CheckForUpdateProgressBar.Visible = False
        '
        'CancelCheckButton
        '
        Me.CancelCheckButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelCheckButton.Enabled = False
        Me.CancelCheckButton.Location = New System.Drawing.Point(813, 0)
        Me.CancelCheckButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelCheckButton.Name = "CancelCheckButton"
        Me.CancelCheckButton.Size = New System.Drawing.Size(80, 25)
        Me.CancelCheckButton.TabIndex = 11
        Me.CancelCheckButton.Text = "取消"
        Me.CancelCheckButton.UseVisualStyleBackColor = True
        '
        'DownloadGroupBox
        '
        Me.DownloadGroupBox.Controls.Add(Me.DownloadFolderTextBox)
        Me.DownloadGroupBox.Controls.Add(Me.DownloadProgressBarEx)
        Me.DownloadGroupBox.Controls.Add(Me.BrowseForDownloadFolderButton)
        Me.DownloadGroupBox.Controls.Add(Me.DownloadFolderLabel)
        Me.DownloadGroupBox.Controls.Add(Me.GotoDownloadFileButton)
        Me.DownloadGroupBox.Controls.Add(Me.CancelDownloadButton)
        Me.DownloadGroupBox.Controls.Add(Me.DownloadButton)
        Me.DownloadGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownloadGroupBox.Location = New System.Drawing.Point(0, 393)
        Me.DownloadGroupBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DownloadGroupBox.Name = "DownloadGroupBox"
        Me.DownloadGroupBox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DownloadGroupBox.Size = New System.Drawing.Size(905, 82)
        Me.DownloadGroupBox.TabIndex = 8
        Me.DownloadGroupBox.TabStop = False
        Me.DownloadGroupBox.Text = "下载新版本(压缩包)以便手动更新"
        '
        'DownloadFolderTextBox
        '
        Me.DownloadFolderTextBox.AllowDrop = True
        Me.DownloadFolderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadFolderTextBox.CueBannerText = ""
        Me.DownloadFolderTextBox.Location = New System.Drawing.Point(125, 16)
        Me.DownloadFolderTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DownloadFolderTextBox.Name = "DownloadFolderTextBox"
        Me.DownloadFolderTextBox.Size = New System.Drawing.Size(678, 22)
        Me.DownloadFolderTextBox.TabIndex = 7
        '
        'DownloadProgressBarEx
        '
        Me.DownloadProgressBarEx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadProgressBarEx.Location = New System.Drawing.Point(102, 47)
        Me.DownloadProgressBarEx.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DownloadProgressBarEx.Name = "DownloadProgressBarEx"
        Me.DownloadProgressBarEx.Size = New System.Drawing.Size(608, 25)
        Me.DownloadProgressBarEx.TabIndex = 6
        '
        'BrowseForDownloadFolderButton
        '
        Me.BrowseForDownloadFolderButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForDownloadFolderButton.Location = New System.Drawing.Point(811, 16)
        Me.BrowseForDownloadFolderButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrowseForDownloadFolderButton.Name = "BrowseForDownloadFolderButton"
        Me.BrowseForDownloadFolderButton.Size = New System.Drawing.Size(88, 25)
        Me.BrowseForDownloadFolderButton.TabIndex = 8
        Me.BrowseForDownloadFolderButton.Text = "浏览..."
        Me.BrowseForDownloadFolderButton.UseVisualStyleBackColor = True
        '
        'DownloadFolderLabel
        '
        Me.DownloadFolderLabel.AutoSize = True
        Me.DownloadFolderLabel.Location = New System.Drawing.Point(4, 22)
        Me.DownloadFolderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DownloadFolderLabel.Name = "DownloadFolderLabel"
        Me.DownloadFolderLabel.Size = New System.Drawing.Size(65, 14)
        Me.DownloadFolderLabel.TabIndex = 9
        Me.DownloadFolderLabel.Text = "下载文件夹:"
        '
        'GotoDownloadFileButton
        '
        Me.GotoDownloadFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoDownloadFileButton.Enabled = False
        Me.GotoDownloadFileButton.Location = New System.Drawing.Point(811, 47)
        Me.GotoDownloadFileButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GotoDownloadFileButton.Name = "GotoDownloadFileButton"
        Me.GotoDownloadFileButton.Size = New System.Drawing.Size(88, 25)
        Me.GotoDownloadFileButton.TabIndex = 13
        Me.GotoDownloadFileButton.Text = "前往"
        Me.GotoDownloadFileButton.UseVisualStyleBackColor = True
        '
        'CancelDownloadButton
        '
        Me.CancelDownloadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelDownloadButton.Enabled = False
        Me.CancelDownloadButton.Location = New System.Drawing.Point(716, 47)
        Me.CancelDownloadButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelDownloadButton.Name = "CancelDownloadButton"
        Me.CancelDownloadButton.Size = New System.Drawing.Size(88, 25)
        Me.CancelDownloadButton.TabIndex = 12
        Me.CancelDownloadButton.Text = "取消"
        Me.CancelDownloadButton.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(7, 47)
        Me.DownloadButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(88, 25)
        Me.DownloadButton.TabIndex = 2
        Me.DownloadButton.Text = "下载"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'UpdateGroupBox
        '
        Me.UpdateGroupBox.Controls.Add(Me.CancelUpdateButton)
        Me.UpdateGroupBox.Controls.Add(Me.BrowseForUpdateFolderButton)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateFolderTextBox)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateProgressBarEx)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateButton)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateToNewPathCheckBox)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateCopySettingsCheckBox)
        Me.UpdateGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UpdateGroupBox.Location = New System.Drawing.Point(0, 475)
        Me.UpdateGroupBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateGroupBox.Name = "UpdateGroupBox"
        Me.UpdateGroupBox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateGroupBox.Size = New System.Drawing.Size(905, 102)
        Me.UpdateGroupBox.TabIndex = 7
        Me.UpdateGroupBox.TabStop = False
        Me.UpdateGroupBox.Text = "将当前版本更新为最新-Crowbar将重新打开"
        '
        'CancelUpdateButton
        '
        Me.CancelUpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelUpdateButton.Enabled = False
        Me.CancelUpdateButton.Location = New System.Drawing.Point(811, 71)
        Me.CancelUpdateButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelUpdateButton.Name = "CancelUpdateButton"
        Me.CancelUpdateButton.Size = New System.Drawing.Size(88, 25)
        Me.CancelUpdateButton.TabIndex = 13
        Me.CancelUpdateButton.Text = "取消"
        Me.CancelUpdateButton.UseVisualStyleBackColor = True
        '
        'BrowseForUpdateFolderButton
        '
        Me.BrowseForUpdateFolderButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForUpdateFolderButton.Location = New System.Drawing.Point(811, 17)
        Me.BrowseForUpdateFolderButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrowseForUpdateFolderButton.Name = "BrowseForUpdateFolderButton"
        Me.BrowseForUpdateFolderButton.Size = New System.Drawing.Size(88, 25)
        Me.BrowseForUpdateFolderButton.TabIndex = 10
        Me.BrowseForUpdateFolderButton.Text = "浏览..."
        Me.BrowseForUpdateFolderButton.UseVisualStyleBackColor = True
        '
        'UpdateFolderTextBox
        '
        Me.UpdateFolderTextBox.AllowDrop = True
        Me.UpdateFolderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateFolderTextBox.CueBannerText = ""
        Me.UpdateFolderTextBox.Location = New System.Drawing.Point(310, 17)
        Me.UpdateFolderTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateFolderTextBox.Name = "UpdateFolderTextBox"
        Me.UpdateFolderTextBox.Size = New System.Drawing.Size(493, 22)
        Me.UpdateFolderTextBox.TabIndex = 9
        '
        'UpdateProgressBarEx
        '
        Me.UpdateProgressBarEx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateProgressBarEx.Location = New System.Drawing.Point(102, 71)
        Me.UpdateProgressBarEx.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateProgressBarEx.Name = "UpdateProgressBarEx"
        Me.UpdateProgressBarEx.Size = New System.Drawing.Size(702, 25)
        Me.UpdateProgressBarEx.TabIndex = 5
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(7, 71)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(88, 25)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "更新"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'UpdateToNewPathCheckBox
        '
        Me.UpdateToNewPathCheckBox.AutoSize = True
        Me.UpdateToNewPathCheckBox.Location = New System.Drawing.Point(7, 22)
        Me.UpdateToNewPathCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateToNewPathCheckBox.Name = "UpdateToNewPathCheckBox"
        Me.UpdateToNewPathCheckBox.Size = New System.Drawing.Size(180, 18)
        Me.UpdateToNewPathCheckBox.TabIndex = 4
        Me.UpdateToNewPathCheckBox.Text = "更新到新文件夹(保持当前版本):"
        Me.UpdateToNewPathCheckBox.UseVisualStyleBackColor = True
        '
        'UpdateCopySettingsCheckBox
        '
        Me.UpdateCopySettingsCheckBox.AutoSize = True
        Me.UpdateCopySettingsCheckBox.Checked = True
        Me.UpdateCopySettingsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UpdateCopySettingsCheckBox.Location = New System.Drawing.Point(7, 46)
        Me.UpdateCopySettingsCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UpdateCopySettingsCheckBox.Name = "UpdateCopySettingsCheckBox"
        Me.UpdateCopySettingsCheckBox.Size = New System.Drawing.Size(180, 18)
        Me.UpdateCopySettingsCheckBox.TabIndex = 3
        Me.UpdateCopySettingsCheckBox.Text = "将设置从当前版本复制到新版本"
        Me.UpdateCopySettingsCheckBox.UseVisualStyleBackColor = True
        '
        'UpdateUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UpdateUserControlFillPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UpdateUserControl"
        Me.Size = New System.Drawing.Size(905, 577)
        Me.UpdateUserControlFillPanel.ResumeLayout(False)
        Me.CheckForUpdateGroupBox.ResumeLayout(False)
        Me.CheckForUpdateGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.CheckForUpdateTopPanel.ResumeLayout(False)
        Me.CheckForUpdateTopPanel.PerformLayout()
        Me.DownloadGroupBox.ResumeLayout(False)
        Me.DownloadGroupBox.PerformLayout()
        Me.UpdateGroupBox.ResumeLayout(False)
        Me.UpdateGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UpdateButton As Button
	Friend WithEvents CheckForUpdateButton As Button
	Friend WithEvents DownloadButton As Button
	Friend WithEvents UpdateCopySettingsCheckBox As CheckBox
	Friend WithEvents UpdateToNewPathCheckBox As CheckBox
	Friend WithEvents ChangelogTextBox As RichTextBoxEx
	Friend WithEvents UpdateGroupBox As GroupBox
	Friend WithEvents UpdateProgressBarEx As ProgressBarEx
	Friend WithEvents DownloadGroupBox As GroupBox
	Friend WithEvents DownloadProgressBarEx As ProgressBarEx
	Friend WithEvents DownloadFolderLabel As Label
	Friend WithEvents BrowseForDownloadFolderButton As Button
	Friend WithEvents DownloadFolderTextBox As TextBoxEx
	Friend WithEvents BrowseForUpdateFolderButton As Button
	Friend WithEvents UpdateFolderTextBox As TextBoxEx
	Friend WithEvents CheckForUpdateTextBox As TextBoxEx
	Friend WithEvents CheckForUpdateProgressBar As ProgressBarEx
	Friend WithEvents CancelUpdateButton As Button
	Friend WithEvents CancelDownloadButton As Button
	Friend WithEvents CancelCheckButton As Button
	Friend WithEvents CheckForUpdateGroupBox As GroupBox
	Friend WithEvents CurrentVersionLabel As Label
	Friend WithEvents GotoDownloadFileButton As Button
	Friend WithEvents UpdateUserControlFillPanel As Panel
	Friend WithEvents CheckForUpdateTopPanel As Panel
	Friend WithEvents Panel1 As Panel
End Class
