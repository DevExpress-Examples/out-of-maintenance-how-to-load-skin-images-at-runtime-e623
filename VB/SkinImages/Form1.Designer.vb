Imports Microsoft.VisualBasic
Imports System
Namespace SkinImages
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.label2 = New System.Windows.Forms.Label()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.EditValue = "comboBoxEdit1"
			Me.comboBoxEdit1.Location = New System.Drawing.Point(88, 16)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEdit1.Size = New System.Drawing.Size(200, 20)
			Me.comboBoxEdit1.TabIndex = 2
'			Me.comboBoxEdit1.SelectedValueChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedValueChanged);
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(16, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(72, 16)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Active Skin:"
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.Location = New System.Drawing.Point(16, 72)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Size = New System.Drawing.Size(104, 272)
			Me.pictureEdit1.TabIndex = 5
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(16, 48)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(100, 23)
			Me.label2.TabIndex = 6
			Me.label2.Text = "CheckBox Images:"
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1})
			Me.navBarControl1.Location = New System.Drawing.Point(144, 48)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 144
			Me.navBarControl1.Size = New System.Drawing.Size(144, 296)
			Me.navBarControl1.TabIndex = 7
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(686, 423)
			Me.Controls.Add(Me.navBarControl1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.pictureEdit1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As System.Windows.Forms.Label
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private label2 As System.Windows.Forms.Label
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private components As System.ComponentModel.IContainer
	End Class
End Namespace

