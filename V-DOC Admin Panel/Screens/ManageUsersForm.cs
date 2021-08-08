using DBFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_DOC_Admin_Panel.Screens.Mechanic;
using V_DOC_Admin_Panel.Screens.Settings;
using V_DOC_Admin_Panel.Screens.User;
using V_DOC_Admin_Panel.Utilities.Lists;

namespace V_DOC_Admin_Panel.Screens
{
    public partial class ManageUsersForm : Form
    {
        string cs = "Data Source=TALHA;Initial Catalog=UserDetails;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void AddUserbtn_Click(object sender, EventArgs e)
        {
            MechanicInfoForm fm = new MechanicInfoForm();
            fm.Show();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                ListData.LoadDataIntoDataGridView(UsersGridView, "usp_getallusers");
                UsersGridView.AllowUserToAddRows = false;
                
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            try
            {
                ListData.LoadDataIntoDataGridView(NotificationsGridView, "usp_getallnotifications");
                NotificationsGridView.AllowUserToAddRows = false;

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            try
            {
                ListData.LoadDataIntoDataGridView(CarsGridView, "usp_getallcars");
                CarsGridView.AllowUserToAddRows = false;
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            try
            {
                ListData.LoadDataIntoDataGridView(TrackersGridView, "usp_getalltrackers");
                TrackersGridView.AllowUserToAddRows = false;
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            try
            {
                ListData.LoadDataIntoDataGridView(MechanicsGridView, "usp_getallmechanics");
                MechanicsGridView.AllowUserToAddRows = false;
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
            try
            {
                ListData.LoadDataIntoDataGridView(NotiLogGridView, "usp_getallLogs");
                NotiLogGridView.AllowUserToAddRows = false;
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }

        }

        private void ManageUsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Deluser_Click(object sender, EventArgs e)
        {
            UserInfoForm u = new UserInfoForm();
            u.ShowDialog();
            LoadDataIntoDataGridView();
        }

        private void MechanicsGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = MechanicsGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int planId = Convert.ToInt32(MechanicsGridView.Rows[rowIndex].Cells["MechanicID"].Value);
                //ShowPlanExecutionAssigneeScreen(planId, true);
                ShowPlanExecutionAuditScreen(planId, true);
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }
        private void ShowPlanExecutionAuditScreen(int planId, bool isUpdate)
        {
            MechanicInfoForm eif = new MechanicInfoForm();
            eif.MechId = planId;
            eif.IsUpdate = isUpdate;
            eif.ShowDialog();

            LoadDataIntoDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingInfoForm s = new SettingInfoForm();
            s.ShowDialog();
        }

        private void UserSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from users where email like '" + UserSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                UsersGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void CarSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Cars where Email like '" + CarSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                CarsGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void TrackerSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from trackers where email like '" + TrackerSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                TrackersGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void MechanicSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from mechanics where phone like '" + MechanicSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                MechanicsGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void NotiLogsSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from NotificationLogs where email like '" + NotiLogsSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                NotiLogGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }

        private void NotificationSearchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Notifications where email like '" + NotificationSearchtxt.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                NotificationsGridView.DataSource = dt;
                con.Close();

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }
    }
}
