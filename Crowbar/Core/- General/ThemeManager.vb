Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Collections.Generic

Public Module ThemeManager

    <DllImport("uxtheme.dll", ExactSpelling:=True, CharSet:=CharSet.Unicode)>
    Private Function SetWindowTheme(ByVal hwnd As IntPtr, ByVal pszSubAppName As String, ByVal pszSubIdList As String) As Integer
    End Function

    <DllImport("dwmapi.dll", PreserveSig:=True)>
    Private Function DwmSetWindowAttribute(ByVal hwnd As IntPtr, ByVal attr As Integer, ByRef attrValue As Integer, ByVal attrSize As Integer) As Integer
    End Function

    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 As Integer = 19
    Private Const DWMWA_USE_IMMERSIVE_DARK_MODE As Integer = 20

    Public ReadOnly DarkBackground As Color = Color.FromArgb(45, 45, 48)
    Public ReadOnly DarkForeground As Color = Color.White
    Public ReadOnly DarkControl As Color = Color.FromArgb(30, 30, 30)
    Public ReadOnly DarkButton As Color = Color.FromArgb(62, 62, 66)
    Public ReadOnly DarkBorder As Color = Color.FromArgb(85, 85, 85)
    Public ReadOnly DarkHighlight As Color = Color.FromArgb(0, 120, 215)

    Private _tabHooks As New List(Of TabControlDarkizer)()

    Public Sub ApplyTheme(ByVal parent As Control, ByVal isDark As Boolean)
        If Not isDark Then Return
        
        If TypeOf parent Is Form Then
            Dim frm As Form = DirectCast(parent, Form)
            If frm.IsHandleCreated Then
                ApplyDarkTitleBarToForm(frm)
            Else
                AddHandler frm.HandleCreated, Sub(sender As Object, e As EventArgs) ApplyDarkTitleBarToForm(frm)
            End If
        End If

        ApplyThemeToControl(parent)
    End Sub

    Private Sub ApplyThemeToControl(ByVal ctrl As Control)
        ctrl.BackColor = DarkBackground
        ctrl.ForeColor = DarkForeground

        Try
            SetWindowTheme(ctrl.Handle, "DarkMode_Explorer", Nothing)
        Catch
        End Try

        If TypeOf ctrl Is Button Then
            Dim btn As Button = DirectCast(ctrl, Button) 
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = DarkBorder
            btn.FlatAppearance.BorderSize = 1
            btn.BackColor = DarkButton
            ' 增加悬停反馈
            btn.FlatAppearance.MouseOverBackColor = DarkHighlight
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 160)

        ElseIf TypeOf ctrl Is TabControl Then
            Dim tabCtrl As TabControl = DirectCast(ctrl, TabControl)
            tabCtrl.DrawMode = TabDrawMode.OwnerDrawFixed
            tabCtrl.Appearance = TabAppearance.Normal
            
            RemoveHandler tabCtrl.DrawItem, AddressOf TabControl_DrawItem
            AddHandler tabCtrl.DrawItem, AddressOf TabControl_DrawItem

            Dim attachDarkizer As Action = Sub()
                                               _tabHooks.RemoveAll(Function(hook As TabControlDarkizer) hook.AssociatedControl Is tabCtrl)
                                               _tabHooks.Add(New TabControlDarkizer(tabCtrl))
                                           End Sub
                                           
            If tabCtrl.IsHandleCreated Then
                attachDarkizer.Invoke()
            End If
            AddHandler tabCtrl.HandleCreated, Sub(sender As Object, e As EventArgs) attachDarkizer.Invoke()

        ElseIf TypeOf ctrl Is TabPage Then
            Dim tp As TabPage = DirectCast(ctrl, TabPage)
            tp.BackColor = DarkBackground 
            tp.ForeColor = DarkForeground
            tp.UseVisualStyleBackColor = False
            tp.BorderStyle = BorderStyle.None

        ElseIf TypeOf ctrl Is GroupBox Then
            Dim gb As GroupBox = DirectCast(ctrl, GroupBox)
            gb.BackColor = DarkBackground
            gb.ForeColor = DarkForeground
            gb.FlatStyle = FlatStyle.Flat
            RemoveHandler gb.Paint, AddressOf GroupBox_Paint
            AddHandler gb.Paint, AddressOf GroupBox_Paint

        ElseIf TypeOf ctrl Is ComboBox Then
            Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
            cmb.BackColor = DarkControl
            cmb.ForeColor = DarkForeground
            cmb.FlatStyle = FlatStyle.Flat
            cmb.DrawMode = DrawMode.OwnerDrawFixed
            RemoveHandler cmb.DrawItem, AddressOf ComboBox_DrawItem
            AddHandler cmb.DrawItem, AddressOf ComboBox_DrawItem

        ElseIf TypeOf ctrl Is TextBoxBase Then
            Dim txt As TextBoxBase = DirectCast(ctrl, TextBoxBase)
            txt.BackColor = DarkControl
            txt.ForeColor = DarkForeground
            txt.BorderStyle = BorderStyle.FixedSingle 

        ElseIf TypeOf ctrl Is NumericUpDown Then
            Dim num As NumericUpDown = DirectCast(ctrl, NumericUpDown)
            num.BackColor = DarkControl
            num.ForeColor = DarkForeground
            num.BorderStyle = BorderStyle.FixedSingle

        ElseIf TypeOf ctrl Is DataGridView Then
            Dim dgv As DataGridView = DirectCast(ctrl, DataGridView) 
            dgv.EnableHeadersVisualStyles = False
            dgv.BackgroundColor = DarkBackground
            dgv.GridColor = DarkBorder 
            dgv.BorderStyle = BorderStyle.FixedSingle

            dgv.DefaultCellStyle.BackColor = DarkControl
            dgv.DefaultCellStyle.ForeColor = DarkForeground
            dgv.DefaultCellStyle.SelectionBackColor = DarkHighlight
            
            dgv.RowsDefaultCellStyle.BackColor = DarkControl
            dgv.RowsDefaultCellStyle.ForeColor = DarkForeground
            dgv.AlternatingRowsDefaultCellStyle.BackColor = DarkControl
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = DarkForeground
            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = DarkButton
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = DarkForeground
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            
            dgv.RowHeadersDefaultCellStyle.BackColor = DarkButton
            dgv.RowHeadersDefaultCellStyle.ForeColor = DarkForeground
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        ElseIf TypeOf ctrl Is TreeView Then
            Dim tv As TreeView = DirectCast(ctrl, TreeView)
            tv.BackColor = DarkControl
            tv.ForeColor = DarkForeground
            tv.BorderStyle = BorderStyle.FixedSingle
        End If

        For Each child As Control In ctrl.Controls
            ApplyThemeToControl(child)
        Next
    End Sub

    Private Sub GroupBox_Paint(sender As Object, e As PaintEventArgs)
        Dim gb As GroupBox = DirectCast(sender, GroupBox)
        Dim g As Graphics = e.Graphics
        
        g.Clear(gb.BackColor)
        Dim textRect As SizeF = g.MeasureString(gb.Text, gb.Font)
        
        Dim borderRect As New Rectangle(0, CInt(textRect.Height / 2), gb.Width - 1, gb.Height - CInt(textRect.Height / 2) - 1)
        Using borderPen As New Pen(DarkBorder)
            g.DrawRectangle(borderPen, borderRect)
        End Using
        
        If Not String.IsNullOrEmpty(gb.Text) Then
            Using bgBrush As New SolidBrush(gb.BackColor)
                g.FillRectangle(bgBrush, 6, 0, CInt(textRect.Width) + 4, CInt(textRect.Height))
            End Using
            
            Using textBrush As New SolidBrush(gb.ForeColor)
                g.DrawString(gb.Text, gb.Font, textBrush, 8, 0)
            End Using
        End If
    End Sub

    Private Sub ComboBox_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        If e.Index < 0 Then Return

        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        Dim isSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim bgColor As Color = If(isSelected, DarkHighlight, DarkControl)
        Dim itemText As String = cmb.GetItemText(cmb.Items(e.Index))

        Using bgBrush As New SolidBrush(bgColor),
              textBrush As New SolidBrush(DarkForeground),
              format As New StringFormat() With {.LineAlignment = StringAlignment.Center}
              
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
            
            Dim textRect As Rectangle = e.Bounds
            textRect.X += 2
            e.Graphics.DrawString(itemText, e.Font, textBrush, textRect, format)
        End Using
    End Sub

    Private Sub TabControl_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        Dim tabCtrl As TabControl = DirectCast(sender, TabControl)
        If e.Index < 0 OrElse e.Index >= tabCtrl.TabPages.Count Then Return

        Dim tabPage As TabPage = tabCtrl.TabPages(e.Index)
        Dim tabBounds As Rectangle = tabCtrl.GetTabRect(e.Index)
        Dim isSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim bgColor As Color = If(isSelected, DarkControl, DarkBackground)

        Using bgBrush As New SolidBrush(bgColor),
              textBrush As New SolidBrush(DarkForeground),
              borderPen As New Pen(DarkBorder),
              format As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

            e.Graphics.FillRectangle(bgBrush, tabBounds)
            e.Graphics.DrawRectangle(borderPen, tabBounds.X, tabBounds.Y, tabBounds.Width - 1, tabBounds.Height - 1)
            e.Graphics.DrawString(tabPage.Text, tabCtrl.Font, textBrush, tabBounds, format)
        End Using
    End Sub

    Private Sub ApplyDarkTitleBarToForm(ByVal frm As Form)
        Try
            Dim isDarkMode As Integer = 1
            Dim res As Integer = DwmSetWindowAttribute(frm.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, isDarkMode, Marshal.SizeOf(isDarkMode))
            If res <> 0 Then
                DwmSetWindowAttribute(frm.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1, isDarkMode, Marshal.SizeOf(isDarkMode))
            End If
        Catch
        End Try
    End Sub

    Private Class TabControlDarkizer
        Inherits NativeWindow

        Public ReadOnly AssociatedControl As TabControl

        Public Sub New(tc As TabControl)
            AssociatedControl = tc
            Me.AssignHandle(tc.Handle)
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)

            If m.Msg = &H000F Then
                Try
                    Using g As Graphics = Graphics.FromHwnd(Me.Handle)
                        Dim clientRect As Rectangle = AssociatedControl.ClientRectangle
                        
                        Using borderPen As New Pen(DarkBorder, 2)
                            g.DrawRectangle(borderPen, 1, 1, clientRect.Width - 2, clientRect.Height - 2)
                        End Using
                        
                        If AssociatedControl.TabCount > 0 Then
                            Dim lastTabRect As Rectangle = AssociatedControl.GetTabRect(AssociatedControl.TabCount - 1)
                            Dim emptyRect As New Rectangle(lastTabRect.Right, 0, clientRect.Width - lastTabRect.Right, lastTabRect.Bottom)
                            If emptyRect.Width > 0 AndAlso emptyRect.Height > 0 Then
                                Using bgBrush As New SolidBrush(DarkBackground)
                                    g.FillRectangle(bgBrush, emptyRect)
                                End Using
                            End If
                        End If
                    End Using
                Catch
                End Try
            End If
        End Sub
    End Class

End Module