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
    public partial class LicenseTax : Form
    {
        public LicenseTax()
        {
            InitializeComponent();
        }

        private void LicenseTax_Load(object sender, EventArgs e)
        {
            toolTipinfo.IsBalloon = true;
            toolTipinfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipinfo.ToolTipTitle = "資訊";
            this.cbokind.SelectedIndex = 0;
            this.cboCCmoto.SelectedIndex = 0;
        }

        private void rdoY_CheckedChanged(object sender, EventArgs e) //全年度日期
        {
            this.lblYYMM1.Visible = false;
            this.lblYYMM2.Visible = false;
            this.dTP1.Visible = false;
            this.dTP2.Visible = false;
        }

        private void rdoM_CheckedChanged(object sender, EventArgs e) //期間日期
        {
            this.lblYYMM1.Visible = true;
            this.lblYYMM2.Visible = true;
            this.dTP1.Visible = true;
            this.dTP2.Visible = true;
            this.dTP1.Value = new DateTime(2021, 1, 1);    //設定預設日期
            this.dTP2.Value = new DateTime(2021, 12, 31);

        }

        private void cbokind_SelectedIndexChanged(object sender, EventArgs e) //依車種變更汽缸選單
        {
            string kinddo = this.cbokind.SelectedItem.ToString();

            if (kinddo == "機車")
            {
                this.cboCCmoto.Visible = true;
                this.cboCCt.Visible = false;
                this.cboCCC.Visible = false;
                this.cboCCcar.Visible = false;
                this.cboCCcarpub.Visible = false;
            }

            else if (kinddo == "貨車")
            {
                this.cboCCmoto.Visible = false;
                this.cboCCt.Visible = true;
                this.cboCCC.Visible = false;
                this.cboCCcar.Visible = false;
                this.cboCCcarpub.Visible = false;
                this.cboCCt.SelectedIndex = 0;
            }

            else if (kinddo == "大客車")
            {
                this.cboCCmoto.Visible = false;
                this.cboCCt.Visible = false;
                this.cboCCC.Visible = true;
                this.cboCCcar.Visible = false;
                this.cboCCcarpub.Visible = false;
                this.cboCCC.SelectedIndex = 0;
            }

            else if (kinddo == "自用小客車")
            {
                this.cboCCmoto.Visible = false;
                this.cboCCt.Visible = false;
                this.cboCCC.Visible = false;
                this.cboCCcar.Visible = true;
                this.cboCCcarpub.Visible = false;
                this.cboCCcar.SelectedIndex = 0;
            }

            else if (kinddo == "營業用小客車")
            {
                this.cboCCmoto.Visible = false;
                this.cboCCt.Visible = false;
                this.cboCCC.Visible = false;
                this.cboCCcar.Visible = false;
                this.cboCCcarpub.Visible = true;
                this.cboCCcarpub.SelectedIndex = 0;
            }
        }



        private void btnYes_Click(object sender, EventArgs e) //計算結果
        {
            this.lblAns.Text = string.Empty;

            if (rdoY.Checked == true)  //時間選為全年度
            {
                this.lblarT.Visible = false;

                if (cbokind.Text == "") //檢查有無車種選項
                {
                    this.cboCCmoto.Text = "";
                    this.cboCCt.Text = "";
                    this.cboCCC.Text = "";
                    this.cboCCcar.Text = "";
                    this.cboCCcarpub.Text = "";


                    this.lblarK.Visible = true;
                    this.lblarK.ForeColor = Color.Red;
                    this.lblarK.Text = "請輸入正確車種選單";
                    this.lblAns.ForeColor = Color.Red;
                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                    this.cbokind.SelectedIndex = -1;

                    if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                    {
                        this.lblarCC.Visible = true;
                        this.lblarCC.ForeColor = Color.Red;
                        this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                        if (cbokind.Text == "") //檢查有無車種選項
                        {

                            this.lblarK.Visible = true;
                            this.lblarK.ForeColor = Color.Red;
                            this.lblarK.Text = "請輸入正確車種選單";
                            this.lblAns.ForeColor = Color.Red;
                            this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                            this.cbokind.SelectedIndex = -1;

                            if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                            {
                                this.lblarCC.Visible = true;
                                this.lblarCC.ForeColor = Color.Red;
                                this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                                this.lblAns.ForeColor = Color.Red;
                                this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                            }
                        }
                    }
                    else
                    {
                        this.lblarCC.Visible = false;
                        this.lblarK.Visible = true;
                        this.lblarK.ForeColor = Color.Red;
                        this.lblarK.Text = "請輸入正確車種選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                        this.cbokind.SelectedIndex = -1;
                    }

                }

                if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                {
                    this.lblarCC.Visible = true;
                    this.lblarCC.ForeColor = Color.Red;
                    this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                    this.lblAns.ForeColor = Color.Red;
                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                }


                else
                {
                    BtnAnsYear();
                }

            }

            else if (rdoM.Checked == true) //時間選為期間
            {
                this.lblarT.Visible = false;
                DateTime startDate = this.dTP1.Value;
                DateTime endDate = this.dTP2.Value;

                if (startDate > endDate) //前面日期較大
                {
                    this.lblarT.Visible = true;
                    this.lblarT.ForeColor = Color.Red;
                    this.lblarT.Text = "起始時間須早於截止時間";
                    this.lblAns.ForeColor = Color.Red;
                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                }


                else if (startDate <= endDate)
                {

                    if (cbokind.Text == "") //檢查有無車種選項
                    {
                        this.cboCCmoto.Text = "";
                        this.cboCCt.Text = "";
                        this.cboCCC.Text = "";
                        this.cboCCcar.Text = "";
                        this.cboCCcarpub.Text = "";


                        this.lblarK.Visible = true;
                        this.lblarK.ForeColor = Color.Red;
                        this.lblarK.Text = "請輸入正確車種選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                        this.cbokind.SelectedIndex = -1;

                        if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                        {
                            this.lblarCC.Visible = true;
                            this.lblarCC.ForeColor = Color.Red;
                            this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                            this.lblAns.ForeColor = Color.Red;
                            this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                            if (cbokind.Text == "") //檢查有無車種選項
                            {

                                this.lblarK.Visible = true;
                                this.lblarK.ForeColor = Color.Red;
                                this.lblarK.Text = "請輸入正確車種選單";
                                this.lblAns.ForeColor = Color.Red;
                                this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                                this.cbokind.SelectedIndex = -1;

                                if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                                {
                                    this.lblarCC.Visible = true;
                                    this.lblarCC.ForeColor = Color.Red;
                                    this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                                    this.lblAns.ForeColor = Color.Red;
                                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                                }
                            }
                        }
                        else
                        {
                            this.lblarCC.Visible = false;
                            this.lblarK.Visible = true;
                            this.lblarK.ForeColor = Color.Red;
                            this.lblarK.Text = "請輸入正確車種選單";
                            this.lblAns.ForeColor = Color.Red;
                            this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                            this.cbokind.SelectedIndex = -1;
                        }

                    }

                    if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                    {
                        this.lblarCC.Visible = true;
                        this.lblarCC.ForeColor = Color.Red;
                        this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                    }

                    else
                    {
                        BtnAns();
                    }
                }
            }

            else if (rdoY.Checked == false || rdoM.Checked == false)
            {
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblarT.Visible = true;
                this.lblarT.ForeColor = Color.Red;
                this.lblarT.Text = "請選擇使用期間";
                this.lblAns.ForeColor = Color.Red;
                this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";


                if (cbokind.Text == "") //檢查有無車種選項
                {
                    this.cboCCmoto.Text = "";
                    this.cboCCt.Text = "";
                    this.cboCCC.Text = "";
                    this.cboCCcar.Text = "";
                    this.cboCCcarpub.Text = "";


                    this.lblarK.Visible = true;
                    this.lblarK.ForeColor = Color.Red;
                    this.lblarK.Text = "請輸入正確車種選單";
                    this.lblAns.ForeColor = Color.Red;
                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                    this.cbokind.SelectedIndex = -1;

                    if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                    {
                        this.lblarCC.Visible = true;
                        this.lblarCC.ForeColor = Color.Red;
                        this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                        if (cbokind.Text == "") //檢查有無車種選項
                        {

                            this.lblarK.Visible = true;
                            this.lblarK.ForeColor = Color.Red;
                            this.lblarK.Text = "請輸入正確車種選單";
                            this.lblAns.ForeColor = Color.Red;
                            this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                            this.cbokind.SelectedIndex = -1;

                            if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                            {
                                this.lblarCC.Visible = true;
                                this.lblarCC.ForeColor = Color.Red;
                                this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                                this.lblAns.ForeColor = Color.Red;
                                this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                            }
                        }
                    }
                    else
                    {
                        this.lblarCC.Visible = false;
                        this.lblarK.Visible = true;
                        this.lblarK.ForeColor = Color.Red;
                        this.lblarK.Text = "請輸入正確車種選單";
                        this.lblAns.ForeColor = Color.Red;
                        this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
                        this.cbokind.SelectedIndex = -1;
                    }

                }

                if (cboCCmoto.Text == "" && cboCCt.Text == "" && cboCCC.Text == "" && cboCCcar.Text == "" && cboCCcarpub.Text == "")//檢查有無汽缸選項
                {
                    this.lblarCC.Visible = true;
                    this.lblarCC.ForeColor = Color.Red;
                    this.lblarCC.Text = "請依車種輸入正確汽缸／馬力選單";
                    this.lblAns.ForeColor = Color.Red;
                    this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";

                }

            }

        }



        private void btnClear_Click(object sender, EventArgs e) //清除重填
        {

            this.rdoM.Checked = false;
            this.rdoY.Checked = false;
            this.lblYYMM1.Visible = false;
            this.lblYYMM2.Visible = false;
            this.dTP1.Visible = false;
            this.dTP2.Visible = false;
            this.dTP1.Value = new DateTime(2021, 1, 1);
            this.dTP2.Value = new DateTime(2021, 12, 31);

            this.lblAns.Text = string.Empty;
            this.lblarT.Visible = false;
            this.lblarK.Visible = false;
            this.lblarCC.Visible = false;
            this.cbokind.SelectedIndex = 0;


            this.panelAns.AutoScroll = false;
            this.cboCCmoto.Visible = true;
            this.cboCCt.Visible = false;
            this.cboCCC.Visible = false;
            this.cboCCcar.Visible = false;
            this.cboCCcarpub.Visible = false;
            this.cboCCmoto.SelectedIndex = 0;

        }



        #region Method"BtnAnsYear" AnsforYear
        private void BtnAnsYear()  //年度：試算結果
        {

            //閏月
            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            int lmDays;
            if (isLeapYear == true)
            {
                lmDays = 366;
            }
            else
            {
                lmDays = 365;
            }

            //天數
            DateTime startDate = new DateTime(2021, 1, 1);
            DateTime endDate = new DateTime(2022, 1, 1);

            TimeSpan yeardays = endDate - startDate;
            double days = yeardays.TotalDays;

            //利用TaxCalculatie方法計算稅額
            var taxans = this.TaxCalculatie();
            decimal result = taxans * Convert.ToInt32(days) / Convert.ToInt32(lmDays);

            string kindCCans = this.cbokind.SelectedItem.ToString();

            if (kindCCans == "機車")
            {
                this.panelAns.AutoScroll = false;
                this.lblarT.Visible = false;
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;
                this.lblAns.Text = "使用期間：" + startDate.ToString("yyyy /MM /dd") + "～" + endDate.ToString("yyyy /MM /dd")
                + Environment.NewLine
                + "使用天數：" + days.ToString() + "天"
                + Environment.NewLine
                + "用途：" + this.cbokind.SelectedItem.ToString()
                + Environment.NewLine
                + "汽缸CC數：" + cboCCmoto.SelectedItem.ToString()
                + Environment.NewLine
                + $"計算公式： {taxans.ToString()}*{days.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                + Environment.NewLine
                + $"應繳稅額： {result.ToString("#,0")}元";
            }

            else if (kindCCans == "貨車")
            {
                this.panelAns.AutoScroll = false;
                this.lblarT.Visible = false;
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;
                this.lblAns.Text = "使用期間：" + startDate.ToString("yyyy /MM /dd") + "～" + endDate.ToString("yyyy /MM /dd")
                + Environment.NewLine
                + "使用天數：" + days.ToString() + "天"
                + Environment.NewLine
                + "用途：" + this.cbokind.SelectedItem.ToString()
                + Environment.NewLine
                + "汽缸CC數：" + cboCCt.SelectedItem.ToString()
                + Environment.NewLine
                + $"計算公式： {taxans.ToString()}*{days.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                + Environment.NewLine
                + $"應繳稅額： {result.ToString("#,0")}元";
            }

            else if (kindCCans == "大客車")
            {
                this.panelAns.AutoScroll = false;
                this.lblarT.Visible = false;
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;
                this.lblAns.Text = "使用期間：" + startDate.ToString("yyyy /MM /dd") + "～" + endDate.ToString("yyyy /MM /dd")
                + Environment.NewLine
                + "使用天數：" + days.ToString() + "天"
                + Environment.NewLine
                + "用途：" + this.cbokind.SelectedItem.ToString()
                + Environment.NewLine
                + "汽缸CC數：" + cboCCC.SelectedItem.ToString()
                + Environment.NewLine
                + $"計算公式： {taxans.ToString()}*{days.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                + Environment.NewLine
                + $"應繳稅額： {result.ToString("#,0")}元";
            }

            else if (kindCCans == "自用小客車")
            {
                this.panelAns.AutoScroll = false;
                this.lblarT.Visible = false;
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;
                this.lblAns.Text = "使用期間：" + startDate.ToString("yyyy /MM /dd") + "～" + endDate.ToString("yyyy /MM /dd")
                + Environment.NewLine
                + "使用天數：" + days.ToString() + "天"
                + Environment.NewLine
                + "用途：" + this.cbokind.SelectedItem.ToString()
                + Environment.NewLine
                + "汽缸CC數：" + cboCCcar.SelectedItem.ToString()
                + Environment.NewLine
                + $"計算公式： {taxans.ToString()}*{days.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                + Environment.NewLine
                + $"應繳稅額： {result.ToString("#,0")}元";
            }

            else if (kindCCans == "營業用小客車")
            {            
                this.panelAns.AutoScroll = false;
                this.lblarT.Visible = false;
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;
                this.lblAns.Text = "使用期間：" + startDate.ToString("yyyy /MM /dd") + "～" + endDate.ToString("yyyy /MM /dd")
                + Environment.NewLine
                + "使用天數：" + days.ToString() + "天"
                + Environment.NewLine
                + "用途：" + this.cbokind.SelectedItem.ToString()
                + Environment.NewLine
                + "汽缸CC數：" + cboCCcarpub.SelectedItem.ToString()
                + Environment.NewLine
                + $"計算公式： {taxans.ToString()}*{days.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                + Environment.NewLine
                + $"應繳稅額： {result.ToString("#,0")}元";
            }

        }
        #endregion


        #region Method"BtnAns" AnsforPeriod
        /// <summary>
        /// 利用天數&TaxCalculatie計算結果
        /// </summary>
        /// <returns></returns>
        private void BtnAns() //期間：試算結果
        {
            this.lblAns.Text = string.Empty;
            //需求：
            //從sDate到年底，經過幾個幾年，再從頭到eDate
            //如果滿了一年就要換一段算式
            //最終總額
            //中間還要算閏月


            //第一層判斷，天數是否大於366
            DateTime startDate = this.dTP1.Value;
            DateTime endDate = this.dTP2.Value;
            DateTime dendDate = endDate.AddDays(1); //最後一天+1為了算天數差
            TimeSpan yeardays1 = dendDate - startDate;
            double days366 = yeardays1.TotalDays;
            

            if (startDate <= endDate) //後面日期較大
            {
                
                //開啟關閉一些可見設定
                
                this.lblarK.Visible = false;
                this.lblarCC.Visible = false;
                this.lblAns.ForeColor = Color.Black;

                //若天數大於366天
                if (days366 > 366) //若天數大於366天
                {
                    
                    this.panelAns.AutoScroll = true;

                    #region 第一年
                    //閏月
                    bool isLeapYear1st = DateTime.IsLeapYear(startDate.Year);
                    int lmDays1st;
                    if (isLeapYear1st == true)
                    {
                        lmDays1st = 366;
                    }
                    else
                    {
                        lmDays1st = 365;
                    }



                    //計算天數
                    int stary = startDate.Year;
                    DateTime midstr = new DateTime(stary,12,31); //設定第一年最後一天                  
                    TimeSpan mistatdays = midstr - startDate; //計算開始時間離當年的12/31有幾天

                    double days1st = mistatdays.TotalDays + 1;//計算第一年總天數

                    decimal taxans1st = (decimal)this.TaxCalculatie();
                    decimal result1st = taxans1st * Convert.ToInt32(days1st) / Convert.ToInt32(lmDays1st);


                    var kindst = this.cbokind.SelectedItem.ToString();

                    if (kindst == "機車")
                    {
                        this.lblAns.Text +=
                    "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP1.Value.ToString("yyyy /12 /31")
                    + Environment.NewLine
                    + "使用天數：" + days1st.ToString() + "天"
                    + Environment.NewLine
                    + "用途：" + this.cbokind.SelectedItem as string
                    + Environment.NewLine
                    + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                    + Environment.NewLine
                    + $"計算公式： {taxans1st.ToString()}*{days1st.ToString()}/{lmDays1st.ToString()} = {result1st.ToString("#,0")} 元"
                    + Environment.NewLine
                    + $"應繳稅額： {result1st.ToString("#,0")}元"
                    + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kindst == "貨車")
                    {
                        this.lblAns.Text +=
                    "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP1.Value.ToString("yyyy /12 /31")
                    + Environment.NewLine
                    + "使用天數：" + days1st.ToString() + "天"
                    + Environment.NewLine
                    + "用途：" + this.cbokind.SelectedItem as string
                    + Environment.NewLine
                    + "汽缸CC數：" + this.cboCCt.SelectedItem as string
                    + Environment.NewLine
                    + $"計算公式： {taxans1st.ToString()}*{days1st.ToString()}/{lmDays1st.ToString()} = {result1st.ToString("#,0")} 元"
                    + Environment.NewLine
                    + $"應繳稅額： {result1st.ToString("#,0")}元"
                    + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kindst == "大客車")
                    {
                        this.lblAns.Text +=
                    "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP1.Value.ToString("yyyy /12 /31")
                    + Environment.NewLine
                    + "使用天數：" + days1st.ToString() + "天"
                    + Environment.NewLine
                    + "用途：" + this.cbokind.SelectedItem as string
                    + Environment.NewLine
                    + "汽缸CC數：" + this.cboCCC.SelectedItem as string
                    + Environment.NewLine
                    + $"計算公式： {taxans1st.ToString()}*{days1st.ToString()}/{lmDays1st.ToString()} = {result1st.ToString("#,0")} 元"
                    + Environment.NewLine
                    + $"應繳稅額： {result1st.ToString("#,0")}元"
                    + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kindst == "自用小客車")
                    {
                        this.lblAns.Text +=
                    "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP1.Value.ToString("yyyy /12 /31")
                    + Environment.NewLine
                    + "使用天數：" + days1st.ToString() + "天"
                    + Environment.NewLine
                    + "用途：" + this.cbokind.SelectedItem as string
                    + Environment.NewLine
                    + "汽缸CC數：" + this.cboCCcar.SelectedItem as string
                    + Environment.NewLine
                    + $"計算公式： {taxans1st.ToString()}*{days1st.ToString()}/{lmDays1st.ToString()} = {result1st.ToString("#,0")} 元"
                    + Environment.NewLine
                    + $"應繳稅額： {result1st.ToString("#,0")}元"
                    + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kindst == "營業用小客車")
                    {
                        this.lblAns.Text +=
                    "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP1.Value.ToString("yyyy /12 /31")
                    + Environment.NewLine
                    + "使用天數：" + days1st.ToString() + "天"
                    + Environment.NewLine
                    + "用途：" + this.cbokind.SelectedItem as string
                    + Environment.NewLine
                    + "汽缸CC數：" + this.cboCCcarpub.SelectedItem as string
                    + Environment.NewLine
                    + $"計算公式： {taxans1st.ToString()}*{days1st.ToString()}/{lmDays1st.ToString()} = {result1st.ToString("#,0")} 元"
                    + Environment.NewLine
                    + $"應繳稅額： {result1st.ToString("#,0")}元"
                    + Environment.NewLine + Environment.NewLine;
                    }









                    

                    #endregion


                    #region 中間年份
                    DateTime mistDate = startDate.AddYears(1); //判斷i初始年
                    DateTime mienDate = endDate.AddYears(-1);  //判斷i截止年

                    for (var i = mistDate.Year; i <= mienDate.Year; i++)  //i=起始年+1年 <=最後年-1年
                    {
                        int[] ia = { i };
                        decimal sum = 0;
                        foreach (var items in ia)
                        {
                            
                            DateTime formidyearst = new DateTime(i, 01 , 01); //中間年份第一天
                            DateTime formidyeared = new DateTime(i , 12 , 31); //中間年份最後天

                            bool midisLeapYear = DateTime.IsLeapYear(i);  //確認第i年是否為閏月
                            int midlmDays;
                            if (midisLeapYear == true)
                            {
                                midlmDays = 366;
                            }
                            else
                            {
                                midlmDays = 365;
                            }

                            //計算天數，因都是整年直接帶 midlmDays
                            decimal midtaxans = (decimal)this.TaxCalculatie();
                            decimal midresult = midtaxans * Convert.ToInt32(midlmDays) / Convert.ToInt32(midlmDays);


                            //結果輸出

                            string kind366 = this.cbokind.SelectedItem.ToString();

                            if (kind366 == "機車")
                            {
                                this.lblAns.Text +=
                                  "使用期間：" + formidyearst.ToString($"{i} /MM /dd") + "～" + formidyeared.ToString($"{i} / MM / dd")
                                  + Environment.NewLine
                                  + "使用天數：" + midlmDays.ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {midtaxans.ToString()}*{midlmDays.ToString()}/{midlmDays.ToString()} = {midresult.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {midresult.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kind366 == "貨車")
                            {
                                this.lblAns.Text +=
                                  "使用期間：" + formidyearst.ToString($"{i} /MM /dd") + "～" + formidyeared.ToString($"{i} / MM / dd")
                                  + Environment.NewLine
                                  + "使用天數：" + midlmDays.ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {midtaxans.ToString()}*{midlmDays.ToString()}/{midlmDays.ToString()} = {midresult.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {midresult.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kind366 == "大客車")
                            {
                                this.lblAns.Text +=
                                  "使用期間：" + formidyearst.ToString($"{i} /MM /dd") + "～" + formidyeared.ToString($"{ i} / MM / dd")
                                  + Environment.NewLine
                                  + "使用天數：" + midlmDays.ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {midtaxans.ToString()}*{midlmDays.ToString()}/{midlmDays.ToString()} = {midresult.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {midresult.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kind366 == "自用小客車")
                            {
                                this.lblAns.Text +=
                                  "使用期間：" + formidyearst.ToString($"{i} /MM /dd") + "～" + formidyeared.ToString($"{i} / MM / dd")
                                  + Environment.NewLine
                                  + "使用天數：" + midlmDays.ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {midtaxans.ToString()}*{midlmDays.ToString()}/{midlmDays.ToString()} = {midresult.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {midresult.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kind366 == "營業用小客車")
                            {
                                this.lblAns.Text +=
                                "使用期間：" + formidyearst.ToString($"{i} /MM /dd") + "～" + formidyeared.ToString($"{i} / MM / dd")
                                + Environment.NewLine
                                + "使用天數：" + midlmDays.ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem as string
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                + Environment.NewLine
                                + $"計算公式： {midtaxans.ToString()}*{midlmDays.ToString()}/{midlmDays.ToString()} = {midresult.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {midresult.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                            }

                            sum += midresult;
                            

                        }
                    }

                    #endregion


                    #region 最後一年

                    bool isLeapYearlast = DateTime.IsLeapYear(startDate.Year);
                    int lmDayslast;
                    if (isLeapYearlast == true)
                    {
                        lmDayslast = 366;
                    }
                    else
                    {
                        lmDayslast = 365;
                    }

                    //計算天數
                    int endy = endDate.Year;             
                    DateTime edday01 = new DateTime(endy, 01, 01);  //設定最後一年第一天                   
                    TimeSpan mienddays = endDate - edday01;   //計算從結束時間當年01/01離結束時間有幾天

                    double dayslast = mienddays.TotalDays + 1;//計算最後一年總天數


                    decimal taxanslast = (decimal)this.TaxCalculatie();
                    decimal resultlast = taxanslast * Convert.ToInt32(dayslast) / Convert.ToInt32(lmDayslast);




                    //計算結果
                    var kinded = this.cbokind.SelectedItem.ToString();

                    if (kinded == "機車")
                    {
                        this.lblAns.Text += "使用期間：" + this.dTP2.Value.ToString("yyyy /01 /01") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                + Environment.NewLine
                                + "使用天數：" + dayslast.ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem.ToString()
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCmoto.SelectedItem.ToString()
                                + Environment.NewLine
                                + $"計算公式： {taxanslast.ToString()}*{dayslast.ToString()}/{lmDayslast.ToString()} = {resultlast.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {resultlast.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kinded == "貨車")
                    {
                        this.lblAns.Text += "使用期間：" + this.dTP2.Value.ToString("yyyy /01 /01") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                + Environment.NewLine
                                + "使用天數：" + dayslast.ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem.ToString()
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCt.SelectedItem.ToString()
                                + Environment.NewLine
                                + $"計算公式： {taxanslast.ToString()}*{dayslast.ToString()}/{lmDayslast.ToString()} = {resultlast.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {resultlast.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kinded == "大客車")
                    {
                        this.lblAns.Text += "使用期間：" + this.dTP2.Value.ToString("yyyy /01 /01") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                + Environment.NewLine
                                + "使用天數：" + dayslast.ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem.ToString()
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCC.SelectedItem.ToString()
                                + Environment.NewLine
                                + $"計算公式： {taxanslast.ToString()}*{dayslast.ToString()}/{lmDayslast.ToString()} = {resultlast.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {resultlast.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kinded == "自用小客車")
                    {
                        this.lblAns.Text += "使用期間：" + this.dTP2.Value.ToString("yyyy /01 /01") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                               + Environment.NewLine
                               + "使用天數：" + dayslast.ToString() + "天"
                               + Environment.NewLine
                               + "用途：" + this.cbokind.SelectedItem.ToString()
                               + Environment.NewLine
                               + "汽缸CC數：" + this.cboCCcar.SelectedItem.ToString()
                               + Environment.NewLine
                               + $"計算公式： {taxanslast.ToString()}*{dayslast.ToString()}/{lmDayslast.ToString()} = {resultlast.ToString("#,0")} 元"
                               + Environment.NewLine
                               + $"應繳稅額： {resultlast.ToString("#,0")}元"
                               + Environment.NewLine + Environment.NewLine;
                    }

                    else if (kinded == "營業用小客車")
                    {
                        this.lblAns.Text += "使用期間：" + this.dTP2.Value.ToString("yyyy /01 /01") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                + Environment.NewLine
                                + "使用天數：" + dayslast.ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem.ToString()
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCcarpub.SelectedItem.ToString()
                                + Environment.NewLine
                                + $"計算公式： {taxanslast.ToString()}*{dayslast.ToString()}/{lmDayslast.ToString()} = {resultlast.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {resultlast.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                    }

                    

                    #endregion


                    decimal taxfor = TaxCalculatie();
                    int fordays = Convert.ToInt32(endDate.Year) - Convert.ToInt32(startDate.Year) - 1; //for迴圈中的年度(頭尾-1)*tax
                    decimal forp = fordays * taxfor;
                    decimal st = result1st + forp + resultlast;



                    this.lblAns.Text += 
                        $"應繳總稅額：{st.ToString("#,0")} 元";
                }


                //若天數小於366天
                else if (days366 < 366) 
                {
                            //開啟關閉一些可見設定
                            this.panelAns.AutoScroll = true;
                            this.lblarK.Visible = false;
                            this.lblarCC.Visible = false;
                            this.lblAns.ForeColor = Color.Black;
                            //閏月
                            bool isLeapYear = DateTime.IsLeapYear(startDate.Year);
                            int lmDays;
                            if (isLeapYear == true)
                            {
                                lmDays = 366;
                            }
                            else
                            {
                                lmDays = 365;
                            }

                            //this.lblAns.Text += items + Environment.NewLine;

                            //計算天數
                            TimeSpan yeardays = dendDate - startDate;
                            TimeSpan mistatdays = dendDate - startDate; //計算開始時間離當年的12/31有幾天
                            TimeSpan mienddays = dendDate - startDate;  //計算從結束時間當年01/01離結束時間有幾天


                            double days2 = yeardays.TotalDays;
                            decimal taxans = (decimal)this.TaxCalculatie();
                            decimal result = taxans * Convert.ToInt32(days2) / Convert.ToInt32(lmDays);
                            decimal resultmi = taxans * Convert.ToInt32(lmDays) / Convert.ToInt32(lmDays);

                            //結果運算
                            string kinddo = this.cbokind.SelectedItem.ToString();

                            if (kinddo == "機車")
                            {
                                this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                  + Environment.NewLine
                                  + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {result.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kinddo == "貨車")
                            {
                                this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                  + Environment.NewLine
                                  + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                                  + Environment.NewLine
                                  + "用途：" + this.cbokind.SelectedItem as string
                                  + Environment.NewLine
                                  + "汽缸CC數：" + this.cboCCt.SelectedItem as string
                                  + Environment.NewLine
                                  + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                                  + Environment.NewLine
                                  + $"應繳稅額： {result.ToString("#,0")}元"
                                  + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kinddo == "大客車")
                            {
                               this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                 + Environment.NewLine
                                 + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                                 + Environment.NewLine
                                 + "用途：" + this.cbokind.SelectedItem as string
                                 + Environment.NewLine
                                 + "汽缸CC數：" + this.cboCCC.SelectedItem as string
                                 + Environment.NewLine
                                 + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                                 + Environment.NewLine
                                 + $"應繳稅額： {result.ToString("#,0")}元"
                                 + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kinddo == "自用小客車")
                            {
                                this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                               + Environment.NewLine
                               + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                               + Environment.NewLine
                               + "用途：" + this.cbokind.SelectedItem as string
                               + Environment.NewLine
                               + "汽缸CC數：" + this.cboCCcar.SelectedItem as string
                               + Environment.NewLine
                               + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                               + Environment.NewLine
                               + $"應繳稅額： {result.ToString("#,0")}元"
                               + Environment.NewLine + Environment.NewLine;
                            }

                            else if (kinddo == "營業用小客車")
                            {
                                this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                                + Environment.NewLine
                                + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                                + Environment.NewLine
                                + "用途：" + this.cbokind.SelectedItem as string
                                + Environment.NewLine
                                + "汽缸CC數：" + this.cboCCcarpub.SelectedItem as string
                                + Environment.NewLine
                                + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                                + Environment.NewLine
                                + $"應繳稅額： {result.ToString("#,0")}元"
                                + Environment.NewLine + Environment.NewLine;
                            }


                    
                }

                else if (days366 == 366) //當天數等於366且當年為閏年
                {
                    
                            //開啟關閉一些可見設定
                            this.panelAns.AutoScroll = true;
                            this.lblarK.Visible = false;
                            this.lblarCC.Visible = false;
                            this.lblAns.ForeColor = Color.Black;
                            //閏月
                            bool isLeapYear = DateTime.IsLeapYear(startDate.Year);
                            int lmDays;
                            if (isLeapYear == true)
                            {
                                lmDays = 366;
                            }
                            else
                            {
                                lmDays = 365;
                            }


                            if (lmDays == 366)
                            {
                                //計算天數
                                TimeSpan yeardays = dendDate - startDate;
                                TimeSpan mistatdays = dendDate - startDate; //計算開始時間離當年的12/31有幾天
                                TimeSpan mienddays = dendDate - startDate;  //計算從結束時間當年01/01離結束時間有幾天


                                double days2 = yeardays.TotalDays;
                                decimal taxans = (decimal)this.TaxCalculatie();
                                decimal result = taxans * Convert.ToInt32(days2) / Convert.ToInt32(lmDays);
                                decimal resultmi = taxans * Convert.ToInt32(lmDays) / Convert.ToInt32(lmDays);

                        //結果運算
                        string kinddo = this.cbokind.SelectedItem.ToString();

                        if (kinddo == "機車")
                        {
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                              + Environment.NewLine
                              + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                              + Environment.NewLine
                              + "用途：" + this.cbokind.SelectedItem as string
                              + Environment.NewLine
                              + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                              + Environment.NewLine
                              + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                              + Environment.NewLine
                              + $"應繳稅額： {result.ToString("#,0")}元"
                              + Environment.NewLine + Environment.NewLine;
                        }

                        else if (kinddo == "貨車")
                        {
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                              + Environment.NewLine
                              + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                              + Environment.NewLine
                              + "用途：" + this.cbokind.SelectedItem as string
                              + Environment.NewLine
                              + "汽缸CC數：" + this.cboCCt.SelectedItem as string
                              + Environment.NewLine
                              + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                              + Environment.NewLine
                              + $"應繳稅額： {result.ToString("#,0")}元"
                              + Environment.NewLine + Environment.NewLine;
                        }

                        else if (kinddo == "大客車")
                        {
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                              + Environment.NewLine
                              + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                              + Environment.NewLine
                              + "用途：" + this.cbokind.SelectedItem as string
                              + Environment.NewLine
                              + "汽缸CC數：" + this.cboCCC.SelectedItem as string
                              + Environment.NewLine
                              + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                              + Environment.NewLine
                              + $"應繳稅額： {result.ToString("#,0")}元"
                              + Environment.NewLine + Environment.NewLine;
                        }

                        else if (kinddo == "自用小客車")
                        {
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                           + Environment.NewLine
                           + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                           + Environment.NewLine
                           + "用途：" + this.cbokind.SelectedItem as string
                           + Environment.NewLine
                           + "汽缸CC數：" + this.cboCCcar.SelectedItem as string
                           + Environment.NewLine
                           + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                           + Environment.NewLine
                           + $"應繳稅額： {result.ToString("#,0")}元"
                           + Environment.NewLine + Environment.NewLine;
                        }

                        else if (kinddo == "營業用小客車")
                        {
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                            + Environment.NewLine
                            + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                            + Environment.NewLine
                            + "用途：" + this.cbokind.SelectedItem as string
                            + Environment.NewLine
                            + "汽缸CC數：" + this.cboCCcarpub.SelectedItem as string
                            + Environment.NewLine
                            + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                            + Environment.NewLine
                            + $"應繳稅額： {result.ToString("#,0")}元"
                            + Environment.NewLine + Environment.NewLine;
                        }
                    }


                }

                else
                {
                    for (var ic1 = startDate.Year; ic1 <= endDate.Year; ic1++)
                    {
                        int[] ic = { ic1 };
                        foreach (var items in ic)
                        {
                            //開啟關閉一些可見設定
                            this.panelAns.AutoScroll = true;
                            this.lblarK.Visible = false;
                            this.lblarCC.Visible = false;
                            this.lblAns.ForeColor = Color.Black;
                            //閏月
                            bool isLeapYear = DateTime.IsLeapYear(ic1);
                            int lmDays;
                            if (isLeapYear == true)
                            {
                                lmDays = 366;
                            }
                            else
                            {
                                lmDays = 365;
                            }

                            //this.lblAns.Text += items + Environment.NewLine;

                            //計算天數
                            TimeSpan yeardays = dendDate - startDate;

                            double days2 = yeardays.TotalDays;
                            decimal taxans = (decimal)this.TaxCalculatie();
                            decimal result = taxans * Convert.ToInt32(days2) / Convert.ToInt32(lmDays);
                            decimal resultmi = taxans * Convert.ToInt32(lmDays) / Convert.ToInt32(lmDays);

                            //結果運算
                            this.lblAns.Text += "使用期間：" + this.dTP1.Value.ToString("yyyy /MM /dd") + "～" + this.dTP2.Value.ToString("yyyy /MM /dd")
                        + Environment.NewLine
                        + "使用天數：" + Convert.ToInt32(days2).ToString() + "天"
                        + Environment.NewLine
                        + "用途：" + this.cbokind.SelectedItem as string
                        + Environment.NewLine
                        + "汽缸CC數：" + this.cboCCmoto.SelectedItem as string
                        + Environment.NewLine
                        + $"計算公式： {taxans.ToString()}*{days2.ToString()}/{lmDays.ToString()} = {result.ToString("#,0")} 元"
                        + Environment.NewLine
                        + $"應繳稅額： {result.ToString("#,0")}元"
                        + Environment.NewLine + Environment.NewLine;
                        }
                    }

                }
            }

            else if (startDate > endDate) //前面日期較大
            {
                this.rdoM.Checked = false;
                this.lblarT.ForeColor = Color.Red;
                this.lblarT.Text = "起始時間須早於截止時間";
                this.lblAns.ForeColor = Color.Red;
                this.lblAns.Text = "錯誤發生" + Environment.NewLine + "請確認資料是否輸入正確";
            }

        }
        #endregion



        #region 車種memo
        /// <summary>
        /// 依照車種變更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarKind(string[] a)
        {
            

            //int[] armoto = new int[] { 0, 800, 1620, 2160, 4320, 7120, 11230 };
            //int[] artruck = new int[] { 900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };
            //int[] arcoach = new int[] { 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };
            //int[] arprvcar = new int[] { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };
            //int[] arpubcar = new int[] { 900, 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };

            #region memo
            //機車
            //150以下／12HP以下 (12.2PS以下)...0
            //151～250／12.1-20HP(12.3-20.3PS)...800
            //251～500／20.1HP以上(20.4PS以上)...1620
            //501～600...2160
            //601～1200...4320
            //1201～1800...7120
            //1801或以上...11230


            //貨車
            //500以下...900
            //501～600...1080
            //601～1200...1800
            //1201～1800...2700
            //1801～2400...3600
            //2401～3000／138HP以下(140.1PS以下)...4500
            //3001～3600...5400
            //3601～4200／138.1-200HP(140.2-203.0PS)...6300
            //4201～4800...7200
            //4801～5400／200.1-247HP(203.1-250.7PS)...8100
            //5401～6000...9000
            //6001～6600／247.1-286HP(250.8-290.3PS)...9900
            //6601～7200...10800
            //7201～7800／286.1-336HP(290.4-341.0PS)...11700
            //7801～8400...12600
            //8401～9000／336.1-361HP(341.1-366.4PS)13500
            //9001～9600...14400
            //9601～10200／361.1HP以上(366.5PS以上)...15300
            //10201以上...16200


            //大客車
            //600以下...1080
            //601～1200...1800
            //1201～1800...2700
            //1801～2400...3600
            //2401～3000／138HP以下(140.1PS以下)...4500
            //3001～3600...5400
            //3601～4200／138.1-200HP(140.2-203.0PS)...6300
            //4201～4800...7200
            //4801～5400／200.1-247HP(203.1-250.7PS)...8100
            //5401～6000...9000
            //6001～6600／247.1-286HP(250.8-290.3PS)...9900
            //6601～7200...10800
            //7201～7800／286.1-336HP(290.4-341.0PS)...11700
            //7801～8400...12600
            //8401～9000／336.1-361HP(341.1-366.4PS)13500
            //9001～9600...14400
            //9601～10200／361.1HP以上(366.5PS以上)...15300
            //10201以上...16200


            //自用小客車
            //500以下／38HP以下(38.6PS以下)...1620
            //501～600／38.1-56HP(38.7-56.8PS)...2160
            //601～1200／56.1-83HP(56.9-84.2PS)...4320
            //1201～1800／83.1-182HP(84.3-184.7PS)...7120
            //1801～2400／182.1-262HP(184.8-265.9PS)...11230
            //2401～3000／262.1-322HP(266-326.8PS)...15210
            //3001～4200／322.1-414HP(326.9-420.2PS)...28220
            //4201～5400／414.1~469HP(420.3-476.0PS)...46170
            //5401～6600／469.1-509HP(476.1-516.6PS)...69690
            //6601～7800／509.1HP以上(516.7PS以上)...117000
            //7801以上...151200


            //營業用小客車
            //500以下／38HP以下(38.6PS以下)...900
            //501～600／38.1-56HP(38.7-56.8PS)...1260
            //601～1200／56.1-83HP(56.9-84.2PS)...2160
            //1201～1800／83.1-182HP(84.3-184.7PS)...3060
            //1801～2400／182.1-262HP(184.8-265.9PS)...6480
            //2401～3000／262.1-322HP(266-326.8PS)...9900
            //3001～4200／322.1-414HP(326.9-420.2PS)...16380
            //4201～5400／414.1~469HP(420.3-476.0PS)...24300
            //5401～6600／469.1-509HP(476.1-516.6PS)...33660
            //6601～7800／509.1HP以上(516.7PS以上)...44460
            //7801以上...56700
            #endregion

        }
        #endregion


        #region Tax
        /// <summary>
        /// 依照下拉選單選擇汽缸對應的算式，不合理時會回傳錯誤訊息
        /// </summary>
        /// <returns></returns>
        private decimal TaxCalculatie()
        {
            var kindtax = this.cbokind.SelectedItem;

            switch (kindtax)
            {
                case "機車":
                    var inmoto = this.cboCCmoto.SelectedIndex;
                    int[] arraymoto = { 0, 800, 1620, 2160, 4320, 7120, 11230 };

                    switch (inmoto)
                    {
                        case 0:
                            return arraymoto[0];
                        case 1:
                            return arraymoto[1];
                        case 2:
                            return arraymoto[2];
                        case 3:
                            return arraymoto[3];
                        case 4:
                            return arraymoto[4];
                        case 5:
                            return arraymoto[5];
                        case 6:
                            return arraymoto[6];
                        default:
                            return 0;

                    }
                case "貨車":

                    var intruck = this.cboCCt.SelectedIndex;
                    int[] arraytruck = { 900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };

                    switch (intruck)
                    {
                        case 0:
                            return arraytruck[0];
                        case 1:
                            return arraytruck[1];
                        case 2:
                            return arraytruck[2];
                        case 3:
                            return arraytruck[3];
                        case 4:
                            return arraytruck[4];
                        case 5:
                            return arraytruck[5];
                        case 6:
                            return arraytruck[6];
                        case 7:
                            return arraytruck[7];
                        case 8:
                            return arraytruck[8];
                        case 9:
                            return arraytruck[9];
                        case 10:
                            return arraytruck[10];
                        case 11:
                            return arraytruck[11];
                        case 12:
                            return arraytruck[12];
                        case 13:
                            return arraytruck[13];
                        case 14:
                            return arraytruck[14];
                        case 15:
                            return arraytruck[15];
                        case 16:
                            return arraytruck[16];
                        case 17:
                            return arraytruck[17];
                        case 18:
                            return arraytruck[18];
                        default:
                            return 0;
                    }


                case "大客車":
                    var incoach = this.cboCCC.SelectedIndex;
                    int[] arraycoach = { 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };

                    switch (incoach)
                    {
                        case 0:
                            return arraycoach[0];
                        case 1:
                            return arraycoach[1];
                        case 2:
                            return arraycoach[2];
                        case 3:
                            return arraycoach[3];
                        case 4:
                            return arraycoach[4];
                        case 5:
                            return arraycoach[5];
                        case 6:
                            return arraycoach[6];
                        case 7:
                            return arraycoach[7];
                        case 8:
                            return arraycoach[8];
                        case 9:
                            return arraycoach[9];
                        case 10:
                            return arraycoach[10];
                        case 11:
                            return arraycoach[11];
                        case 12:
                            return arraycoach[12];
                        case 13:
                            return arraycoach[13];
                        case 14:
                            return arraycoach[14];
                        case 15:
                            return arraycoach[15];
                        case 16:
                            return arraycoach[16];
                        case 17:
                            return arraycoach[17];
                        default:
                            return 0;
                    }

                case "自用小客車":
                    var inprvcar = this.cboCCcar.SelectedIndex;
                    int[] arrrayprvcar = { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };

                    switch (inprvcar)
                    {
                        case 0:
                            return arrrayprvcar[0];
                        case 1:
                            return arrrayprvcar[1];
                        case 2:
                            return arrrayprvcar[2];
                        case 3:
                            return arrrayprvcar[3];
                        case 4:
                            return arrrayprvcar[4];
                        case 5:
                            return arrrayprvcar[5];
                        case 6:
                            return arrrayprvcar[6];
                        case 7:
                            return arrrayprvcar[7];
                        case 8:
                            return arrrayprvcar[8];
                        case 9:
                            return arrrayprvcar[9];
                        case 10:
                            return arrrayprvcar[10];

                        default:
                            return 0;
                    }

                case "營業用小客車":
                    var inpubcar = this.cboCCcarpub.SelectedIndex;
                    int[] arraypubcar = { 900, 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };

                    switch (inpubcar)
                    {
                        case 0:
                            return arraypubcar[0];
                        case 1:
                            return arraypubcar[1];
                        case 2:
                            return arraypubcar[2];
                        case 3:
                            return arraypubcar[3];
                        case 4:
                            return arraypubcar[4];
                        case 5:
                            return arraypubcar[5];
                        case 6:
                            return arraypubcar[6];
                        case 7:
                            return arraypubcar[7];
                        case 8:
                            return arraypubcar[8];
                        case 9:
                            return arraypubcar[9];
                        case 10:
                            return arraypubcar[10];

                        default:
                            return 0;
                    }


                default:
                    return 0;


            }

        }


        #endregion





        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lblAns.Text != "")
            {
                this.lblAns.ForeColor = Color.Red;
            }
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lblAns.Text != "")
            {
                this.lblAns.ForeColor = Color.Blue;
            }
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lblAns.Text != "")
            {
                this.lblAns.ForeColor = Color.Green;
            }
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lblAns.Text != "")
            {
                this.lblAns.ForeColor = Color.Black;
            }
        }


    }
}
