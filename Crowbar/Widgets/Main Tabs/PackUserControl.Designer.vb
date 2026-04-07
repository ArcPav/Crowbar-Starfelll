<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PackUserControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GotoOutputPathButton = New System.Windows.Forms.Button()
        Me.BrowseForOutputPathButton = New System.Windows.Forms.Button()
        Me.OutputPathTextBox = New Crowbar.TextBoxEx()
        Me.OutputParentPathTextBox = New Crowbar.TextBoxEx()
        Me.OutputPathComboBox = New System.Windows.Forms.ComboBox()
        Me.InputComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GotoInputPathButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InputPathFileNameTextBox = New Crowbar.TextBoxEx()
        Me.BrowseForInputFolderOrFileNameButton = New System.Windows.Forms.Button()
        Me.Options_LogSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OptionsGroupBoxFillPanel = New System.Windows.Forms.Panel()
        Me.PackerOptionsPanel = New System.Windows.Forms.Panel()
        Me.IgnoreWhitelistWarningsCheckBox = New System.Windows.Forms.CheckBox()
        Me.MultiFileVpkCheckBox = New System.Windows.Forms.CheckBox()
        Me.PackOptionsUseDefaultsButton = New System.Windows.Forms.Button()
        Me.LogFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GameSetupComboBox = New System.Windows.Forms.ComboBox()
        Me.SetUpGamesButton = New System.Windows.Forms.Button()
        Me.GmaPanel = New System.Windows.Forms.Panel()
        Me.GmaTitleTextBox = New Crowbar.TextBoxEx()
        Me.GmaTitleLabel = New System.Windows.Forms.Label()
        Me.GmaGarrysModTagsUserControl = New Crowbar.GarrysModTagsUserControl()
        Me.DirectPackerOptionsLabel = New System.Windows.Forms.Label()
        Me.DirectPackerOptionsTextBox = New System.Windows.Forms.TextBox()
        Me.PackerOptionsTextBox = New System.Windows.Forms.TextBox()
        Me.PackerOptionsTextBoxMinScrollPanel = New System.Windows.Forms.Panel()
        Me.LogRichTextBox = New Crowbar.RichTextBoxEx()
        Me.PackButtonsPanel = New System.Windows.Forms.Panel()
        Me.PackButton = New System.Windows.Forms.Button()
        Me.SkipCurrentFolderButton = New System.Windows.Forms.Button()
        Me.CancelPackButton = New System.Windows.Forms.Button()
        Me.UseAllInPublishButton = New System.Windows.Forms.Button()
        Me.PostPackPanel = New System.Windows.Forms.Panel()
        Me.PackedFilesComboBox = New System.Windows.Forms.ComboBox()
        Me.UseInPublishButton = New System.Windows.Forms.Button()
        Me.GotoPackedFileButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Options_LogSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Options_LogSplitContainer.Panel1.SuspendLayout()
        Me.Options_LogSplitContainer.Panel2.SuspendLayout()
        Me.Options_LogSplitContainer.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.OptionsGroupBoxFillPanel.SuspendLayout()
        Me.PackerOptionsPanel.SuspendLayout()
        Me.GmaPanel.SuspendLayout()
        Me.PackButtonsPanel.SuspendLayout()
        Me.PostPackPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GotoOutputPathButton)
        Me.Panel1.Controls.Add(Me.BrowseForOutputPathButton)
        Me.Panel1.Controls.Add(Me.OutputPathTextBox)
        Me.Panel1.Controls.Add(Me.OutputParentPathTextBox)
        Me.Panel1.Controls.Add(Me.OutputPathComboBox)
        Me.Panel1.Controls.Add(Me.InputComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GotoInputPathButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.InputPathFileNameTextBox)
        Me.Panel1.Controls.Add(Me.BrowseForInputFolderOrFileNameButton)
        Me.Panel1.Controls.Add(Me.Options_LogSplitContainer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 577)
        Me.Panel1.TabIndex = 3
        '
        'GotoOutputPathButton
        '
        Me.GotoOutputPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoOutputPathButton.Location = New System.Drawing.Point(852, 34)
        Me.GotoOutputPathButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GotoOutputPathButton.Name = "GotoOutputPathButton"
        Me.GotoOutputPathButton.Size = New System.Drawing.Size(50, 25)
        Me.GotoOutputPathButton.TabIndex = 27
        Me.GotoOutputPathButton.Text = "前往"
        Me.GotoOutputPathButton.UseVisualStyleBackColor = True
        '
        'BrowseForOutputPathButton
        '
        Me.BrowseForOutputPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForOutputPathButton.Location = New System.Drawing.Point(770, 34)
        Me.BrowseForOutputPathButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrowseForOutputPathButton.Name = "BrowseForOutputPathButton"
        Me.BrowseForOutputPathButton.Size = New System.Drawing.Size(75, 25)
        Me.BrowseForOutputPathButton.TabIndex = 26
        Me.BrowseForOutputPathButton.Text = "浏览..."
        Me.BrowseForOutputPathButton.UseVisualStyleBackColor = True
        '
        'OutputPathTextBox
        '
        Me.OutputPathTextBox.AllowDrop = True
        Me.OutputPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputPathTextBox.CueBannerText = ""
        Me.OutputPathTextBox.Location = New System.Drawing.Point(260, 34)
        Me.OutputPathTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OutputPathTextBox.Name = "OutputPathTextBox"
        Me.OutputPathTextBox.Size = New System.Drawing.Size(502, 22)
        Me.OutputPathTextBox.TabIndex = 25
        '
        'OutputParentPathTextBox
        '
        Me.OutputParentPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputParentPathTextBox.CueBannerText = ""
        Me.OutputParentPathTextBox.Location = New System.Drawing.Point(260, 34)
        Me.OutputParentPathTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OutputParentPathTextBox.Name = "OutputParentPathTextBox"
        Me.OutputParentPathTextBox.ReadOnly = True
        Me.OutputParentPathTextBox.Size = New System.Drawing.Size(502, 22)
        Me.OutputParentPathTextBox.TabIndex = 24
        Me.OutputParentPathTextBox.Visible = False
        '
        'OutputPathComboBox
        '
        Me.OutputPathComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutputPathComboBox.FormattingEnabled = True
        Me.OutputPathComboBox.Location = New System.Drawing.Point(90, 36)
        Me.OutputPathComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OutputPathComboBox.Name = "OutputPathComboBox"
        Me.OutputPathComboBox.Size = New System.Drawing.Size(163, 22)
        Me.OutputPathComboBox.TabIndex = 23
        '
        'InputComboBox
        '
        Me.InputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InputComboBox.FormattingEnabled = True
        Me.InputComboBox.Location = New System.Drawing.Point(90, 4)
        Me.InputComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.InputComboBox.Name = "InputComboBox"
        Me.InputComboBox.Size = New System.Drawing.Size(163, 22)
        Me.InputComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "输出到:"
        '
        'GotoInputPathButton
        '
        Me.GotoInputPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoInputPathButton.Location = New System.Drawing.Point(852, 3)
        Me.GotoInputPathButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GotoInputPathButton.Name = "GotoInputPathButton"
        Me.GotoInputPathButton.Size = New System.Drawing.Size(50, 25)
        Me.GotoInputPathButton.TabIndex = 21
        Me.GotoInputPathButton.Text = "前往"
        Me.GotoInputPathButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "源文件夹:"
        '
        'InputPathFileNameTextBox
        '
        Me.InputPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputPathFileNameTextBox.CueBannerText = ""
        Me.InputPathFileNameTextBox.Location = New System.Drawing.Point(260, 3)
        Me.InputPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.InputPathFileNameTextBox.Name = "InputPathFileNameTextBox"
        Me.InputPathFileNameTextBox.Size = New System.Drawing.Size(502, 22)
        Me.InputPathFileNameTextBox.TabIndex = 1
        '
        'BrowseForInputFolderOrFileNameButton
        '
        Me.BrowseForInputFolderOrFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForInputFolderOrFileNameButton.Location = New System.Drawing.Point(770, 3)
        Me.BrowseForInputFolderOrFileNameButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrowseForInputFolderOrFileNameButton.Name = "BrowseForInputFolderOrFileNameButton"
        Me.BrowseForInputFolderOrFileNameButton.Size = New System.Drawing.Size(75, 25)
        Me.BrowseForInputFolderOrFileNameButton.TabIndex = 20
        Me.BrowseForInputFolderOrFileNameButton.Text = "浏览..."
        Me.BrowseForInputFolderOrFileNameButton.UseVisualStyleBackColor = True
        '
        'Options_LogSplitContainer
        '
        Me.Options_LogSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Options_LogSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Options_LogSplitContainer.Location = New System.Drawing.Point(4, 66)
        Me.Options_LogSplitContainer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Options_LogSplitContainer.Name = "Options_LogSplitContainer"
        Me.Options_LogSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Options_LogSplitContainer.Panel1
        '
        Me.Options_LogSplitContainer.Panel1.Controls.Add(Me.OptionsGroupBox)
        Me.Options_LogSplitContainer.Panel1MinSize = 45
        '
        'Options_LogSplitContainer.Panel2
        '
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.LogRichTextBox)
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.PackButtonsPanel)
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.PostPackPanel)
        Me.Options_LogSplitContainer.Panel2MinSize = 45
        Me.Options_LogSplitContainer.Size = New System.Drawing.Size(898, 508)
        Me.Options_LogSplitContainer.SplitterDistance = 260
        Me.Options_LogSplitContainer.TabIndex = 29
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Controls.Add(Me.OptionsGroupBoxFillPanel)
        Me.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.OptionsGroupBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptionsGroupBox.Size = New System.Drawing.Size(898, 260)
        Me.OptionsGroupBox.TabIndex = 0
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "选项"
        '
        'OptionsGroupBoxFillPanel
        '
        Me.OptionsGroupBoxFillPanel.AutoScroll = True
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.PackerOptionsPanel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.DirectPackerOptionsLabel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.DirectPackerOptionsTextBox)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.PackerOptionsTextBox)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.PackerOptionsTextBoxMinScrollPanel)
        Me.OptionsGroupBoxFillPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsGroupBoxFillPanel.Location = New System.Drawing.Point(4, 18)
        Me.OptionsGroupBoxFillPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OptionsGroupBoxFillPanel.Name = "OptionsGroupBoxFillPanel"
        Me.OptionsGroupBoxFillPanel.Size = New System.Drawing.Size(890, 239)
        Me.OptionsGroupBoxFillPanel.TabIndex = 19
        '
        'PackerOptionsPanel
        '
        Me.PackerOptionsPanel.AutoScroll = True
        Me.PackerOptionsPanel.Controls.Add(Me.IgnoreWhitelistWarningsCheckBox)
        Me.PackerOptionsPanel.Controls.Add(Me.MultiFileVpkCheckBox)
        Me.PackerOptionsPanel.Controls.Add(Me.PackOptionsUseDefaultsButton)
        Me.PackerOptionsPanel.Controls.Add(Me.LogFileCheckBox)
        Me.PackerOptionsPanel.Controls.Add(Me.Label3)
        Me.PackerOptionsPanel.Controls.Add(Me.GameSetupComboBox)
        Me.PackerOptionsPanel.Controls.Add(Me.SetUpGamesButton)
        Me.PackerOptionsPanel.Controls.Add(Me.GmaPanel)
        Me.PackerOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PackerOptionsPanel.Location = New System.Drawing.Point(0, 0)
        Me.PackerOptionsPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackerOptionsPanel.Name = "PackerOptionsPanel"
        Me.PackerOptionsPanel.Size = New System.Drawing.Size(891, 165)
        Me.PackerOptionsPanel.TabIndex = 0
        '
        'IgnoreWhitelistWarningsCheckBox
        '
        Me.IgnoreWhitelistWarningsCheckBox.AutoSize = True
        Me.IgnoreWhitelistWarningsCheckBox.Location = New System.Drawing.Point(7, 55)
        Me.IgnoreWhitelistWarningsCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.IgnoreWhitelistWarningsCheckBox.Name = "IgnoreWhitelistWarningsCheckBox"
        Me.IgnoreWhitelistWarningsCheckBox.Size = New System.Drawing.Size(103, 18)
        Me.IgnoreWhitelistWarningsCheckBox.TabIndex = 16
        Me.IgnoreWhitelistWarningsCheckBox.Text = "忽略白名单警告"
        Me.IgnoreWhitelistWarningsCheckBox.UseVisualStyleBackColor = True
        Me.IgnoreWhitelistWarningsCheckBox.Visible = False
        '
        'MultiFileVpkCheckBox
        '
        Me.MultiFileVpkCheckBox.AutoSize = True
        Me.MultiFileVpkCheckBox.Location = New System.Drawing.Point(7, 55)
        Me.MultiFileVpkCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MultiFileVpkCheckBox.Name = "MultiFileVpkCheckBox"
        Me.MultiFileVpkCheckBox.Size = New System.Drawing.Size(113, 18)
        Me.MultiFileVpkCheckBox.TabIndex = 13
        Me.MultiFileVpkCheckBox.Text = "写入多个VPK文件"
        Me.MultiFileVpkCheckBox.UseVisualStyleBackColor = True
        Me.MultiFileVpkCheckBox.Visible = False
        '
        'PackOptionsUseDefaultsButton
        '
        Me.PackOptionsUseDefaultsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackOptionsUseDefaultsButton.Location = New System.Drawing.Point(786, 137)
        Me.PackOptionsUseDefaultsButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackOptionsUseDefaultsButton.Name = "PackOptionsUseDefaultsButton"
        Me.PackOptionsUseDefaultsButton.Size = New System.Drawing.Size(105, 25)
        Me.PackOptionsUseDefaultsButton.TabIndex = 12
        Me.PackOptionsUseDefaultsButton.Text = "重置选项"
        Me.PackOptionsUseDefaultsButton.UseVisualStyleBackColor = True
        '
        'LogFileCheckBox
        '
        Me.LogFileCheckBox.AutoSize = True
        Me.LogFileCheckBox.Location = New System.Drawing.Point(7, 30)
        Me.LogFileCheckBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LogFileCheckBox.Name = "LogFileCheckBox"
        Me.LogFileCheckBox.Size = New System.Drawing.Size(92, 18)
        Me.LogFileCheckBox.TabIndex = 4
        Me.LogFileCheckBox.Text = "输出打包日志"
        Me.LogFileCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "使用哪个游戏的打包工具:"
        '
        'GameSetupComboBox
        '
        Me.GameSetupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameSetupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GameSetupComboBox.FormattingEnabled = True
        Me.GameSetupComboBox.Location = New System.Drawing.Point(200, 1)
        Me.GameSetupComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GameSetupComboBox.Name = "GameSetupComboBox"
        Me.GameSetupComboBox.Size = New System.Drawing.Size(579, 22)
        Me.GameSetupComboBox.TabIndex = 1
        '
        'SetUpGamesButton
        '
        Me.SetUpGamesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetUpGamesButton.Location = New System.Drawing.Point(786, 0)
        Me.SetUpGamesButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SetUpGamesButton.Name = "SetUpGamesButton"
        Me.SetUpGamesButton.Size = New System.Drawing.Size(105, 25)
        Me.SetUpGamesButton.TabIndex = 2
        Me.SetUpGamesButton.Text = "游戏设置"
        Me.SetUpGamesButton.UseVisualStyleBackColor = True
        '
        'GmaPanel
        '
        Me.GmaPanel.Controls.Add(Me.GmaTitleTextBox)
        Me.GmaPanel.Controls.Add(Me.GmaTitleLabel)
        Me.GmaPanel.Controls.Add(Me.GmaGarrysModTagsUserControl)
        Me.GmaPanel.Location = New System.Drawing.Point(253, 31)
        Me.GmaPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GmaPanel.Name = "GmaPanel"
        Me.GmaPanel.Size = New System.Drawing.Size(493, 131)
        Me.GmaPanel.TabIndex = 0
        '
        'GmaTitleTextBox
        '
        Me.GmaTitleTextBox.CueBannerText = ""
        Me.GmaTitleTextBox.Location = New System.Drawing.Point(49, 1)
        Me.GmaTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GmaTitleTextBox.Name = "GmaTitleTextBox"
        Me.GmaTitleTextBox.Size = New System.Drawing.Size(369, 22)
        Me.GmaTitleTextBox.TabIndex = 14
        '
        'GmaTitleLabel
        '
        Me.GmaTitleLabel.AutoSize = True
        Me.GmaTitleLabel.Location = New System.Drawing.Point(4, 6)
        Me.GmaTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GmaTitleLabel.Name = "GmaTitleLabel"
        Me.GmaTitleLabel.Size = New System.Drawing.Size(32, 14)
        Me.GmaTitleLabel.TabIndex = 4
        Me.GmaTitleLabel.Text = "标题:"
        '
        'GmaGarrysModTagsUserControl
        '
        Me.GmaGarrysModTagsUserControl.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GmaGarrysModTagsUserControl.Location = New System.Drawing.Point(0, 30)
        Me.GmaGarrysModTagsUserControl.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GmaGarrysModTagsUserControl.Name = "GmaGarrysModTagsUserControl"
        Me.GmaGarrysModTagsUserControl.Orientation = Crowbar.AppEnums.OrientationType.Horizontal
        Me.GmaGarrysModTagsUserControl.Size = New System.Drawing.Size(422, 101)
        Me.GmaGarrysModTagsUserControl.TabIndex = 15
        '
        'DirectPackerOptionsLabel
        '
        Me.DirectPackerOptionsLabel.Location = New System.Drawing.Point(0, 166)
        Me.DirectPackerOptionsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DirectPackerOptionsLabel.Name = "DirectPackerOptionsLabel"
        Me.DirectPackerOptionsLabel.Size = New System.Drawing.Size(891, 14)
        Me.DirectPackerOptionsLabel.TabIndex = 16
        Me.DirectPackerOptionsLabel.Text = "直接输入命令行选项(以防上述选项未包含):"
        '
        'DirectPackerOptionsTextBox
        '
        Me.DirectPackerOptionsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectPackerOptionsTextBox.Location = New System.Drawing.Point(0, 183)
        Me.DirectPackerOptionsTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DirectPackerOptionsTextBox.Name = "DirectPackerOptionsTextBox"
        Me.DirectPackerOptionsTextBox.Size = New System.Drawing.Size(891, 22)
        Me.DirectPackerOptionsTextBox.TabIndex = 17
        '
        'PackerOptionsTextBox
        '
        Me.PackerOptionsTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackerOptionsTextBox.Location = New System.Drawing.Point(0, 213)
        Me.PackerOptionsTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackerOptionsTextBox.Multiline = True
        Me.PackerOptionsTextBox.Name = "PackerOptionsTextBox"
        Me.PackerOptionsTextBox.ReadOnly = True
        Me.PackerOptionsTextBox.Size = New System.Drawing.Size(891, 36)
        Me.PackerOptionsTextBox.TabIndex = 18
        '
        'PackerOptionsTextBoxMinScrollPanel
        '
        Me.PackerOptionsTextBoxMinScrollPanel.Location = New System.Drawing.Point(0, 213)
        Me.PackerOptionsTextBoxMinScrollPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackerOptionsTextBoxMinScrollPanel.Name = "PackerOptionsTextBoxMinScrollPanel"
        Me.PackerOptionsTextBoxMinScrollPanel.Size = New System.Drawing.Size(891, 40)
        Me.PackerOptionsTextBoxMinScrollPanel.TabIndex = 42
        '
        'LogRichTextBox
        '
        Me.LogRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogRichTextBox.CueBannerText = ""
        Me.LogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogRichTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogRichTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LogRichTextBox.HideSelection = False
        Me.LogRichTextBox.Location = New System.Drawing.Point(0, 28)
        Me.LogRichTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LogRichTextBox.Name = "LogRichTextBox"
        Me.LogRichTextBox.ReadOnly = True
        Me.LogRichTextBox.Size = New System.Drawing.Size(898, 188)
        Me.LogRichTextBox.TabIndex = 0
        Me.LogRichTextBox.Text = ""
        Me.LogRichTextBox.WordWrap = False
        '
        'PackButtonsPanel
        '
        Me.PackButtonsPanel.Controls.Add(Me.PackButton)
        Me.PackButtonsPanel.Controls.Add(Me.SkipCurrentFolderButton)
        Me.PackButtonsPanel.Controls.Add(Me.CancelPackButton)
        Me.PackButtonsPanel.Controls.Add(Me.UseAllInPublishButton)
        Me.PackButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PackButtonsPanel.Location = New System.Drawing.Point(0, 0)
        Me.PackButtonsPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackButtonsPanel.Name = "PackButtonsPanel"
        Me.PackButtonsPanel.Size = New System.Drawing.Size(898, 28)
        Me.PackButtonsPanel.TabIndex = 5
        '
        'PackButton
        '
        Me.PackButton.Location = New System.Drawing.Point(0, 0)
        Me.PackButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackButton.Name = "PackButton"
        Me.PackButton.Size = New System.Drawing.Size(140, 25)
        Me.PackButton.TabIndex = 1
        Me.PackButton.Text = "打包"
        Me.PackButton.UseVisualStyleBackColor = True
        '
        'SkipCurrentFolderButton
        '
        Me.SkipCurrentFolderButton.Enabled = False
        Me.SkipCurrentFolderButton.Location = New System.Drawing.Point(147, 0)
        Me.SkipCurrentFolderButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SkipCurrentFolderButton.Name = "SkipCurrentFolderButton"
        Me.SkipCurrentFolderButton.Size = New System.Drawing.Size(140, 25)
        Me.SkipCurrentFolderButton.TabIndex = 2
        Me.SkipCurrentFolderButton.Text = "跳过当前文件夹"
        Me.SkipCurrentFolderButton.UseVisualStyleBackColor = True
        '
        'CancelPackButton
        '
        Me.CancelPackButton.Enabled = False
        Me.CancelPackButton.Location = New System.Drawing.Point(294, 0)
        Me.CancelPackButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CancelPackButton.Name = "CancelPackButton"
        Me.CancelPackButton.Size = New System.Drawing.Size(140, 25)
        Me.CancelPackButton.TabIndex = 3
        Me.CancelPackButton.Text = "取消打包"
        Me.CancelPackButton.UseVisualStyleBackColor = True
        '
        'UseAllInPublishButton
        '
        Me.UseAllInPublishButton.Enabled = False
        Me.UseAllInPublishButton.Location = New System.Drawing.Point(441, 0)
        Me.UseAllInPublishButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UseAllInPublishButton.Name = "UseAllInPublishButton"
        Me.UseAllInPublishButton.Size = New System.Drawing.Size(140, 25)
        Me.UseAllInPublishButton.TabIndex = 4
        Me.UseAllInPublishButton.Text = "全部保存到发布页"
        Me.UseAllInPublishButton.UseVisualStyleBackColor = True
        Me.UseAllInPublishButton.Visible = False
        '
        'PostPackPanel
        '
        Me.PostPackPanel.Controls.Add(Me.PackedFilesComboBox)
        Me.PostPackPanel.Controls.Add(Me.UseInPublishButton)
        Me.PostPackPanel.Controls.Add(Me.GotoPackedFileButton)
        Me.PostPackPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PostPackPanel.Location = New System.Drawing.Point(0, 216)
        Me.PostPackPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PostPackPanel.Name = "PostPackPanel"
        Me.PostPackPanel.Size = New System.Drawing.Size(898, 28)
        Me.PostPackPanel.TabIndex = 6
        '
        'PackedFilesComboBox
        '
        Me.PackedFilesComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackedFilesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PackedFilesComboBox.FormattingEnabled = True
        Me.PackedFilesComboBox.Location = New System.Drawing.Point(0, 4)
        Me.PackedFilesComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PackedFilesComboBox.Name = "PackedFilesComboBox"
        Me.PackedFilesComboBox.Size = New System.Drawing.Size(840, 22)
        Me.PackedFilesComboBox.TabIndex = 1
        '
        'UseInPublishButton
        '
        Me.UseInPublishButton.Enabled = False
        Me.UseInPublishButton.Location = New System.Drawing.Point(737, 3)
        Me.UseInPublishButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UseInPublishButton.Name = "UseInPublishButton"
        Me.UseInPublishButton.Size = New System.Drawing.Size(104, 25)
        Me.UseInPublishButton.TabIndex = 3
        Me.UseInPublishButton.Text = "转到发布页"
        Me.UseInPublishButton.UseVisualStyleBackColor = True
        Me.UseInPublishButton.Visible = False
        '
        'GotoPackedFileButton
        '
        Me.GotoPackedFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoPackedFileButton.Location = New System.Drawing.Point(848, 3)
        Me.GotoPackedFileButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GotoPackedFileButton.Name = "GotoPackedFileButton"
        Me.GotoPackedFileButton.Size = New System.Drawing.Size(50, 25)
        Me.GotoPackedFileButton.TabIndex = 4
        Me.GotoPackedFileButton.Text = "前往"
        Me.GotoPackedFileButton.UseVisualStyleBackColor = True
        '
        'PackUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PackUserControl"
        Me.Size = New System.Drawing.Size(905, 577)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Options_LogSplitContainer.Panel1.ResumeLayout(False)
        Me.Options_LogSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.Options_LogSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Options_LogSplitContainer.ResumeLayout(False)
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.OptionsGroupBoxFillPanel.ResumeLayout(False)
        Me.OptionsGroupBoxFillPanel.PerformLayout()
        Me.PackerOptionsPanel.ResumeLayout(False)
        Me.PackerOptionsPanel.PerformLayout()
        Me.GmaPanel.ResumeLayout(False)
        Me.GmaPanel.PerformLayout()
        Me.PackButtonsPanel.ResumeLayout(False)
        Me.PostPackPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents OutputParentPathTextBox As Crowbar.TextBoxEx
	Friend WithEvents GotoOutputPathButton As System.Windows.Forms.Button
	Friend WithEvents BrowseForOutputPathButton As System.Windows.Forms.Button
	Friend WithEvents OutputPathTextBox As Crowbar.TextBoxEx
	Friend WithEvents OutputPathComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents InputComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GotoInputPathButton As System.Windows.Forms.Button
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents InputPathFileNameTextBox As Crowbar.TextBoxEx
	Friend WithEvents BrowseForInputFolderOrFileNameButton As System.Windows.Forms.Button
	Friend WithEvents Options_LogSplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents UseAllInPublishButton As System.Windows.Forms.Button
	Friend WithEvents OptionsGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents PackerOptionsPanel As System.Windows.Forms.Panel
	Friend WithEvents PackOptionsUseDefaultsButton As System.Windows.Forms.Button
	Friend WithEvents LogFileCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents GameSetupComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents SetUpGamesButton As System.Windows.Forms.Button
	Friend WithEvents CancelPackButton As System.Windows.Forms.Button
	Friend WithEvents SkipCurrentFolderButton As System.Windows.Forms.Button
	Friend WithEvents PackButton As System.Windows.Forms.Button
	Friend WithEvents UseInPublishButton As System.Windows.Forms.Button
	Friend WithEvents LogRichTextBox As Crowbar.RichTextBoxEx
	Friend WithEvents PackedFilesComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents GotoPackedFileButton As System.Windows.Forms.Button
	Friend WithEvents DirectPackerOptionsLabel As Label
	Friend WithEvents DirectPackerOptionsTextBox As TextBox
	Friend WithEvents PackerOptionsTextBox As TextBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents MultiFileVpkCheckBox As CheckBox
	Friend WithEvents PackButtonsPanel As Panel
	Friend WithEvents PostPackPanel As Panel
	Friend WithEvents OptionsGroupBoxFillPanel As Panel
	Friend WithEvents PackerOptionsTextBoxMinScrollPanel As Panel
	Friend WithEvents GmaTitleLabel As Label
	Friend WithEvents GmaTitleTextBox As TextBoxEx
	Friend WithEvents GmaGarrysModTagsUserControl As GarrysModTagsUserControl
	Friend WithEvents GmaPanel As Panel
	Friend WithEvents IgnoreWhitelistWarningsCheckBox As CheckBox
End Class
