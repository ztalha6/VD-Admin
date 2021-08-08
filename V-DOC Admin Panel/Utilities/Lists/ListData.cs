using DBFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_DOC_Admin_Panel.Utilities.Lists
{
    class ListData
    {
        public static void LoadDataIntoDataGridView(DataGridView dgv, string storePorcName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(storePorcName);
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public static void LoadDataIntoDataGridView(DataGridView dgv, string storePorcName, DbParameters parameter)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            dgv.DataSource = db.GetDataList(storePorcName, parameter);
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void LoadDataIntoComboBox(ComboBox cb, DbParameters parameter)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList("usp_ListTypeDataGetDataByListTypeId", parameter);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public static void LoadDataIntoComboBox(ComboBox cb, string storedProcName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public static void LoadDataIntoGridviewComboBox(DataGridViewComboBoxColumn cb, string storedProcName)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            //cb.SelectedIndex = -1;
            //cb.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public static void LoadDataIntoComboBox(ComboBox cb, string storedProcName, DbParameters parameter)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName, parameter);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public static void LoadDataIntoComboBox(ComboBox cb, string storedProcName, DbParameters[] parameters)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            cb.DataSource = db.GetDataList(storedProcName, parameters);
            cb.DisplayMember = "Description";
            cb.ValueMember = "Id";
            cb.SelectedIndex = -1;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
