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
        string subjectNames, results, weights, gpas;
        double  credits ;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                subjectNames = txtSub1.Text ;
                results = cbResult1.Text ;
                credits = Convert.ToDouble(txtCredit1.Text);
                weights = cbWeight.Text ;




                //dgvTable.Rows.Add(subjectNames, results,credits,gpas, weights);
                addRows(txtSub1.Text,cbResult1.Text,txtCredit1.Text,gpas,cbWeight.Text);
                addRows(txtSub2.Text, cbResult2.Text, txtCredit2.Text, gpas, cbWeight.Text);
                addRows(txtSub3.Text, cbResult3.Text, txtCredit3.Text, gpas, cbWeight.Text);
                addRows(txtSub4.Text, cbResult4.Text, txtCredit4.Text, gpas, cbWeight.Text);
                addRows(txtSub5.Text, cbResult5.Text, txtCredit5.Text, gpas, cbWeight.Text);
                addRows(txtSub6.Text, cbResult6.Text, txtCredit6.Text, gpas, cbWeight.Text);
                addRows(txtSub7.Text, cbResult7.Text, txtCredit7.Text, gpas, cbWeight.Text);
                addRows(txtSub8.Text, cbResult8.Text, txtCredit8.Text, gpas, cbWeight.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ("Erro"));
            }
        }

        private void addRows(string Sname, string result, string credit, string gpa, string weight)
        {
            string[] row = { Sname, result, credit, gpa, weight };
            dgvTable.Rows.Add(row);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
