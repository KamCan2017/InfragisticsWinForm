namespace Settings.Views
{
    partial class SettingsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ultraCheckEditor1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraCheckEditor2 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraCheckEditor3 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraCheckEditor4 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resources";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1094, 2);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Language";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "German",
            "English",
            "French",
            "Swaeli"});
            this.comboBox1.Location = new System.Drawing.Point(140, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Rights";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(19, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1094, 2);
            this.label5.TabIndex = 6;
            // 
            // ultraCheckEditor1
            // 
            this.ultraCheckEditor1.Location = new System.Drawing.Point(22, 263);
            this.ultraCheckEditor1.Name = "ultraCheckEditor1";
            this.ultraCheckEditor1.Size = new System.Drawing.Size(120, 35);
            this.ultraCheckEditor1.TabIndex = 7;
            this.ultraCheckEditor1.Text = "Admin";
            // 
            // ultraCheckEditor2
            // 
            this.ultraCheckEditor2.Location = new System.Drawing.Point(213, 263);
            this.ultraCheckEditor2.Name = "ultraCheckEditor2";
            this.ultraCheckEditor2.Size = new System.Drawing.Size(120, 35);
            this.ultraCheckEditor2.TabIndex = 8;
            this.ultraCheckEditor2.Text = "Guest";
            // 
            // ultraCheckEditor3
            // 
            this.ultraCheckEditor3.Location = new System.Drawing.Point(213, 304);
            this.ultraCheckEditor3.Name = "ultraCheckEditor3";
            this.ultraCheckEditor3.Size = new System.Drawing.Size(120, 35);
            this.ultraCheckEditor3.TabIndex = 9;
            this.ultraCheckEditor3.Text = "Team Leader";
            // 
            // ultraCheckEditor4
            // 
            this.ultraCheckEditor4.Location = new System.Drawing.Point(22, 304);
            this.ultraCheckEditor4.Name = "ultraCheckEditor4";
            this.ultraCheckEditor4.Size = new System.Drawing.Size(170, 35);
            this.ultraCheckEditor4.TabIndex = 10;
            this.ultraCheckEditor4.Text = "Production Leader";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.ultraCheckEditor4);
            this.Controls.Add(this.ultraCheckEditor3);
            this.Controls.Add(this.ultraCheckEditor2);
            this.Controls.Add(this.ultraCheckEditor1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(1173, 516);
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCheckEditor4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor2;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor3;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ultraCheckEditor4;
    }
}
