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
        string total1;
        string R1, R2, R3, R4, R5, R6, R7, R8;
        string SC1,SC2, SC3, SC4, SC5, SC6, SC7,SC8;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvTable.Rows.Count -1; i++)
            {
                total1 += double.Parse(dgvTable.Rows[i].Cells[3].Value.ToString());
            }
            dgvTable.Rows.Add(null, "Total", total1, null, null, null);
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
            R8 = cbResult8.Text;
            try
            {
                //selecting result credit R1
                if (R1 == "A+")
                {
                    SC1 = "4";
                }
                else if (R1 == "A")
                {
                    SC1 = "4";
                }
                else if (R1 == "A-")
                {
                    SC1 = "3.7";
                }
                else if (R1 == "B+")
                {
                    SC1 = "3.5";
                }
                else if (R1 == "B")
                {
                    SC1 = "3.3";
                }
                else if (R1 == "B-")
                {
                    SC1 = "3";
                }else if (R1 == "C+")
                {
                    SC1 = "2.7";
                }else if (R1 == "C")
                {
                    SC1 = "2.5";
                }else if (R1 == "C-")
                {
                    SC1 = "2.3";
                }else if (R1 == "D+")
                {
                    SC1 = "2.0";
                }else if (R1 == "D")
                {
                    SC1 = "1.7";
                }else if (R1 == "D-")
                {
                    SC1 = "1.5";
                }else if (R1 == "E")
                {
                    SC1 = "0";
                }
                else
                {
                    SC1 = "AB";
                }
                //selecting result credit R2
                if (R2 == "A+")
                {
                    SC2 = "4";
                }
                else if (R2 == "A")
                {
                    SC2 = "4";
                }
                else if (R2 == "A-")
                {
                    SC2 = "3.7";
                }
                else if (R2 == "B+")
                {
                    SC2 = "3.5";
                }
                else if (R2 == "B")
                {
                    SC2 = "3.3";
                }
                else if (R2 == "B-")
                {
                    SC2 = "3";
                }
                else if (R2 == "C+")
                {
                    SC2 = "2.7";
                }
                else if (R2 == "C")
                {
                    SC2 = "2.5";
                }
                else if (R2 == "C-")
                {
                    SC2 = "2.3";
                }
                else if (R2 == "D+")
                {
                    SC2 = "2.0";
                }
                else if (R2 == "D")
                {
                    SC2 = "1.7";
                }
                else if (R2 == "D-")
                {
                    SC2 = "1.5";
                }
                else if (R2 == "E")
                {
                    SC2 = "0";
                }
                else
                {
                    SC2 = "AB";
                }
                //selecting result R3
                if (R3 == "A+")
                {
                    SC3 = "4";
                }
                else if (R3 == "A")
                {
                    SC3 = "4";
                }
                else if (R3 == "A-")
                {
                    SC3 = "3.7";
                }
                else if (R3 == "B+")
                {
                    SC3 = "3.5";
                }
                else if (R3 == "B")
                {
                    SC3 = "3.3";
                }
                else if (R3 == "B-")
                {
                    SC3 = "3";
                }
                else if (R3 == "C+")
                {
                    SC3 = "2.7";
                }
                else if (R3 == "C")
                {
                    SC3 = "2.5";
                }
                else if (R3 == "C-")
                {
                    SC3 = "2.3";
                }
                else if (R3 == "D+")
                {
                    SC3 = "2.0";
                }
                else if (R3 == "D")
                {
                    SC3 = "1.7";
                }
                else if (R3 == "D-")
                {
                    SC3 = "1.5";
                }
                else if (R3 == "E")
                {
                    SC3 = "0";
                }
                else
                {
                    SC3 = "AB";
                }
                //selecting result R4
                if (R4 == "A+")
                {
                    SC4 = "4";
                }
                else if (R4 == "A")
                {
                    SC4 = "4";
                }
                else if (R4 == "A-")
                {
                    SC4 = "3.7";
                }
                else if (R4 == "B+")
                {
                    SC4 = "3.5";
                }
                else if (R4 == "B")
                {
                    SC4 = "3.3";
                }
                else if (R4 == "B-")
                {
                    SC4 = "3";
                }
                else if (R4 == "C+")
                {
                    SC4 = "2.7";
                }
                else if (R4 == "C")
                {
                    SC4 = "2.5";
                }
                else if (R4 == "C-")
                {
                    SC4 = "2.3";
                }
                else if (R4 == "D+")
                {
                    SC4 = "2.0";
                }
                else if (R4 == "D")
                {
                    SC4 = "1.7";
                }
                else if (R4 == "D-")
                {
                    SC4 = "1.5";
                }
                else if (R4 == "E")
                {
                    SC4 = "0";
                }
                else
                {
                    SC4 = "AB";
                }


                //dgvTable.Rows.Add(subjectNames, results,credits,gpas, weights);
                addRows(cbSubject1.Text, R1, SC1, txtCredit1.Text, gpas, cbWeight.Text);
                addRows(cbSubject2.Text, R2, SC2, txtCredit2.Text, gpas, cbWeight.Text);
                addRows(cbSubject3.Text, R3, SC3, txtCredit3.Text, gpas, cbWeight.Text);
                addRows(cbSubject4.Text, R4, SC4, txtCredit4.Text, gpas, cbWeight.Text);
                addRows(cbSubject5.Text, R5, SC5, txtCredit5.Text, gpas, cbWeight.Text);
                addRows(cbSubject6.Text, R6, SC6, txtCredit6.Text, gpas, cbWeight.Text);
                addRows(cbSubject7.Text, R7, SC7, txtCredit7.Text, gpas, cbWeight.Text);
                addRows(cbSubject8.Text, R8, SC8, txtCredit8.Text, gpas, cbWeight.Text);
                

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
            MessageBox.Show("Clear Succussfully");
            cbSubject1.Text = cbSubject2.Text = cbSubject3.Text = cbSubject4.Text = cbResult5.Text = cbResult7.Text = cbResult6.Text = cbResult8.Text = cbResult1.Text = cbResult2.Text = cbResult3.Text = cbResult4.Text = cbResult5.Text = cbResult6.Text = cbResult7.Text = cbResult8.Text = cbWeight.Text = txtCredit1.Text = txtCredit2.Text= txtCredit3.Text= txtCredit4.Text= txtCredit5.Text= txtCredit6.Text= txtCredit7.Text= txtCredit8.Text = "";
            dgvTable.Rows.Clear();
            cbSubject1.Select();
        }
    }
}
