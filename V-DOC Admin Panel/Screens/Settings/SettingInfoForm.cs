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

namespace V_DOC_Admin_Panel.Screens.Settings
{
    public partial class SettingInfoForm : Form
    {
        public SettingInfoForm()
        {
            InitializeComponent();
        }

        private void SettingInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataAndBindToControlIfUpdate();
        }
        private void LoadDataAndBindToControlIfUpdate()
        {
                try
                {
                    DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                    
                    DataTable dtBranch = db.GetDataList("usp_getallsettings");
                    DataRow row = dtBranch.Rows[0];

                    Filtertxt.Text = row[1].ToString();
                DataRow row2 = dtBranch.Rows[1];
                Fueltxt.Text = row2[1].ToString();
                DataRow row3 = dtBranch.Rows[2];
                Oiltxt.Text = row3[1].ToString();
                DataRow row4 = dtBranch.Rows[3];
                Plugtxt.Text = row4[1].ToString();
                DataRow row5 = dtBranch.Rows[4];
                Tuningtxt.Text = row5[1].ToString();
                DataRow row6 = dtBranch.Rows[5];
                Tyretxt.Text = row6[1].ToString();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveOrUpdateRecord("usp_updateSettings","Filter",Convert.ToInt32(Filtertxt.Text));
                SaveOrUpdateRecord("usp_updateSettings","Fuel", Convert.ToInt32(Fueltxt.Text));
                SaveOrUpdateRecord("usp_updateSettings","Oil", Convert.ToInt32(Oiltxt.Text));
                SaveOrUpdateRecord("usp_updateSettings","Plug", Convert.ToInt32(Plugtxt.Text));
                SaveOrUpdateRecord("usp_updateSettings","Tuning", Convert.ToInt32(Tuningtxt.Text));
                SaveOrUpdateRecord("usp_updateSettings", "Tyre", Convert.ToInt32(Tyretxt.Text));
                SMMeessageBox.ShowSuccessMessage("Record saved Successfully");
                this.Close();
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void SaveOrUpdateRecord(string storedProcName,string type,int mileage)
        {
            try
            {

                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord(storedProcName, GetObject(type,mileage));
            }
            catch (Exception g)
            {

                MessageBox.Show(g.Message);
            }

        }
        private Setting GetObject(string type,int mileage)
        {
            Setting p = new Setting();
            p.Type =type;
            p.Mileage=mileage;
            return p;
        }
    }
}
