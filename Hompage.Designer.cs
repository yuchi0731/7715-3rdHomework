
namespace Homework0717
{
    partial class Hompage
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
            this.usermemo = new System.Windows.Forms.Button();
            this.btnStampTax = new System.Windows.Forms.Button();
            this.btnLicenseTax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictmony = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictmony)).BeginInit();
            this.SuspendLayout();
            // 
            // usermemo
            // 
            this.usermemo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usermemo.Location = new System.Drawing.Point(75, 516);
            this.usermemo.Name = "usermemo";
            this.usermemo.Size = new System.Drawing.Size(270, 65);
            this.usermemo.TabIndex = 16;
            this.usermemo.Text = "記事本";
            this.usermemo.UseVisualStyleBackColor = true;
            this.usermemo.Click += new System.EventHandler(this.usermemo_Click);
            // 
            // btnStampTax
            // 
            this.btnStampTax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStampTax.Location = new System.Drawing.Point(75, 372);
            this.btnStampTax.Name = "btnStampTax";
            this.btnStampTax.Size = new System.Drawing.Size(270, 65);
            this.btnStampTax.TabIndex = 13;
            this.btnStampTax.Text = "印花稅(StampTax)";
            this.btnStampTax.UseVisualStyleBackColor = true;
            this.btnStampTax.Click += new System.EventHandler(this.btnStampTax_Click);
            // 
            // btnLicenseTax
            // 
            this.btnLicenseTax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLicenseTax.Location = new System.Drawing.Point(75, 235);
            this.btnLicenseTax.Name = "btnLicenseTax";
            this.btnLicenseTax.Size = new System.Drawing.Size(270, 65);
            this.btnLicenseTax.TabIndex = 12;
            this.btnLicenseTax.Text = "牌照稅(LicenseTax)";
            this.btnLicenseTax.UseVisualStyleBackColor = true;
            this.btnLicenseTax.Click += new System.EventHandler(this.btnLicenseTax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(319, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "歡迎使用-稅務試算表";
            // 
            // pictmony
            // 
            this.pictmony.Image = global::Homework0717.Properties.Resources.money;
            this.pictmony.Location = new System.Drawing.Point(415, 201);
            this.pictmony.Name = "pictmony";
            this.pictmony.Size = new System.Drawing.Size(476, 420);
            this.pictmony.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictmony.TabIndex = 18;
            this.pictmony.TabStop = false;
            // 
            // Hompage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pictmony);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usermemo);
            this.Controls.Add(this.btnStampTax);
            this.Controls.Add(this.btnLicenseTax);
            this.Name = "Hompage";
            this.Text = "Hompage";
            ((System.ComponentModel.ISupportInitialize)(this.pictmony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usermemo;
        private System.Windows.Forms.Button btnStampTax;
        private System.Windows.Forms.Button btnLicenseTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictmony;
    }
}