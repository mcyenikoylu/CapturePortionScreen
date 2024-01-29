using DevExpress.XtraEditors;
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
            try
            {
                ribbonControl1.AutoSizeItems = true;
                ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
                ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
                ribbonControl1.ShowToolbarCustomizeItem = false;
                ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
                ribbonControl1.ShowQatLocationSelector = false;
                ribbonControl1.AllowMinimizeRibbon = false;

                //pbCapture.Image = Image.FromFile("path of imge file");

                barStaticItem2.Caption = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapture_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bmp = null;
                Cursor.Current = Cursors.WaitCursor;
                SelectArea frm = new SelectArea();
                //this.WindowState = FormWindowState.Minimized;
                this.Hide();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Rectangle rect = new Rectangle(Class1.x, Class1.y, Class1.w, Class1.h);
                    bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
                    Graphics g = Graphics.FromImage(bmp);
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, Class1.s, CopyPixelOperation.SourceCopy);

                    pbCapture.BeginInvoke(new MethodInvoker(delegate
                    {
                        pbCapture.Image = bmp;
                    }));
                }
                //this.WindowState = FormWindowState.Normal;
                this.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bmp == null)
                {
                    XtraMessageBox.Show("No images captured yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.CheckPathExists = true;
                sfd.FileName = "Capture_" + DateTime.Now.ToShortDateString().Replace("/", "").Replace("-", "") + "_" + DateTime.Now.ToShortTimeString().Replace(".", "").Replace(":", "").Replace(" ", "");
                sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (bmp != null)
                        pbCapture.Image.Save(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info frm = new Info();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e == null || e.CloseReason == CloseReason.UserClosing)
                {
                    if (XtraMessageBox.Show("Are you sure you want to close the program?", "Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else if (e != null)
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                //Classes.Functions.logger.Error(ex, "");
                XtraMessageBox.Show("Error Message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
