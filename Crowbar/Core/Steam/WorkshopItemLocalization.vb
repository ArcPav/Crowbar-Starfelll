Imports System.ComponentModel

'NOTE: Holds the Title and Description for one non-default language of a WorkshopItem.
'      The item's own Title/Description properties continue to represent "english" (the
'      default Steam Workshop language, used when SetItemUpdateLanguage is never called),
'      so an "english" entry is never stored in a WorkshopItem's Localizations list.
Public Class WorkshopItemLocalization
	Implements ICloneable
	Implements INotifyPropertyChanged

#Region "Create and Destroy"

	Public Sub New()
		Me.theLanguage = ""
		Me.theTitle = ""
		Me.theTitleIsChanged = False
		Me.theDescription = ""
		Me.theDescriptionIsChanged = False
	End Sub

	Public Sub New(ByVal language As String)
		Me.New()
		Me.theLanguage = language
	End Sub

	Protected Sub New(ByVal originalObject As WorkshopItemLocalization)
		Me.theLanguage = originalObject.Language
		Me.theTitle = originalObject.Title
		Me.theTitleIsChanged = False
		Me.theDescription = originalObject.Description
		Me.theDescriptionIsChanged = False
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return New WorkshopItemLocalization(Me)
	End Function

#End Region

#Region "Properties"

	'NOTE: Steam API language code, such as "schinese", "tchinese", "japanese", or "koreana".
	Public Property Language As String
		Get
			Return Me.theLanguage
		End Get
		Set(value As String)
			If Me.theLanguage <> value Then
				Me.theLanguage = value
				NotifyPropertyChanged("Language")
			End If
		End Set
	End Property

	Public Property Title As String
		Get
			Return Me.theTitle
		End Get
		Set(value As String)
			If Me.theTitle <> value Then
				Me.theTitle = value
				Me.theTitleIsChanged = True
				NotifyPropertyChanged("Title")
			End If
		End Set
	End Property

	Public Property TitleIsChanged As Boolean
		Get
			Return Me.theTitleIsChanged
		End Get
		Set(value As Boolean)
			Me.theTitleIsChanged = value
		End Set
	End Property

	Public Property Description As String
		Get
			Return Me.theDescription
		End Get
		Set(value As String)
			If Me.theDescription <> value Then
				Me.theDescription = value
				Me.theDescriptionIsChanged = True
				NotifyPropertyChanged("Description")
			End If
		End Set
	End Property

	Public Property DescriptionIsChanged As Boolean
		Get
			Return Me.theDescriptionIsChanged
		End Get
		Set(value As Boolean)
			Me.theDescriptionIsChanged = value
		End Set
	End Property

#End Region

#Region "Events"

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

#Region "Private Methods"

	Protected Sub NotifyPropertyChanged(ByVal info As String)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
	End Sub

#End Region

#Region "Data"

	Private theLanguage As String
	Private theTitle As String
	Private theTitleIsChanged As Boolean
	Private theDescription As String
	Private theDescriptionIsChanged As Boolean

#End Region

End Class
