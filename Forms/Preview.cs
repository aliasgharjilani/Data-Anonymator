using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anonymator.Classes;

namespace Anonymator
{
    public partial class Preview : Form
    {
        private MappingDetails _mappingDetails;
        private Db_Explorer _dbExplorer;
        //private Mapping _column;
        //private Mapping _anonymiser;
        //Anonymizer A = new Anonymizer();
        //db_Explorer db = new db_Explorer();
        private Form _previousForm;

        public Preview()
        { }
        public Preview(MappingDetails mappingDetails, Db_Explorer db_Explorer, Form previousForm)
        {
            _mappingDetails = mappingDetails;
            _dbExplorer = db_Explorer;
            _previousForm = previousForm;
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Hide();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            string columnList = string.Empty;

            foreach (Mapping mapping in _mappingDetails.Mappings)           //????
            {
                if (mapping.Anonymiser == Anonymizers.Drop)
                    continue;

                if (string.IsNullOrEmpty(columnList) == false)
                    columnList += ", ";

                columnList += $"[{mapping.Column.Name}]";          //?????
            }

            string query = string.Format("Select top 5 {0} from {1}", columnList, _mappingDetails.TableName);
            DataSet dataSet =_dbExplorer.LoadData(query);
            DataTable dataTable = dataSet.Tables[0];

            Anonymizer.Anonymate(dataTable, _mappingDetails);

            Preview_GV.DataSource = dataTable;
        }

        private void Preview_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    
}
