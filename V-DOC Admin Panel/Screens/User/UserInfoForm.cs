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
using V_DOC_Admin_Panel.Utilities;
using V_DOC_Admin_Panel.Utilities.Lists;

namespace V_DOC_Admin_Panel.Screens.User
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
        }
        private void LoadDataIntoComboBoxes()
        {

            try
            {
                ListData.LoadDataIntoComboBox(Userscb, "usp_GetUsersEmails");
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DbParameters para = new DbParameters();
            para.Parameter = "@useremail";
            para.value = Userscb.SelectedValue;
            int n = Convert.ToInt32(db.GetScalerValue("usp_DeleteUserData", para));
            if (n == 0)
            {
                SMMeessageBox.ShowSuccessMessage("Record Deleted Successfully");
                this.Close();
            }
            else
            {
                SMMeessageBox.ShowErrorMessage("Failed to Delete.");
            }
            
        }
    }
}
