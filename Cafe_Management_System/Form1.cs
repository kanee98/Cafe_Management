/**  
* Created by KanishkaUdapitiya on 10/22/2016.  
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "1.75";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "1.75";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void latte_CheckedChanged(object sender, EventArgs e)
        {
            if (latte.Checked == true)
            {
                textBox1.Enabled = true;
            }
            if (latte.Checked == false)
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void espresso_CheckedChanged(object sender, EventArgs e)
        {
            if (espresso.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (espresso.Checked == false)
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void icedlatte_CheckedChanged(object sender, EventArgs e)
        {
            if (icedlatte.Checked == true)
            {
                textBox3.Enabled = true;
            }
            if (icedlatte.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void valecoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (valecoffe.Checked == true)
            {
                textBox4.Enabled = true;
            }
            if (valecoffe.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void cappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cappuccino.Checked == true)
            {
                textBox5.Enabled = true;
            }
            if (cappuccino.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void africancoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (africancoffee.Checked == true)
            {
                textBox6.Enabled = true;
            }
            if (africancoffee.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Focus();
        }

        private void americancoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (americancoffe.Checked == true)
            {
                textBox7.Enabled = true;
            }
            if (americancoffe.Checked == false)
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.Focus();
        }

        private void icedcappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (icedcappuccino.Checked == true)
            {
                textBox8.Enabled = true;
            }
            if (icedcappuccino.Checked == false)
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.Focus();
        }

        private void coffeecake_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeecake.Checked == true)
            {
                textBox16.Enabled = true;
            }
            if (coffeecake.Checked == false)
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }
        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            textBox16.Focus();
        }

        private void rvcake_CheckedChanged(object sender, EventArgs e)
        {
            if (rvcake.Checked == true)
            {
                textBox15.Enabled = true;
            }
            if (rvcake.Checked == false)
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }
        private void textBox15_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox15.Focus();
        }

        private void bfcake_CheckedChanged(object sender, EventArgs e)
        {
            if (bfcake.Checked == true)
            {
                textBox14.Enabled = true;
            }
            if (bfcake.Checked == false)
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }
        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox14.Focus();
        }

        private void bccake_CheckedChanged(object sender, EventArgs e)
        {
            if (bccake.Checked == true)
            {
                textBox13.Enabled = true;
            }
            if (bccake.Checked == false)
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }
        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox13.Focus();
        }

        private void lccake_CheckedChanged(object sender, EventArgs e)
        {
            if (lccake.Checked == true)
            {
                textBox12.Enabled = true;
            }
            if (lccake.Checked == false)
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }
        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox12.Focus();
        }

        private void kcchocolatecake_CheckedChanged(object sender, EventArgs e)
        {
            if (kcchocolatecake.Checked == true)
            {
                textBox11.Enabled = true;
            }
            if (kcchocolatecake.Checked == false)
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }
        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox11.Focus();
        }

        private void rancake_CheckedChanged(object sender, EventArgs e)
        {
            if (rancake.Checked == true)
            {
                textBox10.Enabled = true;
            }
            if (rancake.Checked == false)
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }
        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox10.Focus();
        }

        private void kanecake_CheckedChanged(object sender, EventArgs e)
        {
            if (kanecake.Checked == true)
            {
                textBox9.Enabled = true;
            }
            if (kanecake.Checked == false)
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }
        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // This Code Will Open Text Files
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                receipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // This Code Will Save Text Files
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(receipt.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receipt.Clear();

            receipt.AppendText(Environment.NewLine);
            receipt.AppendText("\t\t\t" + " Kanee's Cafe " + Environment.NewLine);
            receipt.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            receipt.AppendText("Latte \t\t\t\t\t\t" + textBox1.Text + Environment.NewLine);
            receipt.AppendText("Espresso \t\t\t\t\t" + textBox2.Text + Environment.NewLine);
            receipt.AppendText("Iced Latte \t\t\t\t\t" + textBox3.Text + Environment.NewLine);
            receipt.AppendText("Vale Coffee \t\t\t\t\t" + textBox4.Text + Environment.NewLine);
            receipt.AppendText("Cappuccino \t\t\t\t\t" + textBox5.Text + Environment.NewLine);
            receipt.AppendText("African Coffee \t\t\t\t\t" + textBox6.Text + Environment.NewLine);
            receipt.AppendText("American Coffee \t\t\t\t" + textBox7.Text + Environment.NewLine);
            receipt.AppendText("Iced Cappuccino \t\t\t\t" + textBox8.Text + Environment.NewLine);

            receipt.AppendText("Coffee Cake \t\t\t\t\t" + textBox16.Text + Environment.NewLine);
            receipt.AppendText("Red Velvet Cale \t\t\t\t" + textBox15.Text + Environment.NewLine);
            receipt.AppendText("Black Forest Cake \t\t\t\t" + textBox14.Text + Environment.NewLine);
            receipt.AppendText("Boston Cream Cake \t\t\t\t" + textBox13.Text + Environment.NewLine);
            receipt.AppendText("Lagos Chocolate Cake \t\t\t\t" + textBox12.Text + Environment.NewLine);
            receipt.AppendText("Kilbern Chocolate Cake \t\t\t\t" + textBox11.Text + Environment.NewLine);
            receipt.AppendText("Rice Cake \t\t\t\t\t" + textBox10.Text + Environment.NewLine);
            receipt.AppendText("Kanee's Special Cake \t\t\t\t" + textBox9.Text + Environment.NewLine);
            receipt.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);

            receipt.AppendText("Service Charge \t\t\t\t" + label8.Text + Environment.NewLine);
            receipt.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            
            receipt.AppendText("Tax \t\t\t\t\t\t" + label12.Text + Environment.NewLine);
            receipt.AppendText("Sub Total \t\t\t\t\t" + label13.Text + Environment.NewLine);
            receipt.AppendText("Total \t\t\t\t\t\t" + label14.Text + Environment.NewLine);

            receipt.AppendText("------------------------------------------------------------------------------------------------" + Environment.NewLine);
            receipt.AppendText(label15.Text + "\t\t\t\t" + label16.Text);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;
            double latte, espres, ilatte, vale, aCoff, amCoff, capp, iCapp;
            double cCake, rVel, bFor, cBos, cLag, cKilb, rCake, kCake;
            // Coffee
            latte = 100; espres = 100; ilatte = 120; vale = 150; aCoff = 180; amCoff = 200; capp = 150; iCapp = 180;
            double latte_Coff = Convert.ToDouble(textBox1.Text);
            double espresson = Convert.ToDouble(textBox2.Text);
            double iced_Latte = Convert.ToDouble(textBox3.Text);
            double vale_Coff = Convert.ToDouble(textBox4.Text);
            double afri_Coff = Convert.ToDouble(textBox5.Text);
            double ameri_Coff = Convert.ToDouble(textBox6.Text);
            double capp_Coff = Convert.ToDouble(textBox7.Text);
            double iCapp_Coff = Convert.ToDouble(textBox8.Text);
            // Cake
            cCake = 85; rVel = 90; bFor = 100; cBos = 100; cLag = 120; cKilb = 135; rCake = 150; kCake = 150;
            double c_Cakes = Convert.ToDouble(textBox16.Text);
            double vl_Cakes = Convert.ToDouble(textBox15.Text);
            double bf_Cakes = Convert.ToDouble(textBox14.Text);
            double cb_Cakes = Convert.ToDouble(textBox13.Text);
            double cl_Cakes = Convert.ToDouble(textBox12.Text);
            double ck_Cakes = Convert.ToDouble(textBox11.Text);
            double r_Cakes = Convert.ToDouble(textBox10.Text);
            double k_Cakes = Convert.ToDouble(textBox9.Text);

            Cafe kanee_Cafe = new Cafe(latte_Coff, espresson, iced_Latte, vale_Coff, afri_Coff, ameri_Coff, capp_Coff, iCapp_Coff, c_Cakes, vl_Cakes, bf_Cakes, cb_Cakes, cl_Cakes, ck_Cakes, r_Cakes, k_Cakes);

            double cost_of_drinks = (latte_Coff * latte) + (espresson * espres) + (iced_Latte * ilatte) + (vale_Coff * vale) + (afri_Coff * aCoff) + (ameri_Coff * amCoff) + (capp_Coff * capp) + (iCapp_Coff * iCapp);
            label6.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cake = (c_Cakes * cCake) + (vl_Cakes * rVel) + (bf_Cakes * bFor) + (cb_Cakes * cBos) + (cl_Cakes *cLag) + (ck_Cakes * cKilb) + (r_Cakes * rCake) + (k_Cakes * kCake);
            label7.Text = Convert.ToString(cost_of_cake);

            double service_charge = Convert.ToDouble(label8.Text);

            label13.Text = Convert.ToString(cost_of_cake + cost_of_drinks + service_charge);
            label12.Text = Convert.ToString(((cost_of_cake + cost_of_drinks + service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(label12.Text);
            label14.Text = Convert.ToString(cost_of_cake + cost_of_drinks + iTax + service_charge);

            label7.Text = String.Format("{0:C}", cost_of_cake);
            label6.Text = String.Format("{0:C}", cost_of_drinks);
            label8.Text = String.Format("{0:C}", service_charge);
            label13.Text = String.Format("{0:C}", (cost_of_cake + cost_of_drinks + service_charge));
            label12.Text = String.Format("{0:C}", iTax);
            label14.Text = String.Format("{0:C}", (cost_of_cake + cost_of_drinks + iTax + service_charge));
            
        }
    }
}
