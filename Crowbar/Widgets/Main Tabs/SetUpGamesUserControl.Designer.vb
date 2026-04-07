<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetUpGamesUserControl
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
        Me.components = New System.ComponentModel.Container()
        Me.AddLibraryPathButton = New System.Windows.Forms.Button()
        Me.DeleteLibraryPathButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BrowseForSteamAppPathFileNameButton = New System.Windows.Forms.Button()
        Me.SteamAppPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddGameSetupButton = New System.Windows.Forms.Button()
        Me.GameSetupComboBox = New System.Windows.Forms.ComboBox()
        Me.GameGroupBox = New System.Windows.Forms.GroupBox()
        Me.EngineLabel = New System.Windows.Forms.Label()
        Me.EngineComboBox = New System.Windows.Forms.ComboBox()
        Me.CreateModelsFolderTreeButton = New System.Windows.Forms.Button()
        Me.BrowseForMappingToolPathFileNameButton = New System.Windows.Forms.Button()
        Me.MappingToolPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.MappingToolLabel = New System.Windows.Forms.Label()
        Me.GameAppOptionsTextBox = New System.Windows.Forms.TextBox()
        Me.ExecutableOptionsLabel = New System.Windows.Forms.Label()
        Me.ClearGameAppOptionsButton = New System.Windows.Forms.Button()
        Me.BrowseForGameAppPathFileNameButton = New System.Windows.Forms.Button()
        Me.GameAppPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExecutableLabel = New System.Windows.Forms.Label()
        Me.PackerLabel = New System.Windows.Forms.Label()
        Me.BrowseForUnpackerPathFileNameButton = New System.Windows.Forms.Button()
        Me.PackerPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.ModelViewerLabel = New System.Windows.Forms.Label()
        Me.BrowseForViewerPathFileNameButton = New System.Windows.Forms.Button()
        Me.ViewerPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.CloneGameSetupButton = New System.Windows.Forms.Button()
        Me.GameNameTextBox = New Crowbar.TextBoxEx()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.DeleteGameSetupButton = New System.Windows.Forms.Button()
        Me.BrowseForGamePathFileNameButton = New System.Windows.Forms.Button()
        Me.GamePathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.ModelCompilerLabel = New System.Windows.Forms.Label()
        Me.BrowseForCompilerPathFileNameButton = New System.Windows.Forms.Button()
        Me.CompilerPathFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.GamePathLabel = New System.Windows.Forms.Label()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.SteamLibraryPathsDataGridView = New Crowbar.MacroDataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GameGroupBox.SuspendLayout()
        CType(Me.SteamLibraryPathsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddLibraryPathButton
        '
        Me.AddLibraryPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddLibraryPathButton.Location = New System.Drawing.Point(817, 570)
        Me.AddLibraryPathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddLibraryPathButton.Name = "AddLibraryPathButton"
        Me.AddLibraryPathButton.Size = New System.Drawing.Size(100, 32)
        Me.AddLibraryPathButton.TabIndex = 51
        Me.AddLibraryPathButton.Text = "添加宏"
        Me.AddLibraryPathButton.UseVisualStyleBackColor = True
        '
        'DeleteLibraryPathButton
        '
        Me.DeleteLibraryPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteLibraryPathButton.Location = New System.Drawing.Point(817, 611)
        Me.DeleteLibraryPathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteLibraryPathButton.Name = "DeleteLibraryPathButton"
        Me.DeleteLibraryPathButton.Size = New System.Drawing.Size(100, 69)
        Me.DeleteLibraryPathButton.TabIndex = 50
        Me.DeleteLibraryPathButton.Text = "如果未使用 删除最后的宏"
        Me.DeleteLibraryPathButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 548)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(493, 18)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Steam库文件夹 (在上方输入框开头使用 <library#> 宏；右键点击宏查看命令):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 482)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(309, 18)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Steam路径(Steam.exe) [用于""启动游戏""按钮]:"
        '
        'BrowseForSteamAppPathFileNameButton
        '
        Me.BrowseForSteamAppPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForSteamAppPathFileNameButton.Location = New System.Drawing.Point(817, 504)
        Me.BrowseForSteamAppPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForSteamAppPathFileNameButton.Name = "BrowseForSteamAppPathFileNameButton"
        Me.BrowseForSteamAppPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForSteamAppPathFileNameButton.TabIndex = 47
        Me.BrowseForSteamAppPathFileNameButton.Text = "浏览..."
        Me.BrowseForSteamAppPathFileNameButton.UseVisualStyleBackColor = True
        '
        'SteamAppPathFileNameTextBox
        '
        Me.SteamAppPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SteamAppPathFileNameTextBox.Location = New System.Drawing.Point(4, 504)
        Me.SteamAppPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SteamAppPathFileNameTextBox.Name = "SteamAppPathFileNameTextBox"
        Me.SteamAppPathFileNameTextBox.Size = New System.Drawing.Size(804, 25)
        Me.SteamAppPathFileNameTextBox.TabIndex = 46
        '
        'AddGameSetupButton
        '
        Me.AddGameSetupButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddGameSetupButton.Location = New System.Drawing.Point(941, 4)
        Me.AddGameSetupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGameSetupButton.Name = "AddGameSetupButton"
        Me.AddGameSetupButton.Size = New System.Drawing.Size(100, 32)
        Me.AddGameSetupButton.TabIndex = 43
        Me.AddGameSetupButton.Text = "添加"
        Me.AddGameSetupButton.UseVisualStyleBackColor = True
        '
        'GameSetupComboBox
        '
        Me.GameSetupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameSetupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GameSetupComboBox.FormattingEnabled = True
        Me.GameSetupComboBox.Location = New System.Drawing.Point(4, 6)
        Me.GameSetupComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameSetupComboBox.Name = "GameSetupComboBox"
        Me.GameSetupComboBox.Size = New System.Drawing.Size(928, 26)
        Me.GameSetupComboBox.TabIndex = 42
        '
        'GameGroupBox
        '
        Me.GameGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameGroupBox.Controls.Add(Me.EngineLabel)
        Me.GameGroupBox.Controls.Add(Me.EngineComboBox)
        Me.GameGroupBox.Controls.Add(Me.CreateModelsFolderTreeButton)
        Me.GameGroupBox.Controls.Add(Me.BrowseForMappingToolPathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.MappingToolPathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.MappingToolLabel)
        Me.GameGroupBox.Controls.Add(Me.GameAppOptionsTextBox)
        Me.GameGroupBox.Controls.Add(Me.ExecutableOptionsLabel)
        Me.GameGroupBox.Controls.Add(Me.ClearGameAppOptionsButton)
        Me.GameGroupBox.Controls.Add(Me.BrowseForGameAppPathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.GameAppPathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.ExecutableLabel)
        Me.GameGroupBox.Controls.Add(Me.PackerLabel)
        Me.GameGroupBox.Controls.Add(Me.BrowseForUnpackerPathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.PackerPathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.ModelViewerLabel)
        Me.GameGroupBox.Controls.Add(Me.BrowseForViewerPathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.ViewerPathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.CloneGameSetupButton)
        Me.GameGroupBox.Controls.Add(Me.GameNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.NameLabel)
        Me.GameGroupBox.Controls.Add(Me.DeleteGameSetupButton)
        Me.GameGroupBox.Controls.Add(Me.BrowseForGamePathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.GamePathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.ModelCompilerLabel)
        Me.GameGroupBox.Controls.Add(Me.BrowseForCompilerPathFileNameButton)
        Me.GameGroupBox.Controls.Add(Me.CompilerPathFileNameTextBox)
        Me.GameGroupBox.Controls.Add(Me.GamePathLabel)
        Me.GameGroupBox.Location = New System.Drawing.Point(4, 44)
        Me.GameGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameGroupBox.Name = "GameGroupBox"
        Me.GameGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.GameGroupBox.Size = New System.Drawing.Size(1037, 421)
        Me.GameGroupBox.TabIndex = 44
        Me.GameGroupBox.TabStop = False
        Me.GameGroupBox.Text = "游戏设置"
        '
        'EngineLabel
        '
        Me.EngineLabel.AutoSize = True
        Me.EngineLabel.Location = New System.Drawing.Point(8, 68)
        Me.EngineLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EngineLabel.Name = "EngineLabel"
        Me.EngineLabel.Size = New System.Drawing.Size(40, 18)
        Me.EngineLabel.TabIndex = 43
        Me.EngineLabel.Text = "引擎:"
        '
        'EngineComboBox
        '
        Me.EngineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EngineComboBox.FormattingEnabled = True
        Me.EngineComboBox.Items.AddRange(New Object() {"GoldSource", "Source"})
        Me.EngineComboBox.Location = New System.Drawing.Point(73, 62)
        Me.EngineComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EngineComboBox.Name = "EngineComboBox"
        Me.EngineComboBox.Size = New System.Drawing.Size(160, 26)
        Me.EngineComboBox.TabIndex = 42
        '
        'CreateModelsFolderTreeButton
        '
        Me.CreateModelsFolderTreeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateModelsFolderTreeButton.Location = New System.Drawing.Point(669, 381)
        Me.CreateModelsFolderTreeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CreateModelsFolderTreeButton.Name = "CreateModelsFolderTreeButton"
        Me.CreateModelsFolderTreeButton.Size = New System.Drawing.Size(360, 32)
        Me.CreateModelsFolderTreeButton.TabIndex = 40
        Me.CreateModelsFolderTreeButton.Text = "从该游戏的VPK创建""models""文件夹结构"
        Me.ToolTip1.SetToolTip(Me.CreateModelsFolderTreeButton, "Use this so HLMV can view models found in VPKs.")
        Me.CreateModelsFolderTreeButton.UseVisualStyleBackColor = True
        '
        'BrowseForMappingToolPathFileNameButton
        '
        Me.BrowseForMappingToolPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForMappingToolPathFileNameButton.Location = New System.Drawing.Point(929, 300)
        Me.BrowseForMappingToolPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForMappingToolPathFileNameButton.Name = "BrowseForMappingToolPathFileNameButton"
        Me.BrowseForMappingToolPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForMappingToolPathFileNameButton.TabIndex = 39
        Me.BrowseForMappingToolPathFileNameButton.Text = "浏览..."
        Me.BrowseForMappingToolPathFileNameButton.UseVisualStyleBackColor = True
        '
        'MappingToolPathFileNameTextBox
        '
        Me.MappingToolPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MappingToolPathFileNameTextBox.Location = New System.Drawing.Point(136, 300)
        Me.MappingToolPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MappingToolPathFileNameTextBox.Name = "MappingToolPathFileNameTextBox"
        Me.MappingToolPathFileNameTextBox.Size = New System.Drawing.Size(784, 25)
        Me.MappingToolPathFileNameTextBox.TabIndex = 38
        '
        'MappingToolLabel
        '
        Me.MappingToolLabel.AutoSize = True
        Me.MappingToolLabel.Location = New System.Drawing.Point(8, 307)
        Me.MappingToolLabel.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.MappingToolLabel.Name = "MappingToolLabel"
        Me.MappingToolLabel.Size = New System.Drawing.Size(82, 18)
        Me.MappingToolLabel.TabIndex = 37
        Me.MappingToolLabel.Text = "地图编辑器:"
        '
        'GameAppOptionsTextBox
        '
        Me.GameAppOptionsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameAppOptionsTextBox.Location = New System.Drawing.Point(149, 140)
        Me.GameAppOptionsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameAppOptionsTextBox.Name = "GameAppOptionsTextBox"
        Me.GameAppOptionsTextBox.Size = New System.Drawing.Size(771, 25)
        Me.GameAppOptionsTextBox.TabIndex = 32
        '
        'ExecutableOptionsLabel
        '
        Me.ExecutableOptionsLabel.AutoSize = True
        Me.ExecutableOptionsLabel.Location = New System.Drawing.Point(8, 147)
        Me.ExecutableOptionsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExecutableOptionsLabel.Name = "ExecutableOptionsLabel"
        Me.ExecutableOptionsLabel.Size = New System.Drawing.Size(82, 18)
        Me.ExecutableOptionsLabel.TabIndex = 31
        Me.ExecutableOptionsLabel.Text = "游戏启动项:"
        '
        'ClearGameAppOptionsButton
        '
        Me.ClearGameAppOptionsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearGameAppOptionsButton.Location = New System.Drawing.Point(929, 140)
        Me.ClearGameAppOptionsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearGameAppOptionsButton.Name = "ClearGameAppOptionsButton"
        Me.ClearGameAppOptionsButton.Size = New System.Drawing.Size(100, 32)
        Me.ClearGameAppOptionsButton.TabIndex = 33
        Me.ClearGameAppOptionsButton.Text = "清除"
        Me.ClearGameAppOptionsButton.UseVisualStyleBackColor = True
        '
        'BrowseForGameAppPathFileNameButton
        '
        Me.BrowseForGameAppPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForGameAppPathFileNameButton.Location = New System.Drawing.Point(929, 100)
        Me.BrowseForGameAppPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForGameAppPathFileNameButton.Name = "BrowseForGameAppPathFileNameButton"
        Me.BrowseForGameAppPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForGameAppPathFileNameButton.TabIndex = 30
        Me.BrowseForGameAppPathFileNameButton.Text = "浏览..."
        Me.BrowseForGameAppPathFileNameButton.UseVisualStyleBackColor = True
        '
        'GameAppPathFileNameTextBox
        '
        Me.GameAppPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameAppPathFileNameTextBox.Location = New System.Drawing.Point(149, 100)
        Me.GameAppPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameAppPathFileNameTextBox.Name = "GameAppPathFileNameTextBox"
        Me.GameAppPathFileNameTextBox.Size = New System.Drawing.Size(771, 25)
        Me.GameAppPathFileNameTextBox.TabIndex = 29
        '
        'ExecutableLabel
        '
        Me.ExecutableLabel.AutoSize = True
        Me.ExecutableLabel.Location = New System.Drawing.Point(8, 107)
        Me.ExecutableLabel.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.ExecutableLabel.Name = "ExecutableLabel"
        Me.ExecutableLabel.Size = New System.Drawing.Size(95, 18)
        Me.ExecutableLabel.TabIndex = 28
        Me.ExecutableLabel.Text = "游戏程序.exe:"
        '
        'PackerLabel
        '
        Me.PackerLabel.AutoSize = True
        Me.PackerLabel.Location = New System.Drawing.Point(8, 348)
        Me.PackerLabel.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.PackerLabel.Name = "PackerLabel"
        Me.PackerLabel.Size = New System.Drawing.Size(82, 18)
        Me.PackerLabel.TabIndex = 16
        Me.PackerLabel.Text = "解封包工具:"
        '
        'BrowseForUnpackerPathFileNameButton
        '
        Me.BrowseForUnpackerPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForUnpackerPathFileNameButton.Location = New System.Drawing.Point(929, 341)
        Me.BrowseForUnpackerPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForUnpackerPathFileNameButton.Name = "BrowseForUnpackerPathFileNameButton"
        Me.BrowseForUnpackerPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForUnpackerPathFileNameButton.TabIndex = 18
        Me.BrowseForUnpackerPathFileNameButton.Text = "浏览..."
        Me.BrowseForUnpackerPathFileNameButton.UseVisualStyleBackColor = True
        '
        'PackerPathFileNameTextBox
        '
        Me.PackerPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PackerPathFileNameTextBox.Location = New System.Drawing.Point(136, 341)
        Me.PackerPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PackerPathFileNameTextBox.Name = "PackerPathFileNameTextBox"
        Me.PackerPathFileNameTextBox.Size = New System.Drawing.Size(784, 25)
        Me.PackerPathFileNameTextBox.TabIndex = 17
        '
        'ModelViewerLabel
        '
        Me.ModelViewerLabel.AutoSize = True
        Me.ModelViewerLabel.Location = New System.Drawing.Point(8, 267)
        Me.ModelViewerLabel.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.ModelViewerLabel.Name = "ModelViewerLabel"
        Me.ModelViewerLabel.Size = New System.Drawing.Size(82, 18)
        Me.ModelViewerLabel.TabIndex = 13
        Me.ModelViewerLabel.Text = "模型查看器:"
        '
        'BrowseForViewerPathFileNameButton
        '
        Me.BrowseForViewerPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForViewerPathFileNameButton.Location = New System.Drawing.Point(929, 260)
        Me.BrowseForViewerPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForViewerPathFileNameButton.Name = "BrowseForViewerPathFileNameButton"
        Me.BrowseForViewerPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForViewerPathFileNameButton.TabIndex = 15
        Me.BrowseForViewerPathFileNameButton.Text = "浏览..."
        Me.BrowseForViewerPathFileNameButton.UseVisualStyleBackColor = True
        '
        'ViewerPathFileNameTextBox
        '
        Me.ViewerPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewerPathFileNameTextBox.Location = New System.Drawing.Point(136, 260)
        Me.ViewerPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ViewerPathFileNameTextBox.Name = "ViewerPathFileNameTextBox"
        Me.ViewerPathFileNameTextBox.Size = New System.Drawing.Size(784, 25)
        Me.ViewerPathFileNameTextBox.TabIndex = 14
        '
        'CloneGameSetupButton
        '
        Me.CloneGameSetupButton.Location = New System.Drawing.Point(8, 381)
        Me.CloneGameSetupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CloneGameSetupButton.Name = "CloneGameSetupButton"
        Me.CloneGameSetupButton.Size = New System.Drawing.Size(100, 32)
        Me.CloneGameSetupButton.TabIndex = 12
        Me.CloneGameSetupButton.Text = "复制"
        Me.CloneGameSetupButton.UseVisualStyleBackColor = True
        '
        'GameNameTextBox
        '
        Me.GameNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameNameTextBox.CueBannerText = ""
        Me.GameNameTextBox.Location = New System.Drawing.Point(73, 26)
        Me.GameNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameNameTextBox.Name = "GameNameTextBox"
        Me.GameNameTextBox.Size = New System.Drawing.Size(955, 25)
        Me.GameNameTextBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(8, 33)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(40, 18)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "名称:"
        '
        'DeleteGameSetupButton
        '
        Me.DeleteGameSetupButton.Location = New System.Drawing.Point(116, 381)
        Me.DeleteGameSetupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteGameSetupButton.Name = "DeleteGameSetupButton"
        Me.DeleteGameSetupButton.Size = New System.Drawing.Size(100, 32)
        Me.DeleteGameSetupButton.TabIndex = 8
        Me.DeleteGameSetupButton.Text = "删除"
        Me.DeleteGameSetupButton.UseVisualStyleBackColor = True
        '
        'BrowseForGamePathFileNameButton
        '
        Me.BrowseForGamePathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForGamePathFileNameButton.Location = New System.Drawing.Point(929, 180)
        Me.BrowseForGamePathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForGamePathFileNameButton.Name = "BrowseForGamePathFileNameButton"
        Me.BrowseForGamePathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForGamePathFileNameButton.TabIndex = 4
        Me.BrowseForGamePathFileNameButton.Text = "浏览..."
        Me.BrowseForGamePathFileNameButton.UseVisualStyleBackColor = True
        '
        'GamePathFileNameTextBox
        '
        Me.GamePathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GamePathFileNameTextBox.Location = New System.Drawing.Point(136, 180)
        Me.GamePathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GamePathFileNameTextBox.Name = "GamePathFileNameTextBox"
        Me.GamePathFileNameTextBox.Size = New System.Drawing.Size(784, 25)
        Me.GamePathFileNameTextBox.TabIndex = 3
        '
        'ModelCompilerLabel
        '
        Me.ModelCompilerLabel.AutoSize = True
        Me.ModelCompilerLabel.Location = New System.Drawing.Point(8, 227)
        Me.ModelCompilerLabel.Margin = New System.Windows.Forms.Padding(4, 12, 4, 0)
        Me.ModelCompilerLabel.Name = "ModelCompilerLabel"
        Me.ModelCompilerLabel.Size = New System.Drawing.Size(82, 18)
        Me.ModelCompilerLabel.TabIndex = 5
        Me.ModelCompilerLabel.Text = "模型编译器:"
        '
        'BrowseForCompilerPathFileNameButton
        '
        Me.BrowseForCompilerPathFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForCompilerPathFileNameButton.Location = New System.Drawing.Point(929, 220)
        Me.BrowseForCompilerPathFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForCompilerPathFileNameButton.Name = "BrowseForCompilerPathFileNameButton"
        Me.BrowseForCompilerPathFileNameButton.Size = New System.Drawing.Size(100, 32)
        Me.BrowseForCompilerPathFileNameButton.TabIndex = 7
        Me.BrowseForCompilerPathFileNameButton.Text = "浏览..."
        Me.BrowseForCompilerPathFileNameButton.UseVisualStyleBackColor = True
        '
        'CompilerPathFileNameTextBox
        '
        Me.CompilerPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompilerPathFileNameTextBox.Location = New System.Drawing.Point(136, 220)
        Me.CompilerPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerPathFileNameTextBox.Name = "CompilerPathFileNameTextBox"
        Me.CompilerPathFileNameTextBox.Size = New System.Drawing.Size(784, 25)
        Me.CompilerPathFileNameTextBox.TabIndex = 6
        '
        'GamePathLabel
        '
        Me.GamePathLabel.AutoSize = True
        Me.GamePathLabel.Location = New System.Drawing.Point(8, 187)
        Me.GamePathLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GamePathLabel.Name = "GamePathLabel"
        Me.GamePathLabel.Size = New System.Drawing.Size(101, 18)
        Me.GamePathLabel.TabIndex = 2
        Me.GamePathLabel.Text = "GameInfo.txt:"
        '
        'GoBackButton
        '
        Me.GoBackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoBackButton.Enabled = False
        Me.GoBackButton.Location = New System.Drawing.Point(941, 720)
        Me.GoBackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(100, 32)
        Me.GoBackButton.TabIndex = 52
        Me.GoBackButton.Text = "返回"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'SteamLibraryPathsDataGridView
        '
        Me.SteamLibraryPathsDataGridView.AllowUserToAddRows = False
        Me.SteamLibraryPathsDataGridView.AllowUserToDeleteRows = False
        Me.SteamLibraryPathsDataGridView.AllowUserToResizeRows = False
        Me.SteamLibraryPathsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SteamLibraryPathsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SteamLibraryPathsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.SteamLibraryPathsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.SteamLibraryPathsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SteamLibraryPathsDataGridView.Location = New System.Drawing.Point(4, 570)
        Me.SteamLibraryPathsDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.SteamLibraryPathsDataGridView.MultiSelect = False
        Me.SteamLibraryPathsDataGridView.Name = "SteamLibraryPathsDataGridView"
        Me.SteamLibraryPathsDataGridView.RowHeadersVisible = False
        Me.SteamLibraryPathsDataGridView.RowHeadersWidth = 25
        Me.SteamLibraryPathsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SteamLibraryPathsDataGridView.Size = New System.Drawing.Size(805, 181)
        Me.SteamLibraryPathsDataGridView.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GoBackButton)
        Me.Panel1.Controls.Add(Me.GameSetupComboBox)
        Me.Panel1.Controls.Add(Me.AddLibraryPathButton)
        Me.Panel1.Controls.Add(Me.DeleteLibraryPathButton)
        Me.Panel1.Controls.Add(Me.SteamLibraryPathsDataGridView)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.BrowseForSteamAppPathFileNameButton)
        Me.Panel1.Controls.Add(Me.SteamAppPathFileNameTextBox)
        Me.Panel1.Controls.Add(Me.AddGameSetupButton)
        Me.Panel1.Controls.Add(Me.GameGroupBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1045, 756)
        Me.Panel1.TabIndex = 17
        '
        'SetUpGamesUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SetUpGamesUserControl"
        Me.Size = New System.Drawing.Size(1045, 756)
        Me.GameGroupBox.ResumeLayout(False)
        Me.GameGroupBox.PerformLayout()
        CType(Me.SteamLibraryPathsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddLibraryPathButton As System.Windows.Forms.Button
	Friend WithEvents DeleteLibraryPathButton As System.Windows.Forms.Button
	Friend WithEvents SteamLibraryPathsDataGridView As Crowbar.MacroDataGridView
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents BrowseForSteamAppPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents SteamAppPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents AddGameSetupButton As System.Windows.Forms.Button
	Friend WithEvents GameSetupComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents GameGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents CreateModelsFolderTreeButton As System.Windows.Forms.Button
	Friend WithEvents BrowseForMappingToolPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents MappingToolPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents MappingToolLabel As System.Windows.Forms.Label
	Friend WithEvents GameAppOptionsTextBox As System.Windows.Forms.TextBox
	Friend WithEvents ExecutableOptionsLabel As System.Windows.Forms.Label
	Friend WithEvents ClearGameAppOptionsButton As System.Windows.Forms.Button
	Friend WithEvents BrowseForGameAppPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents GameAppPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents ExecutableLabel As System.Windows.Forms.Label
	Friend WithEvents PackerLabel As System.Windows.Forms.Label
	Friend WithEvents BrowseForUnpackerPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents PackerPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents ModelViewerLabel As System.Windows.Forms.Label
	Friend WithEvents BrowseForViewerPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents ViewerPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents CloneGameSetupButton As System.Windows.Forms.Button
	Friend WithEvents GameNameTextBox As Crowbar.TextBoxEx
	Friend WithEvents NameLabel As System.Windows.Forms.Label
	Friend WithEvents DeleteGameSetupButton As System.Windows.Forms.Button
	Friend WithEvents BrowseForGamePathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents GamePathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents ModelCompilerLabel As System.Windows.Forms.Label
	Friend WithEvents BrowseForCompilerPathFileNameButton As System.Windows.Forms.Button
	Friend WithEvents CompilerPathFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents GamePathLabel As System.Windows.Forms.Label
	Friend WithEvents EngineComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents EngineLabel As System.Windows.Forms.Label
	Friend WithEvents GoBackButton As System.Windows.Forms.Button
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents Panel1 As Panel
End Class
