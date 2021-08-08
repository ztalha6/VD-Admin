using DBFramework;
using DBFramework.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_DOC_Admin_Panel.Screens;
using V_DOC_Admin_Panel.Utilities;

namespace V_DOC_Admin_Panel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ISFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                bool IsLoginDetailsCorrect = Convert.ToBoolean(db.GetScalerValue("usp_CheckLoginDetails", GetParameters()));


                if (IsLoginDetailsCorrect)
                {
                    //SaveOrUpdateRecord("usp_LoginHistoryAddNewLoginHistory");
                    //GetLoggedInUserSetting();
                    //this.Hide();
                    // DashboardForm df = new DashboardForm();
                    // df.Show();
                    //MessageBox.Show("Done");
                    
                    ManageUsersForm fm = new ManageUsersForm();
                    fm.Show();
                    this.Hide();

                }
                else
                {
                    SMMeessageBox.ShowErrorMessage("Username/Password not correct");
                }
            }
        }
        private bool ISFormValid()
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                SMMeessageBox.ShowErrorMessage("User name is required");
                textBox1.Clear();
                textBox1.Focus();
                return false;
            }

            if (textBox2.Text.Trim() == string.Empty)
            {
                SMMeessageBox.ShowErrorMessage("Password is required");
                textBox2.Clear();
                textBox2.Focus();
                return false;
            }

            return true;
        }
        private DbParameters[] GetParameters()
        {
            List<DbParameters> parameters = new List<DbParameters>();
            DbParameters dbparameter1 = new DbParameters();
            dbparameter1.Parameter = "@UserId";
            dbparameter1.value = textBox1.Text;
            parameters.Add(dbparameter1);

            DbParameters dbparameter2 = new DbParameters();
            dbparameter2.Parameter = "@Password";
            dbparameter2.value = textBox2.Text;
            parameters.Add(dbparameter2);


            return parameters.ToArray();
        }
    }
}
