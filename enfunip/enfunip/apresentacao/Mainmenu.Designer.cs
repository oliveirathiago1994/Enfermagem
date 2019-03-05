namespace enfunip.apresentacao
{
    partial class FrmMainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainmenu));
            this.imglogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imglogo
            // 
            this.imglogo.BackColor = System.Drawing.Color.Transparent;
            this.imglogo.Enabled = false;
            this.imglogo.Image = global::enfunip.Properties.Resources.logounip3;
            this.imglogo.ImageLocation = "";
            this.imglogo.Location = new System.Drawing.Point(452, 271);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(465, 202);
            this.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imglogo.TabIndex = 0;
            this.imglogo.TabStop = false;
            // 
            // FrmMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 715);
            this.Controls.Add(this.imglogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainmenu";
            this.Text = "Enfermagem Unip";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imglogo;
    }
}