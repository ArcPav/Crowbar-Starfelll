<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PublishUserControl
	Inherits BaseUserControl

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PublishUserControl))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RefreshGameItemsButton = New System.Windows.Forms.Button()
        Me.ItemOwnerLabel = New System.Windows.Forms.Label()
        Me.ItemPostedTextBox = New Crowbar.DateTimeTextBoxEx()
        Me.ItemUpdatedTextBox = New Crowbar.DateTimeTextBoxEx()
        Me.QuotaProgressBar = New Crowbar.ProgressBarEx()
        Me.TopMiddleSplitContainer = New Crowbar.SplitContainerEx()
        Me.ExplanationTextBox = New Crowbar.TextBoxEx()
        Me.ItemsPanel = New System.Windows.Forms.Panel()
        Me.ItemsDataGridView = New Crowbar.DataGridViewEx()
        Me.ItemListToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AddItemToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchItemsToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.SearchItemsToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchItemsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItemCountsToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FindItemToolStripTextBox = New Crowbar.ToolStripSpringTextBox()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.GameLabel = New System.Windows.Forms.Label()
        Me.AppIdComboBox = New System.Windows.Forms.ComboBox()
        Me.PublishRequiresSteamLabel = New System.Windows.Forms.Label()
        Me.OpenSteamSubscriberAgreementButton = New System.Windows.Forms.Button()
        Me.MiddleBottomSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ItemGroupBox = New Crowbar.GroupBoxEx()
        Me.ItemTagsSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.DescriptionChangeNoteSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ItemDescriptionTextBox = New Crowbar.RichTextBoxEx()
        Me.ItemDescriptionTopPanel = New System.Windows.Forms.Panel()
        Me.ToggleWordWrapForDescriptionCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItemDescriptionLabel = New System.Windows.Forms.Label()
        Me.ItemChangeNoteTextBox = New Crowbar.RichTextBoxEx()
        Me.ItemChangeNoteTopPanel = New System.Windows.Forms.Panel()
        Me.ToggleWordWrapForChangeNotePanel = New System.Windows.Forms.Panel()
        Me.ToggleWordWrapForChangeNoteCheckBox = New System.Windows.Forms.CheckBox()
        Me.ItemChangeNoteLabel = New System.Windows.Forms.Label()
        Me.ItemTopPanel = New System.Windows.Forms.Panel()
        Me.ItemIDLabel = New System.Windows.Forms.Label()
        Me.ItemIDTextBox = New Crowbar.TextBoxEx()
        Me.ItemOwnerTextBox = New Crowbar.TextBoxEx()
        Me.ItemTitleLabel = New System.Windows.Forms.Label()
        Me.ItemTitleTextBox = New Crowbar.TextBoxEx()
        Me.ItemBottomPanel = New System.Windows.Forms.Panel()
        Me.ItemContentFolderOrFileLabel = New System.Windows.Forms.Label()
        Me.ItemContentPathFileNameTextBox = New Crowbar.TextBoxEx()
        Me.BrowseItemContentPathFileNameButton = New System.Windows.Forms.Button()
        Me.ItemPreviewImageLabel = New System.Windows.Forms.Label()
        Me.ItemPreviewImagePathFileNameTextBox = New Crowbar.TextBoxEx()
        Me.BrowseItemPreviewImagePathFileNameButton = New System.Windows.Forms.Button()
        Me.ItemPreviewImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ItemVisibilityComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemVisibilityLabel = New System.Windows.Forms.Label()
        Me.SaveAsTemplateOrDraftItemButton = New System.Windows.Forms.Button()
        Me.RefreshOrRevertItemButton = New System.Windows.Forms.Button()
        Me.SaveTemplateButton = New System.Windows.Forms.Button()
        Me.OpenWorkshopPageButton = New System.Windows.Forms.Button()
        Me.DeleteItemButton = New System.Windows.Forms.Button()
        Me.ItemLeftMinScrollPanel = New System.Windows.Forms.Panel()
        Me.ItemTagsGroupBox = New Crowbar.GroupBoxEx()
        Me.LogTextBox = New Crowbar.RichTextBoxEx()
        Me.PublishItemButton = New System.Windows.Forms.Button()
        Me.QueueListView = New System.Windows.Forms.ListView()
        CType(Me.TopMiddleSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMiddleSplitContainer.Panel1.SuspendLayout()
        Me.TopMiddleSplitContainer.Panel2.SuspendLayout()
        Me.TopMiddleSplitContainer.SuspendLayout()
        Me.ItemsPanel.SuspendLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemListToolStrip.SuspendLayout()
        Me.GamePanel.SuspendLayout()
        CType(Me.MiddleBottomSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiddleBottomSplitContainer.Panel1.SuspendLayout()
        Me.MiddleBottomSplitContainer.Panel2.SuspendLayout()
        Me.MiddleBottomSplitContainer.SuspendLayout()
        Me.ItemGroupBox.SuspendLayout()
        CType(Me.ItemTagsSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemTagsSplitContainer.Panel1.SuspendLayout()
        Me.ItemTagsSplitContainer.Panel2.SuspendLayout()
        Me.ItemTagsSplitContainer.SuspendLayout()
        CType(Me.DescriptionChangeNoteSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescriptionChangeNoteSplitContainer.Panel1.SuspendLayout()
        Me.DescriptionChangeNoteSplitContainer.Panel2.SuspendLayout()
        Me.DescriptionChangeNoteSplitContainer.SuspendLayout()
        Me.ItemDescriptionTopPanel.SuspendLayout()
        Me.ItemChangeNoteTopPanel.SuspendLayout()
        Me.ToggleWordWrapForChangeNotePanel.SuspendLayout()
        Me.ItemTopPanel.SuspendLayout()
        Me.ItemBottomPanel.SuspendLayout()
        CType(Me.ItemPreviewImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RefreshGameItemsButton
        '
        Me.RefreshGameItemsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshGameItemsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RefreshGameItemsButton.FlatAppearance.BorderSize = 0
        Me.RefreshGameItemsButton.Image = Global.Crowbar.My.Resources.Resources.Refresh
        Me.RefreshGameItemsButton.Location = New System.Drawing.Point(525, 4)
        Me.RefreshGameItemsButton.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.RefreshGameItemsButton.Name = "RefreshGameItemsButton"
        Me.RefreshGameItemsButton.Padding = New System.Windows.Forms.Padding(0, 0, 1, 3)
        Me.RefreshGameItemsButton.Size = New System.Drawing.Size(31, 30)
        Me.RefreshGameItemsButton.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.RefreshGameItemsButton, "刷新物品")
        Me.RefreshGameItemsButton.UseVisualStyleBackColor = True
        '
        'ItemOwnerLabel
        '
        Me.ItemOwnerLabel.AutoSize = True
        Me.ItemOwnerLabel.Location = New System.Drawing.Point(200, 6)
        Me.ItemOwnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemOwnerLabel.Name = "ItemOwnerLabel"
        Me.ItemOwnerLabel.Size = New System.Drawing.Size(54, 18)
        Me.ItemOwnerLabel.TabIndex = 35
        Me.ItemOwnerLabel.Text = "所有者:"
        Me.ToolTip1.SetToolTip(Me.ItemOwnerLabel, "双击可在Steam名称和SteamID之间切换.")
        '
        'ItemPostedTextBox
        '
        Me.ItemPostedTextBox.CueBannerText = ""
        Me.ItemPostedTextBox.Location = New System.Drawing.Point(445, 0)
        Me.ItemPostedTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemPostedTextBox.Name = "ItemPostedTextBox"
        Me.ItemPostedTextBox.ReadOnly = True
        Me.ItemPostedTextBox.Size = New System.Drawing.Size(159, 25)
        Me.ItemPostedTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ItemPostedTextBox, "发布时间")
        '
        'ItemUpdatedTextBox
        '
        Me.ItemUpdatedTextBox.CueBannerText = ""
        Me.ItemUpdatedTextBox.Location = New System.Drawing.Point(613, 0)
        Me.ItemUpdatedTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemUpdatedTextBox.Name = "ItemUpdatedTextBox"
        Me.ItemUpdatedTextBox.ReadOnly = True
        Me.ItemUpdatedTextBox.Size = New System.Drawing.Size(159, 25)
        Me.ItemUpdatedTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ItemUpdatedTextBox, "更新时间")
        '
        'QuotaProgressBar
        '
        Me.QuotaProgressBar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QuotaProgressBar.Location = New System.Drawing.Point(4, 43)
        Me.QuotaProgressBar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.QuotaProgressBar.Name = "QuotaProgressBar"
        Me.QuotaProgressBar.Size = New System.Drawing.Size(167, 30)
        Me.QuotaProgressBar.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.QuotaProgressBar, "配额")
        '
        'TopMiddleSplitContainer
        '
        Me.TopMiddleSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopMiddleSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.TopMiddleSplitContainer.Name = "TopMiddleSplitContainer"
        Me.TopMiddleSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'TopMiddleSplitContainer.Panel1
        '
        Me.TopMiddleSplitContainer.Panel1.Controls.Add(Me.ExplanationTextBox)
        Me.TopMiddleSplitContainer.Panel1.Controls.Add(Me.ItemsPanel)
        Me.TopMiddleSplitContainer.Panel1.Controls.Add(Me.GamePanel)
        Me.TopMiddleSplitContainer.Panel1.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        '
        'TopMiddleSplitContainer.Panel2
        '
        Me.TopMiddleSplitContainer.Panel2.AutoScroll = True
        Me.TopMiddleSplitContainer.Panel2.Controls.Add(Me.MiddleBottomSplitContainer)
        Me.TopMiddleSplitContainer.Size = New System.Drawing.Size(1027, 739)
        Me.TopMiddleSplitContainer.SplitterDistance = 192
        Me.TopMiddleSplitContainer.SplitterWidth = 6
        Me.TopMiddleSplitContainer.TabIndex = 28
        '
        'ExplanationTextBox
        '
        Me.ExplanationTextBox.CueBannerText = ""
        Me.ExplanationTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExplanationTextBox.Location = New System.Drawing.Point(4, 36)
        Me.ExplanationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ExplanationTextBox.Multiline = True
        Me.ExplanationTextBox.Name = "ExplanationTextBox"
        Me.ExplanationTextBox.ReadOnly = True
        Me.ExplanationTextBox.Size = New System.Drawing.Size(1019, 152)
        Me.ExplanationTextBox.TabIndex = 38
        Me.ExplanationTextBox.Text = "点击上方绿白相间的""刷新游戏项目""按钮开始 为什么不采用自动刷新？" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "防止在你想发布到其他游戏的创意工坊时 请求项目列表产生不必要的延迟"
        '
        'ItemsPanel
        '
        Me.ItemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemsPanel.Controls.Add(Me.ItemsDataGridView)
        Me.ItemsPanel.Controls.Add(Me.ItemListToolStrip)
        Me.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsPanel.Location = New System.Drawing.Point(4, 36)
        Me.ItemsPanel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemsPanel.Name = "ItemsPanel"
        Me.ItemsPanel.Size = New System.Drawing.Size(1019, 152)
        Me.ItemsPanel.TabIndex = 31
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AllowUserToAddRows = False
        Me.ItemsDataGridView.AllowUserToDeleteRows = False
        Me.ItemsDataGridView.AllowUserToOrderColumns = True
        Me.ItemsDataGridView.AllowUserToResizeRows = False
        Me.ItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Maple UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ItemsDataGridView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemsDataGridView.MultiSelect = False
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.ReadOnly = True
        Me.ItemsDataGridView.RowHeadersVisible = False
        Me.ItemsDataGridView.RowHeadersWidth = 51
        Me.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsDataGridView.ShowCellErrors = False
        Me.ItemsDataGridView.ShowRowErrors = False
        Me.ItemsDataGridView.Size = New System.Drawing.Size(1015, 118)
        Me.ItemsDataGridView.TabIndex = 3
        '
        'ItemListToolStrip
        '
        Me.ItemListToolStrip.CanOverflow = False
        Me.ItemListToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ItemListToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ItemListToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ItemListToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripButton, Me.ToolStripSeparator1, Me.SearchItemsToolStripComboBox, Me.SearchItemsToolStripTextBox, Me.SearchItemsToolStripButton, Me.ToolStripSeparator2, Me.ItemCountsToolStripLabel, Me.FindItemToolStripTextBox})
        Me.ItemListToolStrip.Location = New System.Drawing.Point(0, 118)
        Me.ItemListToolStrip.Name = "ItemListToolStrip"
        Me.ItemListToolStrip.Size = New System.Drawing.Size(1015, 30)
        Me.ItemListToolStrip.Stretch = True
        Me.ItemListToolStrip.TabIndex = 30
        Me.ItemListToolStrip.Text = "工具栏1"
        '
        'AddItemToolStripButton
        '
        Me.AddItemToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddItemToolStripButton.Image = CType(resources.GetObject("AddItemToolStripButton.Image"), System.Drawing.Image)
        Me.AddItemToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddItemToolStripButton.Name = "AddItemToolStripButton"
        Me.AddItemToolStripButton.Size = New System.Drawing.Size(82, 27)
        Me.AddItemToolStripButton.Text = "添加物品"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'SearchItemsToolStripComboBox
        '
        Me.SearchItemsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchItemsToolStripComboBox.Items.AddRange(New Object() {"ID:", "Title:", "Description:", "Owner:", "[All fields]:"})
        Me.SearchItemsToolStripComboBox.Name = "SearchItemsToolStripComboBox"
        Me.SearchItemsToolStripComboBox.Size = New System.Drawing.Size(105, 30)
        Me.SearchItemsToolStripComboBox.ToolTipText = "搜索字段"
        '
        'SearchItemsToolStripTextBox
        '
        Me.SearchItemsToolStripTextBox.Font = New System.Drawing.Font("Maple UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SearchItemsToolStripTextBox.Name = "SearchItemsToolStripTextBox"
        Me.SearchItemsToolStripTextBox.Size = New System.Drawing.Size(132, 30)
        Me.SearchItemsToolStripTextBox.ToolTipText = "搜索文本"
        '
        'SearchItemsToolStripButton
        '
        Me.SearchItemsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchItemsToolStripButton.Image = Global.Crowbar.My.Resources.Resources.Find
        Me.SearchItemsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchItemsToolStripButton.Name = "SearchItemsToolStripButton"
        Me.SearchItemsToolStripButton.Size = New System.Drawing.Size(29, 27)
        Me.SearchItemsToolStripButton.Text = "搜索"
        Me.SearchItemsToolStripButton.ToolTipText = "搜索"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ItemCountsToolStripLabel
        '
        Me.ItemCountsToolStripLabel.Name = "ItemCountsToolStripLabel"
        Me.ItemCountsToolStripLabel.Size = New System.Drawing.Size(207, 27)
        Me.ItemCountsToolStripLabel.Text = "0 草稿 + 0 已发布 = 0 总计"
        '
        'FindItemToolStripTextBox
        '
        Me.FindItemToolStripTextBox.Font = New System.Drawing.Font("Maple UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FindItemToolStripTextBox.Name = "FindItemToolStripTextBox"
        Me.FindItemToolStripTextBox.Size = New System.Drawing.Size(402, 30)
        Me.FindItemToolStripTextBox.ToolTipText = "查找标题"
        Me.FindItemToolStripTextBox.Visible = False
        '
        'GamePanel
        '
        Me.GamePanel.Controls.Add(Me.GameLabel)
        Me.GamePanel.Controls.Add(Me.AppIdComboBox)
        Me.GamePanel.Controls.Add(Me.RefreshGameItemsButton)
        Me.GamePanel.Controls.Add(Me.PublishRequiresSteamLabel)
        Me.GamePanel.Controls.Add(Me.OpenSteamSubscriberAgreementButton)
        Me.GamePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GamePanel.Location = New System.Drawing.Point(4, 0)
        Me.GamePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(1019, 36)
        Me.GamePanel.TabIndex = 37
        '
        'GameLabel
        '
        Me.GameLabel.AutoSize = True
        Me.GameLabel.Location = New System.Drawing.Point(3, 10)
        Me.GameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameLabel.Name = "GameLabel"
        Me.GameLabel.Size = New System.Drawing.Size(40, 18)
        Me.GameLabel.TabIndex = 22
        Me.GameLabel.Text = "游戏:"
        '
        'AppIdComboBox
        '
        Me.AppIdComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppIdComboBox.FormattingEnabled = True
        Me.AppIdComboBox.Location = New System.Drawing.Point(60, 4)
        Me.AppIdComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.AppIdComboBox.Name = "AppIdComboBox"
        Me.AppIdComboBox.Size = New System.Drawing.Size(464, 26)
        Me.AppIdComboBox.TabIndex = 0
        '
        'PublishRequiresSteamLabel
        '
        Me.PublishRequiresSteamLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublishRequiresSteamLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PublishRequiresSteamLabel.Location = New System.Drawing.Point(574, 8)
        Me.PublishRequiresSteamLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PublishRequiresSteamLabel.Name = "PublishRequiresSteamLabel"
        Me.PublishRequiresSteamLabel.Size = New System.Drawing.Size(181, 28)
        Me.PublishRequiresSteamLabel.TabIndex = 1
        Me.PublishRequiresSteamLabel.Text = "发布需要启动Steam"
        Me.PublishRequiresSteamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenSteamSubscriberAgreementButton
        '
        Me.OpenSteamSubscriberAgreementButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenSteamSubscriberAgreementButton.Location = New System.Drawing.Point(753, 4)
        Me.OpenSteamSubscriberAgreementButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OpenSteamSubscriberAgreementButton.Name = "OpenSteamSubscriberAgreementButton"
        Me.OpenSteamSubscriberAgreementButton.Size = New System.Drawing.Size(265, 30)
        Me.OpenSteamSubscriberAgreementButton.TabIndex = 2
        Me.OpenSteamSubscriberAgreementButton.Text = "查看Steam订户协议"
        Me.OpenSteamSubscriberAgreementButton.UseVisualStyleBackColor = True
        '
        'MiddleBottomSplitContainer
        '
        Me.MiddleBottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiddleBottomSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.MiddleBottomSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MiddleBottomSplitContainer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MiddleBottomSplitContainer.Name = "MiddleBottomSplitContainer"
        Me.MiddleBottomSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MiddleBottomSplitContainer.Panel1
        '
        Me.MiddleBottomSplitContainer.Panel1.Controls.Add(Me.ItemGroupBox)
        Me.MiddleBottomSplitContainer.Panel1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        '
        'MiddleBottomSplitContainer.Panel2
        '
        Me.MiddleBottomSplitContainer.Panel2.Controls.Add(Me.LogTextBox)
        Me.MiddleBottomSplitContainer.Panel2.Controls.Add(Me.QuotaProgressBar)
        Me.MiddleBottomSplitContainer.Panel2.Controls.Add(Me.PublishItemButton)
        Me.MiddleBottomSplitContainer.Panel2.Controls.Add(Me.QueueListView)
        Me.MiddleBottomSplitContainer.Panel2MinSize = 45
        Me.MiddleBottomSplitContainer.Size = New System.Drawing.Size(1027, 541)
        Me.MiddleBottomSplitContainer.SplitterDistance = 429
        Me.MiddleBottomSplitContainer.SplitterWidth = 6
        Me.MiddleBottomSplitContainer.TabIndex = 26
        '
        'ItemGroupBox
        '
        Me.ItemGroupBox.Controls.Add(Me.ItemTagsSplitContainer)
        Me.ItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemGroupBox.IsReadOnly = False
        Me.ItemGroupBox.Location = New System.Drawing.Point(4, 6)
        Me.ItemGroupBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemGroupBox.Name = "ItemGroupBox"
        Me.ItemGroupBox.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemGroupBox.SelectedValue = Nothing
        Me.ItemGroupBox.Size = New System.Drawing.Size(1019, 417)
        Me.ItemGroupBox.TabIndex = 31
        Me.ItemGroupBox.TabStop = False
        Me.ItemGroupBox.Text = "物品"
        '
        'ItemTagsSplitContainer
        '
        Me.ItemTagsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemTagsSplitContainer.Location = New System.Drawing.Point(4, 24)
        Me.ItemTagsSplitContainer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemTagsSplitContainer.Name = "ItemTagsSplitContainer"
        '
        'ItemTagsSplitContainer.Panel1
        '
        Me.ItemTagsSplitContainer.Panel1.AutoScroll = True
        Me.ItemTagsSplitContainer.Panel1.Controls.Add(Me.DescriptionChangeNoteSplitContainer)
        Me.ItemTagsSplitContainer.Panel1.Controls.Add(Me.ItemTopPanel)
        Me.ItemTagsSplitContainer.Panel1.Controls.Add(Me.ItemBottomPanel)
        Me.ItemTagsSplitContainer.Panel1.Controls.Add(Me.ItemLeftMinScrollPanel)
        '
        'ItemTagsSplitContainer.Panel2
        '
        Me.ItemTagsSplitContainer.Panel2.Controls.Add(Me.ItemTagsGroupBox)
        Me.ItemTagsSplitContainer.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 4, 6)
        Me.ItemTagsSplitContainer.Size = New System.Drawing.Size(1011, 387)
        Me.ItemTagsSplitContainer.SplitterDistance = 772
        Me.ItemTagsSplitContainer.TabIndex = 25
        '
        'DescriptionChangeNoteSplitContainer
        '
        Me.DescriptionChangeNoteSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescriptionChangeNoteSplitContainer.Location = New System.Drawing.Point(0, 94)
        Me.DescriptionChangeNoteSplitContainer.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DescriptionChangeNoteSplitContainer.Name = "DescriptionChangeNoteSplitContainer"
        '
        'DescriptionChangeNoteSplitContainer.Panel1
        '
        Me.DescriptionChangeNoteSplitContainer.Panel1.Controls.Add(Me.ItemDescriptionTextBox)
        Me.DescriptionChangeNoteSplitContainer.Panel1.Controls.Add(Me.ItemDescriptionTopPanel)
        Me.DescriptionChangeNoteSplitContainer.Panel1.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        '
        'DescriptionChangeNoteSplitContainer.Panel2
        '
        Me.DescriptionChangeNoteSplitContainer.Panel2.Controls.Add(Me.ItemChangeNoteTextBox)
        Me.DescriptionChangeNoteSplitContainer.Panel2.Controls.Add(Me.ItemChangeNoteTopPanel)
        Me.DescriptionChangeNoteSplitContainer.Size = New System.Drawing.Size(773, 148)
        Me.DescriptionChangeNoteSplitContainer.SplitterDistance = 393
        Me.DescriptionChangeNoteSplitContainer.SplitterWidth = 5
        Me.DescriptionChangeNoteSplitContainer.TabIndex = 5
        '
        'ItemDescriptionTextBox
        '
        Me.ItemDescriptionTextBox.AcceptsTab = True
        Me.ItemDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ItemDescriptionTextBox.CueBannerText = "*必填项"
        Me.ItemDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemDescriptionTextBox.Font = New System.Drawing.Font("Cascadia Mono", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ItemDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ItemDescriptionTextBox.Location = New System.Drawing.Point(4, 26)
        Me.ItemDescriptionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox"
        Me.ItemDescriptionTextBox.Size = New System.Drawing.Size(389, 122)
        Me.ItemDescriptionTextBox.TabIndex = 5
        Me.ItemDescriptionTextBox.Text = ""
        Me.ItemDescriptionTextBox.WordWrap = False
        '
        'ItemDescriptionTopPanel
        '
        Me.ItemDescriptionTopPanel.Controls.Add(Me.ToggleWordWrapForDescriptionCheckBox)
        Me.ItemDescriptionTopPanel.Controls.Add(Me.ItemDescriptionLabel)
        Me.ItemDescriptionTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemDescriptionTopPanel.Location = New System.Drawing.Point(4, 0)
        Me.ItemDescriptionTopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemDescriptionTopPanel.Name = "ItemDescriptionTopPanel"
        Me.ItemDescriptionTopPanel.Size = New System.Drawing.Size(389, 26)
        Me.ItemDescriptionTopPanel.TabIndex = 17
        '
        'ToggleWordWrapForDescriptionCheckBox
        '
        Me.ToggleWordWrapForDescriptionCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToggleWordWrapForDescriptionCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.ToggleWordWrapForDescriptionCheckBox.BackgroundImage = Global.Crowbar.My.Resources.Resources.WordWrapOff
        Me.ToggleWordWrapForDescriptionCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToggleWordWrapForDescriptionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ToggleWordWrapForDescriptionCheckBox.Location = New System.Drawing.Point(371, 6)
        Me.ToggleWordWrapForDescriptionCheckBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ToggleWordWrapForDescriptionCheckBox.Name = "ToggleWordWrapForDescriptionCheckBox"
        Me.ToggleWordWrapForDescriptionCheckBox.Size = New System.Drawing.Size(17, 18)
        Me.ToggleWordWrapForDescriptionCheckBox.TabIndex = 16
        Me.ToggleWordWrapForDescriptionCheckBox.UseVisualStyleBackColor = True
        '
        'ItemDescriptionLabel
        '
        Me.ItemDescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemDescriptionLabel.Location = New System.Drawing.Point(0, 6)
        Me.ItemDescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemDescriptionLabel.Name = "ItemDescriptionLabel"
        Me.ItemDescriptionLabel.Size = New System.Drawing.Size(367, 18)
        Me.ItemDescriptionLabel.TabIndex = 9
        Me.ItemDescriptionLabel.Text = "描述 (### / ### 最多字数):"
        '
        'ItemChangeNoteTextBox
        '
        Me.ItemChangeNoteTextBox.AcceptsTab = True
        Me.ItemChangeNoteTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ItemChangeNoteTextBox.CueBannerText = ""
        Me.ItemChangeNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemChangeNoteTextBox.Font = New System.Drawing.Font("Cascadia Mono", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ItemChangeNoteTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ItemChangeNoteTextBox.Location = New System.Drawing.Point(0, 26)
        Me.ItemChangeNoteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemChangeNoteTextBox.Name = "ItemChangeNoteTextBox"
        Me.ItemChangeNoteTextBox.Size = New System.Drawing.Size(375, 122)
        Me.ItemChangeNoteTextBox.TabIndex = 6
        Me.ItemChangeNoteTextBox.Text = ""
        Me.ItemChangeNoteTextBox.WordWrap = False
        '
        'ItemChangeNoteTopPanel
        '
        Me.ItemChangeNoteTopPanel.Controls.Add(Me.ToggleWordWrapForChangeNotePanel)
        Me.ItemChangeNoteTopPanel.Controls.Add(Me.ItemChangeNoteLabel)
        Me.ItemChangeNoteTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemChangeNoteTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemChangeNoteTopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemChangeNoteTopPanel.Name = "ItemChangeNoteTopPanel"
        Me.ItemChangeNoteTopPanel.Size = New System.Drawing.Size(375, 26)
        Me.ItemChangeNoteTopPanel.TabIndex = 18
        '
        'ToggleWordWrapForChangeNotePanel
        '
        Me.ToggleWordWrapForChangeNotePanel.Controls.Add(Me.ToggleWordWrapForChangeNoteCheckBox)
        Me.ToggleWordWrapForChangeNotePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToggleWordWrapForChangeNotePanel.Location = New System.Drawing.Point(356, 0)
        Me.ToggleWordWrapForChangeNotePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ToggleWordWrapForChangeNotePanel.Name = "ToggleWordWrapForChangeNotePanel"
        Me.ToggleWordWrapForChangeNotePanel.Size = New System.Drawing.Size(19, 26)
        Me.ToggleWordWrapForChangeNotePanel.TabIndex = 18
        '
        'ToggleWordWrapForChangeNoteCheckBox
        '
        Me.ToggleWordWrapForChangeNoteCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.ToggleWordWrapForChangeNoteCheckBox.BackgroundImage = Global.Crowbar.My.Resources.Resources.WordWrapOff
        Me.ToggleWordWrapForChangeNoteCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToggleWordWrapForChangeNoteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ToggleWordWrapForChangeNoteCheckBox.Location = New System.Drawing.Point(0, 6)
        Me.ToggleWordWrapForChangeNoteCheckBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ToggleWordWrapForChangeNoteCheckBox.Name = "ToggleWordWrapForChangeNoteCheckBox"
        Me.ToggleWordWrapForChangeNoteCheckBox.Size = New System.Drawing.Size(17, 18)
        Me.ToggleWordWrapForChangeNoteCheckBox.TabIndex = 17
        Me.ToggleWordWrapForChangeNoteCheckBox.UseVisualStyleBackColor = True
        '
        'ItemChangeNoteLabel
        '
        Me.ItemChangeNoteLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemChangeNoteLabel.Location = New System.Drawing.Point(0, 6)
        Me.ItemChangeNoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemChangeNoteLabel.Name = "ItemChangeNoteLabel"
        Me.ItemChangeNoteLabel.Size = New System.Drawing.Size(352, 18)
        Me.ItemChangeNoteLabel.TabIndex = 11
        Me.ItemChangeNoteLabel.Text = "改动说明 (### / ### 最多字数):"
        '
        'ItemTopPanel
        '
        Me.ItemTopPanel.Controls.Add(Me.ItemIDLabel)
        Me.ItemTopPanel.Controls.Add(Me.ItemIDTextBox)
        Me.ItemTopPanel.Controls.Add(Me.ItemOwnerLabel)
        Me.ItemTopPanel.Controls.Add(Me.ItemOwnerTextBox)
        Me.ItemTopPanel.Controls.Add(Me.ItemPostedTextBox)
        Me.ItemTopPanel.Controls.Add(Me.ItemUpdatedTextBox)
        Me.ItemTopPanel.Controls.Add(Me.ItemTitleLabel)
        Me.ItemTopPanel.Controls.Add(Me.ItemTitleTextBox)
        Me.ItemTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemTopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemTopPanel.Name = "ItemTopPanel"
        Me.ItemTopPanel.Size = New System.Drawing.Size(773, 94)
        Me.ItemTopPanel.TabIndex = 36
        '
        'ItemIDLabel
        '
        Me.ItemIDLabel.Location = New System.Drawing.Point(4, 6)
        Me.ItemIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemIDLabel.Name = "ItemIDLabel"
        Me.ItemIDLabel.Size = New System.Drawing.Size(33, 18)
        Me.ItemIDLabel.TabIndex = 4
        Me.ItemIDLabel.Text = "ID:"
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.CueBannerText = ""
        Me.ItemIDTextBox.Location = New System.Drawing.Point(45, 0)
        Me.ItemIDTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.ReadOnly = True
        Me.ItemIDTextBox.Size = New System.Drawing.Size(145, 25)
        Me.ItemIDTextBox.TabIndex = 0
        '
        'ItemOwnerTextBox
        '
        Me.ItemOwnerTextBox.CueBannerText = ""
        Me.ItemOwnerTextBox.Location = New System.Drawing.Point(268, 0)
        Me.ItemOwnerTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemOwnerTextBox.Name = "ItemOwnerTextBox"
        Me.ItemOwnerTextBox.ReadOnly = True
        Me.ItemOwnerTextBox.Size = New System.Drawing.Size(159, 25)
        Me.ItemOwnerTextBox.TabIndex = 1
        '
        'ItemTitleLabel
        '
        Me.ItemTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemTitleLabel.Location = New System.Drawing.Point(4, 39)
        Me.ItemTitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemTitleLabel.Name = "ItemTitleLabel"
        Me.ItemTitleLabel.Size = New System.Drawing.Size(769, 17)
        Me.ItemTitleLabel.TabIndex = 8
        Me.ItemTitleLabel.Text = "标题 (### / ### 最多字数):"
        '
        'ItemTitleTextBox
        '
        Me.ItemTitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemTitleTextBox.CueBannerText = "*必填项"
        Me.ItemTitleTextBox.Location = New System.Drawing.Point(4, 61)
        Me.ItemTitleTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemTitleTextBox.Name = "ItemTitleTextBox"
        Me.ItemTitleTextBox.Size = New System.Drawing.Size(768, 25)
        Me.ItemTitleTextBox.TabIndex = 4
        Me.ItemTitleTextBox.WordWrap = False
        '
        'ItemBottomPanel
        '
        Me.ItemBottomPanel.Controls.Add(Me.ItemContentFolderOrFileLabel)
        Me.ItemBottomPanel.Controls.Add(Me.ItemContentPathFileNameTextBox)
        Me.ItemBottomPanel.Controls.Add(Me.BrowseItemContentPathFileNameButton)
        Me.ItemBottomPanel.Controls.Add(Me.ItemPreviewImageLabel)
        Me.ItemBottomPanel.Controls.Add(Me.ItemPreviewImagePathFileNameTextBox)
        Me.ItemBottomPanel.Controls.Add(Me.BrowseItemPreviewImagePathFileNameButton)
        Me.ItemBottomPanel.Controls.Add(Me.ItemPreviewImagePictureBox)
        Me.ItemBottomPanel.Controls.Add(Me.ItemVisibilityComboBox)
        Me.ItemBottomPanel.Controls.Add(Me.ItemVisibilityLabel)
        Me.ItemBottomPanel.Controls.Add(Me.SaveAsTemplateOrDraftItemButton)
        Me.ItemBottomPanel.Controls.Add(Me.RefreshOrRevertItemButton)
        Me.ItemBottomPanel.Controls.Add(Me.SaveTemplateButton)
        Me.ItemBottomPanel.Controls.Add(Me.OpenWorkshopPageButton)
        Me.ItemBottomPanel.Controls.Add(Me.DeleteItemButton)
        Me.ItemBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ItemBottomPanel.Location = New System.Drawing.Point(0, 242)
        Me.ItemBottomPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemBottomPanel.Name = "ItemBottomPanel"
        Me.ItemBottomPanel.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.ItemBottomPanel.Size = New System.Drawing.Size(773, 158)
        Me.ItemBottomPanel.TabIndex = 37
        '
        'ItemContentFolderOrFileLabel
        '
        Me.ItemContentFolderOrFileLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemContentFolderOrFileLabel.Location = New System.Drawing.Point(4, 4)
        Me.ItemContentFolderOrFileLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemContentFolderOrFileLabel.Name = "ItemContentFolderOrFileLabel"
        Me.ItemContentFolderOrFileLabel.Size = New System.Drawing.Size(553, 18)
        Me.ItemContentFolderOrFileLabel.TabIndex = 18
        Me.ItemContentFolderOrFileLabel.Text = "文件 (### / ### 最大MB):"
        '
        'ItemContentPathFileNameTextBox
        '
        Me.ItemContentPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemContentPathFileNameTextBox.CueBannerText = "*必填项"
        Me.ItemContentPathFileNameTextBox.Location = New System.Drawing.Point(4, 26)
        Me.ItemContentPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemContentPathFileNameTextBox.Name = "ItemContentPathFileNameTextBox"
        Me.ItemContentPathFileNameTextBox.Size = New System.Drawing.Size(552, 25)
        Me.ItemContentPathFileNameTextBox.TabIndex = 7
        Me.ItemContentPathFileNameTextBox.WordWrap = False
        '
        'BrowseItemContentPathFileNameButton
        '
        Me.BrowseItemContentPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseItemContentPathFileNameButton.Location = New System.Drawing.Point(565, 26)
        Me.BrowseItemContentPathFileNameButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BrowseItemContentPathFileNameButton.Name = "BrowseItemContentPathFileNameButton"
        Me.BrowseItemContentPathFileNameButton.Size = New System.Drawing.Size(100, 30)
        Me.BrowseItemContentPathFileNameButton.TabIndex = 8
        Me.BrowseItemContentPathFileNameButton.Text = "浏览..."
        Me.BrowseItemContentPathFileNameButton.UseVisualStyleBackColor = True
        '
        'ItemPreviewImageLabel
        '
        Me.ItemPreviewImageLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemPreviewImageLabel.Location = New System.Drawing.Point(4, 62)
        Me.ItemPreviewImageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemPreviewImageLabel.Name = "ItemPreviewImageLabel"
        Me.ItemPreviewImageLabel.Size = New System.Drawing.Size(553, 18)
        Me.ItemPreviewImageLabel.TabIndex = 13
        Me.ItemPreviewImageLabel.Text = "预览图 (### / ### 最大MB |  建议: 512x512):"
        '
        'ItemPreviewImagePathFileNameTextBox
        '
        Me.ItemPreviewImagePathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemPreviewImagePathFileNameTextBox.CueBannerText = "*必填项"
        Me.ItemPreviewImagePathFileNameTextBox.Location = New System.Drawing.Point(4, 83)
        Me.ItemPreviewImagePathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemPreviewImagePathFileNameTextBox.Name = "ItemPreviewImagePathFileNameTextBox"
        Me.ItemPreviewImagePathFileNameTextBox.Size = New System.Drawing.Size(552, 25)
        Me.ItemPreviewImagePathFileNameTextBox.TabIndex = 9
        Me.ItemPreviewImagePathFileNameTextBox.WordWrap = False
        '
        'BrowseItemPreviewImagePathFileNameButton
        '
        Me.BrowseItemPreviewImagePathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseItemPreviewImagePathFileNameButton.Location = New System.Drawing.Point(565, 83)
        Me.BrowseItemPreviewImagePathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseItemPreviewImagePathFileNameButton.Name = "BrowseItemPreviewImagePathFileNameButton"
        Me.BrowseItemPreviewImagePathFileNameButton.Size = New System.Drawing.Size(100, 30)
        Me.BrowseItemPreviewImagePathFileNameButton.TabIndex = 10
        Me.BrowseItemPreviewImagePathFileNameButton.Text = "浏览..."
        Me.BrowseItemPreviewImagePathFileNameButton.UseVisualStyleBackColor = True
        '
        'ItemPreviewImagePictureBox
        '
        Me.ItemPreviewImagePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemPreviewImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemPreviewImagePictureBox.Location = New System.Drawing.Point(673, 10)
        Me.ItemPreviewImagePictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemPreviewImagePictureBox.Name = "ItemPreviewImagePictureBox"
        Me.ItemPreviewImagePictureBox.Size = New System.Drawing.Size(99, 103)
        Me.ItemPreviewImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ItemPreviewImagePictureBox.TabIndex = 27
        Me.ItemPreviewImagePictureBox.TabStop = False
        '
        'ItemVisibilityComboBox
        '
        Me.ItemVisibilityComboBox.FormattingEnabled = True
        Me.ItemVisibilityComboBox.Location = New System.Drawing.Point(84, 122)
        Me.ItemVisibilityComboBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemVisibilityComboBox.Name = "ItemVisibilityComboBox"
        Me.ItemVisibilityComboBox.Size = New System.Drawing.Size(132, 26)
        Me.ItemVisibilityComboBox.TabIndex = 11
        '
        'ItemVisibilityLabel
        '
        Me.ItemVisibilityLabel.AutoSize = True
        Me.ItemVisibilityLabel.Location = New System.Drawing.Point(4, 127)
        Me.ItemVisibilityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ItemVisibilityLabel.Name = "ItemVisibilityLabel"
        Me.ItemVisibilityLabel.Size = New System.Drawing.Size(54, 18)
        Me.ItemVisibilityLabel.TabIndex = 10
        Me.ItemVisibilityLabel.Text = "可见性:"
        '
        'SaveAsTemplateOrDraftItemButton
        '
        Me.SaveAsTemplateOrDraftItemButton.Location = New System.Drawing.Point(225, 122)
        Me.SaveAsTemplateOrDraftItemButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveAsTemplateOrDraftItemButton.Name = "SaveAsTemplateOrDraftItemButton"
        Me.SaveAsTemplateOrDraftItemButton.Size = New System.Drawing.Size(95, 30)
        Me.SaveAsTemplateOrDraftItemButton.TabIndex = 12
        Me.SaveAsTemplateOrDraftItemButton.Text = "保存为模板"
        Me.SaveAsTemplateOrDraftItemButton.UseVisualStyleBackColor = True
        '
        'RefreshOrRevertItemButton
        '
        Me.RefreshOrRevertItemButton.Location = New System.Drawing.Point(328, 122)
        Me.RefreshOrRevertItemButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshOrRevertItemButton.Name = "RefreshOrRevertItemButton"
        Me.RefreshOrRevertItemButton.Size = New System.Drawing.Size(100, 30)
        Me.RefreshOrRevertItemButton.TabIndex = 13
        Me.RefreshOrRevertItemButton.Text = "刷新"
        Me.RefreshOrRevertItemButton.UseVisualStyleBackColor = True
        '
        'SaveTemplateButton
        '
        Me.SaveTemplateButton.Location = New System.Drawing.Point(436, 122)
        Me.SaveTemplateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveTemplateButton.Name = "SaveTemplateButton"
        Me.SaveTemplateButton.Size = New System.Drawing.Size(100, 30)
        Me.SaveTemplateButton.TabIndex = 14
        Me.SaveTemplateButton.Text = "保存"
        Me.SaveTemplateButton.UseVisualStyleBackColor = True
        '
        'OpenWorkshopPageButton
        '
        Me.OpenWorkshopPageButton.Enabled = False
        Me.OpenWorkshopPageButton.Location = New System.Drawing.Point(544, 122)
        Me.OpenWorkshopPageButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OpenWorkshopPageButton.Name = "OpenWorkshopPageButton"
        Me.OpenWorkshopPageButton.Size = New System.Drawing.Size(121, 30)
        Me.OpenWorkshopPageButton.TabIndex = 15
        Me.OpenWorkshopPageButton.Text = "打开工坊页面"
        Me.OpenWorkshopPageButton.UseVisualStyleBackColor = True
        '
        'DeleteItemButton
        '
        Me.DeleteItemButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteItemButton.Location = New System.Drawing.Point(673, 122)
        Me.DeleteItemButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteItemButton.Name = "DeleteItemButton"
        Me.DeleteItemButton.Size = New System.Drawing.Size(100, 30)
        Me.DeleteItemButton.TabIndex = 16
        Me.DeleteItemButton.Text = "删除..."
        Me.DeleteItemButton.UseVisualStyleBackColor = True
        '
        'ItemLeftMinScrollPanel
        '
        Me.ItemLeftMinScrollPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemLeftMinScrollPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemLeftMinScrollPanel.Name = "ItemLeftMinScrollPanel"
        Me.ItemLeftMinScrollPanel.Size = New System.Drawing.Size(773, 242)
        Me.ItemLeftMinScrollPanel.TabIndex = 38
        '
        'ItemTagsGroupBox
        '
        Me.ItemTagsGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.ItemTagsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemTagsGroupBox.IsReadOnly = False
        Me.ItemTagsGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.ItemTagsGroupBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ItemTagsGroupBox.Name = "ItemTagsGroupBox"
        Me.ItemTagsGroupBox.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItemTagsGroupBox.SelectedValue = Nothing
        Me.ItemTagsGroupBox.Size = New System.Drawing.Size(231, 381)
        Me.ItemTagsGroupBox.TabIndex = 17
        Me.ItemTagsGroupBox.TabStop = False
        Me.ItemTagsGroupBox.Text = "标签"
        '
        'LogTextBox
        '
        Me.LogTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogTextBox.CueBannerText = ""
        Me.LogTextBox.Font = New System.Drawing.Font("Cascadia Mono", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.LogTextBox.HideSelection = False
        Me.LogTextBox.Location = New System.Drawing.Point(179, 0)
        Me.LogTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.Size = New System.Drawing.Size(843, 75)
        Me.LogTextBox.TabIndex = 19
        Me.LogTextBox.Text = ""
        Me.LogTextBox.WordWrap = False
        '
        'PublishItemButton
        '
        Me.PublishItemButton.Location = New System.Drawing.Point(4, 0)
        Me.PublishItemButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PublishItemButton.Name = "PublishItemButton"
        Me.PublishItemButton.Size = New System.Drawing.Size(167, 30)
        Me.PublishItemButton.TabIndex = 18
        Me.PublishItemButton.Text = "发布"
        Me.PublishItemButton.UseVisualStyleBackColor = True
        '
        'QueueListView
        '
        Me.QueueListView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QueueListView.HideSelection = False
        Me.QueueListView.Location = New System.Drawing.Point(757, 0)
        Me.QueueListView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.QueueListView.Name = "QueueListView"
        Me.QueueListView.Size = New System.Drawing.Size(264, 81)
        Me.QueueListView.TabIndex = 20
        Me.QueueListView.UseCompatibleStateImageBehavior = False
        Me.QueueListView.Visible = False
        '
        'PublishUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TopMiddleSplitContainer)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "PublishUserControl"
        Me.Size = New System.Drawing.Size(1027, 739)
        Me.TopMiddleSplitContainer.Panel1.ResumeLayout(False)
        Me.TopMiddleSplitContainer.Panel1.PerformLayout()
        Me.TopMiddleSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.TopMiddleSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMiddleSplitContainer.ResumeLayout(False)
        Me.ItemsPanel.ResumeLayout(False)
        Me.ItemsPanel.PerformLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemListToolStrip.ResumeLayout(False)
        Me.ItemListToolStrip.PerformLayout()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        Me.MiddleBottomSplitContainer.Panel1.ResumeLayout(False)
        Me.MiddleBottomSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MiddleBottomSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiddleBottomSplitContainer.ResumeLayout(False)
        Me.ItemGroupBox.ResumeLayout(False)
        Me.ItemTagsSplitContainer.Panel1.ResumeLayout(False)
        Me.ItemTagsSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ItemTagsSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemTagsSplitContainer.ResumeLayout(False)
        Me.DescriptionChangeNoteSplitContainer.Panel1.ResumeLayout(False)
        Me.DescriptionChangeNoteSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.DescriptionChangeNoteSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescriptionChangeNoteSplitContainer.ResumeLayout(False)
        Me.ItemDescriptionTopPanel.ResumeLayout(False)
        Me.ItemChangeNoteTopPanel.ResumeLayout(False)
        Me.ToggleWordWrapForChangeNotePanel.ResumeLayout(False)
        Me.ItemTopPanel.ResumeLayout(False)
        Me.ItemTopPanel.PerformLayout()
        Me.ItemBottomPanel.ResumeLayout(False)
        Me.ItemBottomPanel.PerformLayout()
        CType(Me.ItemPreviewImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopMiddleSplitContainer As SplitContainerEx
	Friend WithEvents ItemsDataGridView As DataGridViewEx
	Friend WithEvents PublishRequiresSteamLabel As Label
	Friend WithEvents OpenSteamSubscriberAgreementButton As Button
	Friend WithEvents AppIdComboBox As ComboBox
	Friend WithEvents GameLabel As Label
	Friend WithEvents MiddleBottomSplitContainer As SplitContainer
	Friend WithEvents ItemGroupBox As GroupBoxEx
	Friend WithEvents ItemTagsSplitContainer As SplitContainer
	Friend WithEvents OpenWorkshopPageButton As Button
	Friend WithEvents ItemTitleLabel As Label
	Friend WithEvents DeleteItemButton As Button
	Friend WithEvents ItemVisibilityComboBox As ComboBox
	Friend WithEvents BrowseItemPreviewImagePathFileNameButton As Button
	Friend WithEvents ItemTitleTextBox As TextBoxEx
	Friend WithEvents ItemPreviewImageLabel As Label
	Friend WithEvents ItemIDTextBox As TextBoxEx
	Friend WithEvents ItemPreviewImagePathFileNameTextBox As TextBoxEx
	Friend WithEvents ItemVisibilityLabel As Label
	Friend WithEvents ItemPostedTextBox As DateTimeTextBoxEx
	Friend WithEvents BrowseItemContentPathFileNameButton As Button
	Friend WithEvents ItemUpdatedTextBox As DateTimeTextBoxEx
	Friend WithEvents ItemContentPathFileNameTextBox As TextBoxEx
	Friend WithEvents ItemContentFolderOrFileLabel As Label
	Friend WithEvents DescriptionChangeNoteSplitContainer As SplitContainer
	Friend WithEvents ItemDescriptionLabel As Label
	Friend WithEvents ItemDescriptionTextBox As RichTextBoxEx
	Friend WithEvents ItemChangeNoteLabel As Label
	Friend WithEvents ItemChangeNoteTextBox As RichTextBoxEx
	Friend WithEvents ItemPreviewImagePictureBox As PictureBox
	Friend WithEvents ItemIDLabel As Label
	Friend WithEvents ItemTagsGroupBox As GroupBoxEx
	Friend WithEvents QueueListView As ListView
	Friend WithEvents LogTextBox As RichTextBoxEx
	Friend WithEvents PublishItemButton As Button
	Friend WithEvents ItemListToolStrip As ToolStrip
	Friend WithEvents ItemCountsToolStripLabel As ToolStripLabel
	Friend WithEvents FindItemToolStripTextBox As ToolStripSpringTextBox
	Friend WithEvents SearchItemsToolStripButton As ToolStripButton
	Friend WithEvents ItemsPanel As Panel
	Friend WithEvents RefreshOrRevertItemButton As Button
	Friend WithEvents SearchItemsToolStripTextBox As ToolStripTextBox
	Friend WithEvents AddItemToolStripButton As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents SaveAsTemplateOrDraftItemButton As Button
	Friend WithEvents ItemOwnerTextBox As TextBoxEx
	Friend WithEvents ItemOwnerLabel As Label
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents SearchItemsToolStripComboBox As ToolStripComboBox
	Friend WithEvents SaveTemplateButton As Button
	Friend WithEvents QuotaProgressBar As ProgressBarEx
	Friend WithEvents ToggleWordWrapForDescriptionCheckBox As CheckBox
	Friend WithEvents ToggleWordWrapForChangeNoteCheckBox As CheckBox
	Friend WithEvents RefreshGameItemsButton As Button
	Friend WithEvents GamePanel As Panel
	Friend WithEvents ItemTopPanel As Panel
	Friend WithEvents ItemBottomPanel As Panel
	Friend WithEvents ItemLeftMinScrollPanel As Panel
	Friend WithEvents ItemDescriptionTopPanel As Panel
	Friend WithEvents ItemChangeNoteTopPanel As Panel
	Friend WithEvents ToggleWordWrapForChangeNotePanel As Panel
	Friend WithEvents ExplanationTextBox As TextBoxEx
End Class
