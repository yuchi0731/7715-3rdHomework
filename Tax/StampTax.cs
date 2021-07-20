using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework0717
{
    public partial class StampTax : Form
    {
        public StampTax()
        {
            InitializeComponent();
        }

        private void StampTax_Load(object sender, EventArgs e)
        {
            this.lblrule.Text =
                "銀錢收據－稅率千分之四。"
                + Environment.NewLine
                + "承攬契據－稅率千分之一。"
                + Environment.NewLine
                + "典賣、讓受及分割不動產契據－稅率千分之一。"
                + Environment.NewLine
                + "買賣動產契據－每件新臺幣12元";



            this.Init();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Init();
        }


        private void btnYes_Click(object sender, EventArgs e)
        {
            //取得下拉選單稅率
            decimal perc = (decimal)this.GetTaxPrecentage();

            //取得金額
            string amountText = this.textAmount.Text;
            //decimal amount = Convert.ToDecimal(amountText);
            decimal amount;


            if(perc == 0)
            {
                this.lblamountMsg.ForeColor = Color.Red;
                this.lbltypeMsg.Text = "請正確輸入下拉選單";
                this.lbltypeMsg.Visible = true;
            }

            if (!decimal.TryParse(amountText, out amount))
            {
                this.lblamountMsg.ForeColor = Color.Red;
                this.lblamountMsg.Text = "請輸入試算金額";
                this.lblamountMsg.Visible = true;
            }
            if (perc != 0)
            { this.lbltypeMsg.Visible = false; }

            if (decimal.TryParse(amountText, out amount))

            {
                this.lblamountMsg.Visible = false;
            }

            //計算結果
                decimal result = amount * perc;

            if (result < 1)
            {
                
                result = 0;
            }
            else if (result > 1)
            {
                
                result = Math.Truncate(result); //去掉小數點後
            }



            this.lblResult.Text = $"{result.ToString("#,0")} 元";



        }





        private void Init ()
        {
            this.textAmount.Text = "0";
            this.cboType.SelectedIndex = 0;
            this.lblResult.Text = "0 元";
            this.lblamountMsg.Visible = false;
            this.lbltypeMsg.Visible = false;
        }

        private double GetTaxPrecentage()
        {
            if (this.cboType.SelectedIndex == -1)
            {
                return 0;
            }

            
            string taxType = this.cboType.Text;
            
            switch (taxType)
            { 
                case "銀錢收據":
                    return 0.004;

                case "承攬契據":
                    return 0.001;

                case "典賣、讓受及分割不動產契據":
                    return 0.001;
                default:
                    return 0;
                    
            }
        
        
        
        }

        private void tsbFontColor_ButtonClick(object sender, EventArgs e)
        {

        }



 

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 黑ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (this.lblResult.Text != "")
            {
                this.lblResult.ForeColor = Color.Black;
            }
        }

        private void 紅色ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.lblResult.Text != "")
            {
                this.lblResult.ForeColor = Color.Red;
            }
        }

        private void 綠色ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.lblResult.Text != "")
            {
                this.lblResult.ForeColor = Color.Green;
            }
        }

        private void 藍色ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.lblResult.Text != "")
            {
                this.lblResult.ForeColor = Color.Blue;
            }
        }
    }
}
