using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CapturePortionScreen
{
    public partial class Info : DevExpress.XtraEditors.XtraForm
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}