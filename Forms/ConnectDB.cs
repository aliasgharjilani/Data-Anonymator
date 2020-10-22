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
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
        }

        private void btn_connecrDB_Click(object sender, EventArgs e)
        {
            var dSource = txt_dSource.Text;
            var dbName = txt_dbName.Text;
            var dbUser = txt_dbUser.Text;
            var dbPass = txt_dbPass.Text;

            try
            {
                var dbExplorer = new Db_Explorer(dSource, dbName, dbUser, dbPass);
                dbExplorer.TestConnection();

                tableSelect table = new tableSelect(dbExplorer, dbName);
                table.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                pic_Error.Visible = true;
                lblError.Visible = true;
                lblError.Text = ex.Message;
            }
        }

        private void ConnectDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txt_dSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectDB_Load(object sender, EventArgs e)
        {

        }
    }
}
