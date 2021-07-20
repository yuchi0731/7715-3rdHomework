
namespace Homework0717
{
    partial class usermemoform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usermemoform));
            this.textememo = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbFontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.黑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.紅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textememo
            // 
            this.textememo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.textememo.Location = new System.Drawing.Point(174, 135);
            this.textememo.Multiline = true;
            this.textememo.Name = "textememo";
            this.textememo.Size = new System.Drawing.Size(589, 511);
            this.textememo.TabIndex = 0;
            this.textememo.Text = "記點東西～～～?";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(118, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 50);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "記事本";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFontColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbFontColor
            // 
            this.tsbFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑ToolStripMenuItem,
            this.紅色ToolStripMenuItem,
            this.綠色ToolStripMenuItem,
            this.藍色ToolStripMenuItem});
            this.tsbFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontColor.Image")));
            this.tsbFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontColor.Name = "tsbFontColor";
            this.tsbFontColor.Size = new System.Drawing.Size(71, 22);
            this.tsbFontColor.Text = "文字顏色";
            // 
            // 黑ToolStripMenuItem
            // 
            this.黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            this.黑ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.黑ToolStripMenuItem.Text = "黑色";
            this.黑ToolStripMenuItem.Click += new System.EventHandler(this.黑ToolStripMenuItem_Click);
            // 
            // 紅色ToolStripMenuItem
            // 
            this.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            this.紅色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.紅色ToolStripMenuItem.Text = "紅色";
            this.紅色ToolStripMenuItem.Click += new System.EventHandler(this.紅色ToolStripMenuItem_Click);
            // 
            // 綠色ToolStripMenuItem
            // 
            this.綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            this.綠色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.綠色ToolStripMenuItem.Text = "綠色";
            this.綠色ToolStripMenuItem.Click += new System.EventHandler(this.綠色ToolStripMenuItem_Click);
            // 
            // 藍色ToolStripMenuItem
            // 
            this.藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            this.藍色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.藍色ToolStripMenuItem.Text = "藍色";
            this.藍色ToolStripMenuItem.Click += new System.EventHandler(this.藍色ToolStripMenuItem_Click);
            // 
            // usermemoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textememo);
            this.Name = "usermemoform";
            this.Text = "記事本";
            this.Load += new System.EventHandler(this.usermemoform_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textememo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsbFontColor;
        private System.Windows.Forms.ToolStripMenuItem 黑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 紅色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍色ToolStripMenuItem;
    }
}