Imports System.Drawing.Drawing2D

Public Class ProgressBarEx
	Inherits ProgressBar

	'      Note that Paint() is not called unless UserPaint style is True.
	'      Also OnPaint() is not called unless Paint() is called, but then bar is not drawn.
	'      Overriding and then calling MyBase.OnPaint() does not draw bar.
	'      Conclusion: Must override OnPaint() to draw text and bar. 

	Public Sub New()
		MyBase.New()

		Me.theText = ""
		Me.SetStyle(ControlStyles.UserPaint, True)
		Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
		Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
	End Sub

	Public Overrides Property Text As String
		Get
			Return Me.theText
		End Get
		Set(value As String)
			If Me.theText <> value Then
				Me.theText = value
			End If
		End Set
	End Property

	Public Overloads Property [Value]() As Integer
		Get
			Return MyBase.Value
		End Get
		Set(ByVal value As Integer)
			If value < MyBase.Minimum Then
				value = MyBase.Minimum
			ElseIf value > MyBase.Maximum Then
				value = MyBase.Maximum
			End If
			MyBase.Value = value
			'NOTE: Do this so bar is re-painted when Value changes.
			Me.Invalidate()
		End Set
	End Property

	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		Dim g As Graphics = e.Graphics
		Dim range As Integer = Maximum - Minimum
		Dim percent As Double = If(range > 0, CDbl(Value - Minimum) / CDbl(range), 0)
		Dim rect As Rectangle = Me.ClientRectangle
		Dim bounds As Rectangle = e.ClipRectangle

		Dim isDarkMode As Boolean = (Me.BackColor.R < 100)

		If isDarkMode Then

			Using backBrush As New SolidBrush(Me.BackColor)
				g.FillRectangle(backBrush, rect)
			End Using

			If rect.Width > 0 AndAlso percent > 0 Then
				Dim chunkRect As Rectangle = rect
				chunkRect.Inflate(-1, -1)
				chunkRect.Width = CInt(Math.Max(1, chunkRect.Width * percent))
				
				Using progressBrush As New SolidBrush(Color.FromArgb(0, 120, 215))
					g.FillRectangle(progressBrush, chunkRect)
				End Using
			End If

			Using borderPen As New Pen(Color.FromArgb(85, 85, 85))
				g.DrawRectangle(borderPen, 0, 0, rect.Width - 1, rect.Height - 1)
			End Using

		Else
			If rect.Width > 0 AndAlso percent > 0 Then
				If ProgressBarRenderer.IsSupported Then
					ProgressBarRenderer.DrawHorizontalBar(g, Me.DisplayRectangle)
					Dim chunkRect As Rectangle = rect
					chunkRect.Inflate(-2, -2)
					chunkRect.Width = CInt(Math.Max(1, chunkRect.Width * percent))
					
					Using gradientBrush As New LinearGradientBrush(chunkRect, BackColor, ForeColor, LinearGradientMode.Vertical)
						g.FillRectangle(gradientBrush, chunkRect)
					End Using
				Else
					Dim barWidth As Double = percent * bounds.Width
					Using backBrush As New SolidBrush(BackColor)
						g.FillRectangle(backBrush, bounds)
					End Using
					Using foreBrush As New SolidBrush(ForeColor)
						g.FillRectangle(foreBrush, New RectangleF(0, 0, CSng(barWidth), bounds.Height))
					End Using
					ControlPaint.DrawBorder(g, bounds, Color.Black, ButtonBorderStyle.Solid)
				End If
			Else
				If ProgressBarRenderer.IsSupported Then
					ProgressBarRenderer.DrawHorizontalBar(g, Me.DisplayRectangle)
				Else
					ControlPaint.DrawBorder(g, bounds, Color.Black, ButtonBorderStyle.Solid)
				End If
			End If
		End If

		If Me.theText <> "" Then
			Dim x As Double = Me.Width * 0.5 - (g.MeasureString(Me.theText, Me.Font).Width * 0.5)
			Dim y As Double = Me.Height * 0.5 - (g.MeasureString(Me.theText, Me.Font).Height * 0.5)
			TextRenderer.DrawText(g, Me.theText, Me.Font, New Point(CInt(x), CInt(y)), Me.ForeColor)
		End If

	End Sub

	Private theText As String

End Class
