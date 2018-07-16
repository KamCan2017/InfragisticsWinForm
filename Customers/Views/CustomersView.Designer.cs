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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            this.africaButton = new System.Windows.Forms.Button();
            this.europeButton = new System.Windows.Forms.Button();
            this.nordAmericaButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // africaButton
            // 
            this.africaButton.BackColor = System.Drawing.Color.SlateBlue;
            this.africaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.africaButton.ForeColor = System.Drawing.Color.White;
            this.africaButton.Image = ((System.Drawing.Image)(resources.GetObject("africaButton.Image")));
            this.africaButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.africaButton.Location = new System.Drawing.Point(18, 14);
            this.africaButton.Name = "africaButton";
            this.africaButton.Size = new System.Drawing.Size(197, 165);
            this.africaButton.TabIndex = 3;
            this.africaButton.Text = "Africa";
            this.africaButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.africaButton.UseVisualStyleBackColor = false;
            this.africaButton.Click += new System.EventHandler(this.africaButton_Click);
            // 
            // europeButton
            // 
            this.europeButton.BackColor = System.Drawing.Color.SlateBlue;
            this.europeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.europeButton.ForeColor = System.Drawing.Color.White;
            this.europeButton.Image = ((System.Drawing.Image)(resources.GetObject("europeButton.Image")));
            this.europeButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.europeButton.Location = new System.Drawing.Point(259, 14);
            this.europeButton.Name = "europeButton";
            this.europeButton.Size = new System.Drawing.Size(197, 165);
            this.europeButton.TabIndex = 4;
            this.europeButton.Text = "Europe";
            this.europeButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.europeButton.UseVisualStyleBackColor = false;
            this.europeButton.Click += new System.EventHandler(this.europeButton_Click);
            // 
            // nordAmericaButton
            // 
            this.nordAmericaButton.BackColor = System.Drawing.Color.SlateBlue;
            this.nordAmericaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nordAmericaButton.ForeColor = System.Drawing.Color.White;
            this.nordAmericaButton.Image = ((System.Drawing.Image)(resources.GetObject("nordAmericaButton.Image")));
            this.nordAmericaButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.nordAmericaButton.Location = new System.Drawing.Point(18, 216);
            this.nordAmericaButton.Name = "nordAmericaButton";
            this.nordAmericaButton.Size = new System.Drawing.Size(197, 165);
            this.nordAmericaButton.TabIndex = 5;
            this.nordAmericaButton.Text = "Nord America";
            this.nordAmericaButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.nordAmericaButton.UseVisualStyleBackColor = false;
            this.nordAmericaButton.Click += new System.EventHandler(this.nordAmericaButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SlateBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(259, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 165);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add Customers";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.addCustomers_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nordAmericaButton);
            this.Controls.Add(this.europeButton);
            this.Controls.Add(this.africaButton);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(947, 395);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button africaButton;
        private System.Windows.Forms.Button europeButton;
        private System.Windows.Forms.Button nordAmericaButton;
        private System.Windows.Forms.Button button4;
    }
}
