Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace SkinImages
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			comboBoxEdit1.EditValue = defaultLookAndFeel1.LookAndFeel.SkinName
			For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
				comboBoxEdit1.Properties.Items.Add(cnt.SkinName)
			Next cnt
			GetImages()
		End Sub
		Private Sub comboBoxEdit1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEdit1.SelectedValueChanged
			defaultLookAndFeel1.LookAndFeel.SkinName = comboBoxEdit1.Text
			GetImages()
		End Sub

		Public Sub GetImages()
			Dim currentSkin As DevExpress.Skins.Skin
			Dim element As DevExpress.Skins.SkinElement
			Dim elementName As String
			currentSkin = DevExpress.Skins.EditorsSkins.GetSkin(defaultLookAndFeel1.LookAndFeel)
			elementName = DevExpress.Skins.EditorsSkins.SkinCheckBox
			element = currentSkin(elementName)
			Dim image As Image = element.Image.Image
			pictureEdit1.Image = image
			Dim images As DevExpress.Utils.ImageCollection = element.Image.GetImages()

			navBarControl1.SmallImages = images
			navBarControl1.Items.Clear()
			For i As Integer = 0 To images.Images.Count - 1
				Dim item As DevExpress.XtraNavBar.NavBarItem = navBarControl1.Items.Add()
				item.SmallImageIndex = i
				navBarGroup1.ItemLinks.Add(item)
			Next i
		End Sub
	End Class
End Namespace