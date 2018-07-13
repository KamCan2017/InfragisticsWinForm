namespace WinFormsMod
{
    partial class MainForm
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.ultraTilePanel1 = new Infragistics.Win.Misc.UltraTilePanel();
            this.ultraTabControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraTabPageControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).BeginInit();
            this.ultraTilePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).BeginInit();
            this.ultraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraTabPageControl3
            // 
            this.ultraTabPageControl3.Controls.Add(this.ultraTilePanel1);
            this.ultraTabPageControl3.Location = new System.Drawing.Point(24, 1);
            this.ultraTabPageControl3.Name = "ultraTabPageControl3";
            this.ultraTabPageControl3.Size = new System.Drawing.Size(1083, 446);
            // 
            // ultraTilePanel1
            // 
            appearance1.BackColor = System.Drawing.Color.Thistle;
            this.ultraTilePanel1.Appearance = appearance1;
            this.ultraTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraTilePanel1.Name = "ultraTilePanel1";
            this.ultraTilePanel1.NormalModeDimensions = new System.Drawing.Size(0, 0);
            this.ultraTilePanel1.Size = new System.Drawing.Size(1083, 446);
            this.ultraTilePanel1.TabIndex = 0;
            // 
            // ultraTabControl1
            // 
            appearance2.BackColor = System.Drawing.Color.White;
            this.ultraTabControl1.ActiveTabAppearance = appearance2;
            appearance3.BackColor = System.Drawing.Color.White;
            this.ultraTabControl1.Appearance = appearance3;
            this.ultraTabControl1.Controls.Add(this.ultraTabSharedControlsPage1);
            this.ultraTabControl1.Controls.Add(this.ultraTabPageControl3);
            this.ultraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ultraTabControl1.Name = "ultraTabControl1";
            this.ultraTabControl1.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.ultraTabControl1.Size = new System.Drawing.Size(1110, 450);
            this.ultraTabControl1.TabIndex = 0;
            this.ultraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.LeftTop;
            appearance4.BackColor = System.Drawing.Color.Thistle;
            ultraTab3.ActiveAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.Thistle;
            appearance5.BackColor2 = System.Drawing.Color.Thistle;
            ultraTab3.Appearance = appearance5;
            ultraTab3.Key = "Home";
            ultraTab3.TabPage = this.ultraTabPageControl3;
            ultraTab3.Text = "Home";
            this.ultraTabControl1.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab3});
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(1083, 446);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.ultraTabControl1);
            this.Name = "MainForm";
            this.Text = "WinFormMod";
            this.ultraTabPageControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).EndInit();
            this.ultraTilePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabControl1)).EndInit();
            this.ultraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinTabControl.UltraTabControl ultraTabControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
        private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel1;
    }
}

