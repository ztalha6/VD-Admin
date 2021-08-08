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
using V_DOC_Admin_Panel.Models;
using V_DOC_Admin_Panel.Utilities;

namespace V_DOC_Admin_Panel.Screens.Mechanic
{
    public partial class MechanicInfoForm : Form
    {
        public int MechId { get; internal set; }
        public bool IsUpdate { get; internal set; }

        public MechanicInfoForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsUpdate)
                {
                    SaveOrUpdateRecord("usp_updateMechanic");
                    SMMeessageBox.ShowSuccessMessage("Record saved Successfully");
                    this.Close();
                }
                else
                {
                    SaveOrUpdateRecord("usp_InsertMechanic");
                    SMMeessageBox.ShowSuccessMessage("Record saved Successfully");
                    this.Close();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }
        private void SaveOrUpdateRecord(string storedProcName)
        {
            try
            {
                
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord(storedProcName, GetObject());
            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message);
            }

        }

        private Mechanics GetObject()
        {
            Mechanics p = new Mechanics();
            if (this.IsUpdate)
            {
                p.MechanicID = this.MechId;
                p.FirstName = FirstNametxt.Text;
                p.LastName = LastNametxt.Text;
                p.Phone = Phonetxt.Text;
                p.Address = Addresstxt.Text;
                p.Latitude = decimal.Parse(Latitudetxt.Text);
                p.Longitude = decimal.Parse(Longitudetxt.Text);
                p.InsertedBy = "Admin";
                return p;
            }
            else
            {
                p.FirstName = FirstNametxt.Text;
                p.LastName = LastNametxt.Text;
                p.Phone = Phonetxt.Text;
                p.Address = Addresstxt.Text;
                p.Latitude = decimal.Parse(Latitudetxt.Text);
                p.Longitude = decimal.Parse(Longitudetxt.Text);
                p.InsertedBy = "Admin";
                return p;
            }
           
        }

        private void MechanicInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataAndBindToControlIfUpdate();
        }
        private void LoadDataAndBindToControlIfUpdate()
        {
            if (IsUpdate)
            {
                try
                {
                    DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                    DbParameters para = new DbParameters();
                    para.Parameter = "@MechanicID";
                    para.value = this.MechId;
                    DataTable dtBranch = db.GetDataList("usp_GetMechanicbyID", para);
                    DataRow row = dtBranch.Rows[0];

                    MechanicIDtxt.Text = row["MechanicID"].ToString();
                    FirstNametxt.Text = row["FirstName"].ToString();
                    LastNametxt.Text = row["LastName"].ToString();
                    Phonetxt.Text= row["Phone"].ToString();
                    Addresstxt.Text = row["Address"].ToString();
                    Latitudetxt.Text = row["Latitude"].ToString();
                    Longitudetxt.Text = row["Longitude"].ToString();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DbParameters para = new DbParameters();
            para.Parameter = "@MechanicID";
            para.value =this.MechId;
            int n = Convert.ToInt32(db.GetScalerValue("usp_DeleteMechanic", para));
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
