Imports System.ComponentModel

Public Module AppEnums

	Public Enum InputOptions
		<Description("文件")> File
		<Description("文件夹")> Folder
		<Description("文件夹和子文件夹")> FolderRecursion
	End Enum

	Public Enum DownloadOutputPathOptions
		'<Description("Downloads folder")> DownloadsFolder
		<Description("文档文件夹")> DocumentsFolder
		<Description("工作文件夹")> WorkFolder
	End Enum

	Public Enum UnpackOutputPathOptions
		<Description("同一文件夹(of Package)")> SameFolder
		<Description("子文件夹(of Package)")> Subfolder
		<Description("工作文件夹")> WorkFolder
		<Description("游戏的addons文件夹")> GameAddonsFolder
	End Enum

	Public Enum DecompileOutputPathOptions
		<Description("工作文件夹")> WorkFolder
		<Description("子文件夹(of MDL input)")> Subfolder
	End Enum

	Public Enum CompileOutputPathOptions
		<Description("游戏的models文件夹")> GameModelsFolder
		<Description("工作文件夹")> WorkFolder
		<Description("子文件夹(of QC input)")> Subfolder
	End Enum

	Public Enum PackInputOptions
		<Description("文件夹")> Folder
		<Description("子文件夹的父文件夹")> ParentFolder
	End Enum

	Public Enum PackOutputPathOptions
		<Description("工作文件夹")> WorkFolder
		<Description("父文件夹")> ParentFolder
	End Enum

	Public Enum PublishSearchFieldOptions
		<Description("ID")> ID
		<Description("所有者")> Owner
		<Description("标题")> Title
		<Description("描述")> Description
		<Description("[所有字段]")> AllFields
	End Enum

	Public Enum StatusMessage
		<Description("成功")> Success
		<Description("错误")> [Error]
		<Description("已取消")> Canceled
		<Description("已跳过")> Skipped

		<Description("无法创建临时文件夹")> ErrorUnableToCreateTempFolder

		<Description("找不到必需的序列文件")> ErrorRequiredSequenceGroupMdlFileNotFound
		<Description("找不到必需的贴图文件")> ErrorRequiredTextureMdlFileNotFound

		<Description("找不到必需的MDL文件")> ErrorRequiredMdlFileNotFound
		<Description("找不到必需的ANI文件")> ErrorRequiredAniFileNotFound
		<Description("找不到必需的VTX文件")> ErrorRequiredVtxFileNotFound
		<Description("找不到必需的VVD文件")> ErrorRequiredVvdFileNotFound

		<Description("无效的MDL文件标识符ID")> ErrorInvalidMdlFileId
		<Description("无效的内部MDL文件大小")> ErrorInvalidInternalMdlFileSize
	End Enum

	<FlagsAttribute>
	Public Enum FilesFoundFlags
		<Description("已找到所需文件")> AllFilesFound = 0
		<Description("找不到必需的序列文件")> ErrorRequiredSequenceGroupMdlFileNotFound = 1
		<Description("找不到必需的贴图文件")> ErrorRequiredTextureMdlFileNotFound = 2

		<Description("找不到必需的MDL文件")> ErrorRequiredMdlFileNotFound = 4
		<Description("找不到必需的ANI文件")> ErrorRequiredAniFileNotFound = 8
		<Description("找不到必需的VTX文件")> ErrorRequiredVtxFileNotFound = 16
		<Description("找不到必需的VVD文件")> ErrorRequiredVvdFileNotFound = 32

		<Description("错误")> [Error] = 64
	End Enum

	Public Enum ActionType
		<Description("未知")> Unknown
		<Description("游戏设置")> SetUpGames
		<Description("下载")> Download
		<Description("解包")> Unpack
		<Description("预览")> Preview
		<Description("反编译")> Decompile
		<Description("编辑")> Edit
		<Description("编译")> Compile
		<Description("查看")> View
		<Description("打包")> Pack
		<Description("发布")> Publish
		'<Description("选项")> Options
	End Enum

	Public Enum ContainerType
		GMA
		VPK
	End Enum

	Public Enum PackageAction
		Undefined
		Insert
		List
		Pack
		Unpack
		UnpackToTemp
		UnpackToTempAndOpen
		UnpackFolderTree
	End Enum

	Public Enum ViewerType
		<Description("预览")> Preview
		<Description("查看")> View
	End Enum

	Public Enum DecompiledFileType
		QC
		ReferenceMesh
		LodMesh
		BoneAnimation
		PhysicsMesh
		VertexAnimation
		ProceduralBones
		TextureBmp
		Debug
		DeclareSequenceQci
	End Enum

	Public Enum ProgressOptions
		WarningPhyFileChecksumDoesNotMatchMdlFileChecksum

		WritingFileStarted
		WritingFileFailed
		WritingFileFinished
	End Enum

	Public Enum FindDirection
		Previous
		[Next]
	End Enum

	Public Enum GameEngine
		<Description("GoldSource")> GoldSource
		<Description("Source")> Source
		<Description("Source 2")> Source2
	End Enum

	Public Enum SupportedMdlVersion
		<Description("不要覆盖")> DoNotOverride
		<Description("06")> MDLv06
		<Description("10")> MDLv10
		<Description("2531")> MDLv2531
		<Description("27")> MDLv27
		<Description("28")> MDLv28
		<Description("29")> MDLv29
		<Description("30")> MDLv30
		<Description("31")> MDLv31
		<Description("32")> MDLv32
		<Description("35")> MDLv35
		<Description("36")> MDLv36
		<Description("37")> MDLv37
		<Description("38")> MDLv38
		<Description("44")> MDLv44
		<Description("45")> MDLv45
		<Description("46")> MDLv46
		<Description("47")> MDLv47
		<Description("48")> MDLv48
		<Description("49")> MDLv49
		<Description("52")> MDLv52
		<Description("53")> MDLv53
		<Description("57")> MDLv57
	End Enum

	Public Enum OrientationType
		<Description("水平")> Horizontal
		<Description("垂直")> Vertical
	End Enum

	Public Enum ByteUnitsOption
		<Description("字节")> Bytes
		<Description("二进制")> Binary
		<Description("十进制")> [Decimal]
	End Enum

End Module
