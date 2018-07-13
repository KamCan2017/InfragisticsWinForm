namespace Customers.Views
{
    partial class CustomersView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.SuspendLayout();
            // 
            // ultraButton1
            // 
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BackColor2 = System.Drawing.Color.Transparent;
            appearance1.ForeColor = System.Drawing.Color.Black;
            this.ultraButton1.Appearance = appearance1;
            this.ultraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.FlatBorderless;
            this.ultraButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appearance2.BackColor = System.Drawing.Color.White;
            this.ultraButton1.HotTrackAppearance = appearance2;
            this.ultraButton1.Location = new System.Drawing.Point(18, 186);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(172, 155);
            this.ultraButton1.TabIndex = 0;
            this.ultraButton1.Text = "Europe";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ultraButton2
            // 
            this.ultraButton2.Location = new System.Drawing.Point(208, 14);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(172, 155);
            this.ultraButton2.TabIndex = 1;
            this.ultraButton2.Text = "Nord America";
            this.ultraButton2.Click += new System.EventHandler(this.ultraButton2_Click);
            // 
            // ultraButton3
            // 
            this.ultraButton3.Location = new System.Drawing.Point(18, 14);
            this.ultraButton3.Name = "ultraButton3";
            this.ultraButton3.Size = new System.Drawing.Size(172, 155);
            this.ultraButton3.TabIndex = 2;
            this.ultraButton3.Text = "Africa";
            this.ultraButton3.Click += new System.EventHandler(this.ultraButton3_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.ultraButton3);
            this.Controls.Add(this.ultraButton2);
            this.Controls.Add(this.ultraButton1);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(947, 355);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraButton ultraButton2;
        private Infragistics.Win.Misc.UltraButton ultraButton3;
    }
}
