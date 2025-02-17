using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMngmt1
{
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDepartments();

        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentsTbl";
            DepList.DataSource = Con.GetData(Query);

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTbl.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DepNameTbl.Text;
                    string Query = "Insert into DepartmentsTbl Values ('{0}')";
                    Query = string.Format(DepNameTbl.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Departments Added!");
                    DepNameTbl.Text = "";
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}
