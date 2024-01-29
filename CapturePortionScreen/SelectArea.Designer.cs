namespace CapturePortionScreen
{
    partial class SelectArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectArea));
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnCaptureScreen = new DevExpress.XtraEditors.SimpleButton();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.Controls.Add(this.btnCaptureScreen);
            this.panelDrag.Location = new System.Drawing.Point(12, 12);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(202, 55);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            // 
            // btnCaptureScreen
            // 
            this.btnCaptureScreen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCaptureScreen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCaptureScreen.ImageOptions.SvgImage")));
            this.btnCaptureScreen.Location = new System.Drawing.Point(0, 0);
            this.btnCaptureScreen.Name = "btnCaptureScreen";
            this.btnCaptureScreen.Size = new System.Drawing.Size(148, 48);
            this.btnCaptureScreen.TabIndex = 1;
            this.btnCaptureScreen.Text = "Capture this";
            this.btnCaptureScreen.Click += new System.EventHandler(this.btnCaptureThis_Click);
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 77);
            this.Controls.Add(this.panelDrag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectArea";
            this.Load += new System.EventHandler(this.SelectArea_Load);
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private DevExpress.XtraEditors.SimpleButton btnCaptureScreen;
    }
}