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
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnCaptureThis = new System.Windows.Forms.Button();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.Controls.Add(this.btnCaptureThis);
            this.panelDrag.Location = new System.Drawing.Point(43, 33);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(202, 199);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            // 
            // btnCaptureThis
            // 
            this.btnCaptureThis.Location = new System.Drawing.Point(0, 0);
            this.btnCaptureThis.Name = "btnCaptureThis";
            this.btnCaptureThis.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureThis.TabIndex = 0;
            this.btnCaptureThis.Text = "button1";
            this.btnCaptureThis.UseVisualStyleBackColor = true;
            this.btnCaptureThis.Click += new System.EventHandler(this.btnCaptureThis_Click);
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.panelDrag);
            this.Name = "SelectArea";
            this.Text = "SelectArea";
            this.Load += new System.EventHandler(this.SelectArea_Load);
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Button btnCaptureThis;
    }
}