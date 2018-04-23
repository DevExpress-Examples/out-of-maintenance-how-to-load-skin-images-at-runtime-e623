using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SkinImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            comboBoxEdit1.EditValue = defaultLookAndFeel1.LookAndFeel.SkinName;
            foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
            {
                comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
            }
            GetImages();
        }
        private void comboBoxEdit1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = comboBoxEdit1.Text;
            GetImages();
        }

        public void GetImages()
        {
            DevExpress.Skins.Skin currentSkin;
            DevExpress.Skins.SkinElement element;
            string elementName;
            currentSkin = DevExpress.Skins.EditorsSkins.GetSkin(defaultLookAndFeel1.LookAndFeel);
            elementName = DevExpress.Skins.EditorsSkins.SkinCheckBox;
            element = currentSkin[elementName];
            Image image = element.Image.Image;
            pictureEdit1.Image = image;
            DevExpress.Utils.ImageCollection images = element.Image.GetImages();

            navBarControl1.SmallImages = images;
            navBarControl1.Items.Clear();
            for (int i = 0; i < images.Images.Count; i++)
            {
                DevExpress.XtraNavBar.NavBarItem item = navBarControl1.Items.Add();
                item.SmallImageIndex = i;
                navBarGroup1.ItemLinks.Add(item);
            }
        }
    }
}