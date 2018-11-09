using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuelette
{
    public partial class F_Calc : Form
    {
        public F_Calc()
        {
            InitializeComponent();
        }

        #region Event_click
        private void bt_One_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "1";
        }

        private void bt_two_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "2";
        }

        private void bt_Three_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "3";
        }

        private void bt_Four_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "4";
        }

        private void bt_Five_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "5";
        }

        private void bt_Six_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "6";
        }

        private void bt_Seven_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "7";
        }

        private void bt_Height_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "8";
        }

        private void bt_Nine_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "9";
        }

        private void bt_Zero_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "0";
        }

        private void bt_Coma_Click(object sender, EventArgs e)
        {
            if (rtb_Result.Text.Length > 0)
            {
                bool isSuccess = double.TryParse(rtb_Result.Text[rtb_Result.Text.Length - 1].ToString(), out double number);
                if (isSuccess)
                {
                    rtb_Result.Text = rtb_Result.Text + ",";
                }
            }
        }

        private void bt_Equal_Click(object sender, EventArgs e)
        {
            Calcul calcul = new Calcul();
            double result = calcul.Calcule(rtb_Result.Text);
            rtb_Result.Text = result.ToString();
        }

        private void bt_Multiplication_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "*";
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "/";
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "+";
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = rtb_Result.Text + "-";
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            rtb_Result.Text = "";
        }

        #endregion


    }
}
