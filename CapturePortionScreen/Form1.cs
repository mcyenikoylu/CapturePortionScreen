using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapturePortionScreen
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Bitmap bmp;
        //public static Int32 x;
        //public static Int32 y;
        //public static Int32 w;
        //public static Int32 h;
        //public static Size s;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapture_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectArea frm = new SelectArea();
            frm.ShowDialog();
            //this.Hide();
            if (frm.DialogResult == DialogResult.OK)
            {
                //this.Show();
                Rectangle rect = new Rectangle(Class1.x, Class1.y, Class1.w, Class1.h);
                bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                Graphics g = Graphics.FromImage(bmp);
                g.CopyFromScreen(rect.Left, rect.Top, 0, 0, Class1.s, CopyPixelOperation.SourceCopy);

                pbCapture.BeginInvoke(new MethodInvoker(delegate
                {
                    pbCapture.Image = bmp;
                }));
            }
        }
    }
}
