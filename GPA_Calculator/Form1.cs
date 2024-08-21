using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        string subjectNames, results, weights, gpas , subCredits;
        double subCreditTotal;
        double creditTotal;
        string R1, R2, R3, R4, R5, R6, R7;
        double MULCS1, MULCS2, MULCS3, MULCS4, MULCS5, MULCS6, MULCS7;

        private void cbCredit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject3.Visible = true;
            cbResult3.Visible = true;
        }

        private void cbCredit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject4.Visible = true;
            cbResult4.Visible = true;
        }

        private void cbCredit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject5.Visible = true;
            cbResult5.Visible = true;
        }

        private void cbCredit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject6.Visible = true;
            cbResult6.Visible =true;
        }

        private void cbCredit6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject7.Visible = true;
            cbResult7.Visible = true;
        }

        private void cbCredit7_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void cbCredit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubject2.Visible = true;
            cbResult2.Visible = true;
        }

        private void cbResult1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        double gpaTotal1;
        double finalGpa;

        private void cbSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbSubject1.Select();
            btnTotal.Enabled = false;
            btnReset.Enabled = false;
            btnSubmit.Enabled = false;
            cbSubject2.Visible = cbSubject3.Visible = cbSubject4.Visible = cbSubject5.Visible = cbSubject6.Visible = cbSubject7.Visible = false;
            cbResult2.Visible = cbResult3.Visible =cbResult4.Visible = cbResult5.Visible =cbResult6.Visible = cbResult7.Visible = false;
        }

        string SC1,SC2, SC3, SC4, SC5, SC6, SC7;
        string C1,C2,C3,C4,C5,C6,C7;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (C1 + C2+ C3+ C4+ C5+ C6+ C7 != "" )
                {
                    for (int i = 0; i <= dgvTable.Rows.Count - 1; i++)
                    {
                        subCreditTotal = double.Parse(SC1) + double.Parse(SC2) + double.Parse(SC3) + double.Parse(SC4) + double.Parse(SC5) + double.Parse(SC6) + double.Parse(SC7);

                    }

                    for (int i = 0; i <= dgvTable.Rows.Count - 1; i++)
                    {
                        creditTotal = double.Parse(C1) + double.Parse(C2) + double.Parse(C3) + double.Parse(C4) + double.Parse(C5) + double.Parse(C6) + double.Parse(C7);
                    }

                    MULCS1 = double.Parse(C1) * double.Parse(SC1);
                    MULCS2 = double.Parse(C2) * double.Parse(SC2);
                    MULCS3 = double.Parse(C3) * double.Parse(SC3);
                    MULCS4 = double.Parse(C4) * double.Parse(SC4);
                    MULCS5 = double.Parse(C5) * double.Parse(SC5);
                    MULCS6 = double.Parse(C6) * double.Parse(SC6);
                    MULCS7 = double.Parse(C7) * double.Parse(SC7);

                    gpaTotal1 = MULCS1 + MULCS2 +MULCS3 + MULCS4 + MULCS5 + MULCS6 + MULCS7;

                    finalGpa = gpaTotal1 / creditTotal;

                    dgvTable.Rows.Add("Total", null, subCreditTotal, creditTotal, finalGpa);
                }
                else
                {
                    MessageBox.Show("Please Enter Credit");
                    
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            R1 = cbResult1.Text;
            R2 = cbResult2.Text;
            R3 = cbResult3.Text;
            R4 = cbResult4.Text;
            R5 = cbResult5.Text;
            R6 = cbResult6.Text;
            R7 = cbResult7.Text;

            C1 = cbCredit1.Text;
            C2 = cbCredit2.Text;
            C3 = cbCredit3.Text;
            C4 = cbCredit4.Text;
            C5 = cbCredit5.Text;
            C6 = cbCredit6.Text;
            C7 = cbCredit7.Text;
            
            
            try
            {
                //selecting result credit R1
                if (R1 == "A+")
                {
                    SC1 = "4.0";
                }
                else if (R1 == "A")
                {
                    SC1 = "4.0";
                }
                else if (R1 == "A-")
                {
                    SC1 = "3.7";
                }
                else if (R1 == "B+")
                {
                    SC1 = "3.3";
                }
                else if (R1 == "B")
                {
                    SC1 = "3.0";
                }
                else if (R1 == "B-")
                {
                    SC1 = "2.7";
                }else if (R1 == "C+")
                {
                    SC1 = "2.3";
                }else if (R1 == "C")
                {
                    SC1 = "2.0";
                }else if (R1 == "C-")
                {
                    SC1 = "1.7";
                }else if (R1 == "D+")
                {
                    SC1 = "1.3";
                }else if (R1 == "D")
                {
                    SC1 = "1.0";
                
                }else if (R1 == "E")
                {
                    SC1 = "0.0";
                }
                else
                {
                    SC1 = "0.0";
                }
                //selecting result credit R2
                if (R2 == "A+")
                {
                    SC2 = "4.0";
                }
                else if (R2 == "A")
                {
                    SC2 = "4.0";
                }
                else if (R2 == "A-")
                {
                    SC2 = "3.7";
                }
                else if (R2 == "B+")
                {
                    SC2 = "3.3";
                }
                else if (R2 == "B")
                {
                    SC2 = "3.0";
                }
                else if (R2 == "B-")
                {
                    SC2 = "2.7";
                }
                else if (R2 == "C+")
                {
                    SC2 = "2.3";
                }
                else if (R2 == "C")
                {
                    SC2 = "2.0";
                }
                else if (R2 == "C-")
                {
                    SC2 = "1.7";
                }
                else if (R2 == "D+")
                {
                    SC2 = "1.3";
                }
                else if (R2 == "D")
                {
                    SC2 = "1.0";
                }
               
                else if (R2 == "E")
                {
                    SC2 = "0.0";
                }
                else
                {
                    SC2 = "0.0";
                }
                //selecting result R3
                if (R3 == "A+")
                {
                    SC3 = "4.0";
                }
                else if (R3 == "A")
                {
                    SC3 = "4.0";
                }
                else if (R3 == "A-")
                {
                    SC3 = "3.7";
                }
                else if (R3 == "B+")
                {
                    SC3 = "3.3";
                }
                else if (R3 == "B")
                {
                    SC3 = "3.0";
                }
                else if (R3 == "B-")
                {
                    SC3 = "2.7";
                }
                else if (R3 == "C+")
                {
                    SC3 = "2.3";
                }
                else if (R3 == "C")
                {
                    SC3 = "2.0";
                }
                else if (R3 == "C-")
                {
                    SC3 = "1.7";
                }
                else if (R3 == "D+")
                {
                    SC3 = "1.3";
                }
                else if (R3 == "D")
                {
                    SC3 = "1.0";
                }
                
                else if (R3 == "E")
                {
                    SC3 = "0.0";
                }
                else
                {
                    SC3 = "0.0";
                }
                //selecting result R4
                if (R4 == "A+")
                {
                    SC4 = "4.0";
                }
                else if (R4 == "A")
                {
                    SC4 = "4.0";
                }
                else if (R4 == "A-")
                {
                    SC4 = "3.7";
                }
                else if (R4 == "B+")
                {
                    SC4 = "3.3";
                }
                else if (R4 == "B")
                {
                    SC4 = "3.0";
                }
                else if (R4 == "B-")
                {
                    SC4 = "2.7";
                }
                else if (R4 == "C+")
                {
                    SC4 = "2.3";
                }
                else if (R4 == "C")
                {
                    SC4 = "2.0";
                }
                else if (R4 == "C-")
                {
                    SC4 = "1.7";
                }
                else if (R4 == "D+")
                {
                    SC4 = "1.3";
                }
                else if (R4 == "D")
                {
                    SC4 = "1.0";
                }
               
                else if (R4 == "E")
                {
                    SC4 = "0.0";
                }
                else
                {
                    SC4 = "0.0";
                }
                //selecting result R5
                if (R5 == "A+")
                {
                    SC5 = "4.0";
                }
                else if (R5 == "A")
                {
                    SC5 = "4.0";
                }
                else if (R5 == "A-")
                {
                    SC5 = "3.7";
                }
                else if (R5 == "B+")
                {
                    SC5 = "3.3";
                }
                else if (R5 == "B")
                {
                    SC5 = "3.0";
                }
                else if (R5 == "B-")
                {
                    SC5 = "2.7";
                }
                else if (R5 == "C+")
                {
                    SC5 = "2.3";
                }
                else if (R5 == "C")
                {
                    SC5 = "2.0";
                }
                else if (R5 == "C-")
                {
                    SC5 = "1.7";
                }
                else if (R5 == "D+")
                {
                    SC5 = "1.3";
                }
                else if (R5 == "D")
                {
                    SC5 = "1.0";
                }
               
                else if (R5 == "E")
                {
                    SC5 = "0.0";
                }
                else
                {
                    SC5 = "0.0";
                }
                //selecting result R6
                if (R6 == "A+")
                {
                    SC6 = "4.0";
                }
                else if (R6 == "A")
                {
                    SC6 = "4.0";
                }
                else if (R6 == "A-")
                {
                    SC6 = "3.7";
                }
                else if (R6 == "B+")
                {
                    SC6 = "3.3";
                }
                else if (R6 == "B")
                {
                    SC6 = "3.0";
                }
                else if (R6 == "B-")
                {
                    SC6 = "2.7";
                }
                else if (R6 == "C+")
                {
                    SC6 = "2.3";
                }
                else if (R6 == "C")
                {
                    SC6 = "2.0";
                }
                else if (R6 == "C-")
                {
                    SC6 = "1.7";
                }
                else if (R6 == "D+")
                {
                    SC6 = "1.3";
                }
                else if (R6 == "D")
                {
                    SC6 = "1.0";
                }
                
                else if (R6 == "E")
                {
                    SC6 = "0.0";
                }
                else
                {
                    SC6 = "0.0";
                }
                //select result R7
                if (R7 == "A+")
                {
                    SC7 = "4.0";
                }
                else if (R7 == "A")
                {
                    SC7 = "4.0";
                }
                else if (R7 == "A-")
                {
                    SC7 = "3.7";
                }
                else if (R7 == "B+")
                {
                    SC7 = "3.3";
                }
                else if (R7 == "B")
                {
                    SC7 = "3.0";
                }
                else if (R7 == "B-")
                {
                    SC7 = "2.7";
                }
                else if (R7 == "C+")
                {
                    SC7 = "2.3";
                }
                else if (R7 == "C")
                {
                    SC7 = "2.0";
                }
                else if (R7 == "C-")
                {
                    SC7 = "1.7";
                }
                else if (R7 == "D+")
                {
                    SC7 = "1.3";
                }
                else if (R7 == "D")
                {
                    SC7 = "1.0";
                }
                
                else if (R7 == "E")
                {
                    SC7 = "0.0";
                }
                else
                {
                    SC7 = "0.0";
                }

                //dgvTable.Rows.Add(subjectNames, results,credits,gpas, weights);
                addRows(cbSubject1.Text, R1, SC1, cbCredit1.Text, gpas, cbWeight.Text);
                addRows(cbSubject2.Text, R2, SC2, cbCredit2.Text, gpas, cbWeight.Text);
                addRows(cbSubject3.Text, R3, SC3, cbCredit3.Text, gpas, cbWeight.Text);
                addRows(cbSubject4.Text, R4, SC4, cbCredit4.Text, gpas, cbWeight.Text);
                addRows(cbSubject5.Text, R5, SC5, cbCredit5.Text, gpas, cbWeight.Text);
                addRows(cbSubject6.Text, R6, SC6, cbCredit6.Text, gpas, cbWeight.Text);
                addRows(cbSubject7.Text, R7, SC7, cbCredit6.Text, gpas, cbWeight.Text);
                //addRows(cbSubject8.Text, R8, SC8, txtCredit8.Text, gpas, cbWeight.Text);
                
                btnTotal.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ("Erro"));
            }
        }

        private void addRows(string Sname, string results ,string subCredits, string credit,  string gpa, string weight)
        {
            string[] row = { Sname, results, subCredits, credit,  gpa, weight };
            dgvTable.Rows.Add(row);
            dgvTable.AllowUserToAddRows = false;

            
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            
            cbSubject1.Text = cbSubject2.Text = cbSubject3.Text = cbSubject4.Text = cbSubject5.Text = cbSubject6.Text = cbSubject7.Text = cbResult1.Text = cbResult2.Text = cbResult3.Text = cbResult4.Text = cbResult5.Text = cbResult6.Text = cbResult7.Text= cbWeight.Text = cbCredit1.Text = cbCredit2.Text= cbCredit3.Text= cbCredit4.Text= cbCredit5.Text= cbCredit6.Text= cbCredit7.Text = "";
            
            dgvTable.Rows.Clear();
            cbSubject1.Select();
            btnSubmit.Enabled = false;
            btnTotal.Enabled = false;
            MessageBox.Show("Clear Succussfully");
        }
    }
}
