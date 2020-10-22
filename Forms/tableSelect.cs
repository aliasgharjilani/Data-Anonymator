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

namespace Anonymator
{
    public partial class tableSelect : Form
    {
        private Db_Explorer _dbExplorer;
        string tableName;
        string _dbName;

        public tableSelect(Db_Explorer dbExplorer)
        {
            _dbExplorer = dbExplorer;
            InitializeComponent();
        }
        public tableSelect(Db_Explorer dbExplorer, string dbName)
        {
            _dbExplorer = dbExplorer;
            _dbName = dbName;
            InitializeComponent();
        }

        private void tableSelect_Load(object sender, EventArgs e)
        {
            lbl_SubTitle.Text = $"Selected Database: {_dbName}";
            var tableNameList = _dbExplorer.GetTableList();
            foreach (string tableName in tableNameList)
            {
                tableList.Items.Add(tableName);
            }
        }
        private void btn_selectTable_Click(object sender, EventArgs e)
        {
            if (this.tableList.SelectedIndex != -1)
            {
                tableName = tableList.GetItemText(tableList.SelectedItem);
                columnSelect column = new columnSelect(tableName, _dbExplorer);
                column.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Please select any table name");
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            ConnectDB connect = new ConnectDB();
            connect.Show();
            this.Hide();
        }

        private void tableSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
