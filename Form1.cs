using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGrades_If
{
    public partial class GradeCalculator : Form
    {
        public GradeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Grade = 0;//variable to hold the grade
            string Name = txtName.Text;
            Grade = Convert.ToInt32(txtGrade.Text);

            if (Grade < 0)
            {
                
                lblDataError.Text = "Enter positive Number";
                lbxGrade.Items.Add("Data Error");
            }
            else if (Grade > 100)
            {
                lblDataError.Text = "You can't get thet";
                lbxGrade.Items.Add("Data Error");
            }
            else if (Grade < 50)
            {
                lbxGrade.Items.Add(Name + " got "+ Grade + "= Fail");
            }
            else
            {
                lbxGrade.Items.Add(Name+ " got " +Grade + " =Pass");
            }

        }
    }
}
