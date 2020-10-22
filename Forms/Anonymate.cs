using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anonymator.Classes;
using Microsoft.Office.Interop.Excel;

namespace Anonymator
{
    public partial class Anonymate : Form
    {
        private MappingDetails _mappingDetails;
        private Db_Explorer _dbExplorer;
        //private Mapping _anonymiser;
        private Form _previousForm;

        public Anonymate()
        { }

        public Anonymate(MappingDetails mappingDetails, Db_Explorer db_Explorer, Form previousForm)
        {
            _mappingDetails = mappingDetails;
            _dbExplorer = db_Explorer;
            _previousForm = previousForm;
            InitializeComponent();
        }

        private void Anonymate_Load(object sender, EventArgs e)
        {
            string columnList = string.Empty;

            foreach (Mapping mapping in _mappingDetails.Mappings)
            {
                if (mapping.Anonymiser == Anonymizers.Drop)
                    continue;

                if (string.IsNullOrEmpty(columnList) == false)
                    columnList += ", ";

                columnList += $"[{mapping.Column.Name}]";
            }

            string query = string.Format("Select {0} from {1}", columnList, _mappingDetails.TableName);
            DataSet dataSet = _dbExplorer.LoadData(query);
            System.Data.DataTable dataTable = dataSet.Tables[0];

            Anonymizer.Anonymate(dataTable, _mappingDetails);

            Anonymate_GV.DataSource = dataTable;
        }

        private void btn_ChangeDB_Click(object sender, EventArgs e)
        {
            ConnectDB changeDB = new ConnectDB();
            changeDB.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            _previousForm.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_NextTable_Click(object sender, EventArgs e)
        {
            tableSelect nextTable = new tableSelect(_dbExplorer);
            nextTable.Show();
            this.Hide();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            WriteData();
            
        }

        private void Anonymate_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WriteData()
        {
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx|Comma separated values (*.csv)|*.csv";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Title = "Save data as";

            DialogResult dialogResult = saveFileDialog.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
                return;

            string fileName = saveFileDialog.FileName;

            Microsoft.Office.Interop.Excel.Application Export = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Export.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Export.ActiveSheet;
            //Export.Visible = true;

            for (int col = 1; col < Anonymate_GV.Columns.Count + 1; col++)
            {
                ws.Cells[1, col] = Anonymate_GV.Columns[col - 1].HeaderText;
            }

            for (int row = 0; row < Anonymate_GV.RowCount - 1; row++)
            {
                for (int j = 0; j < Anonymate_GV.Columns.Count; j++)
                {
                    object cellValue = Anonymate_GV.Rows[row].Cells[j].Value;

                    if (!(cellValue == null || cellValue == DBNull.Value))
                        ws.Cells[row + 2, j + 1] = Anonymate_GV.Rows[row].Cells[j].Value.ToString();
                }
            }
            XlFileFormat fileFormat = fileName.EndsWith(".csv") ? XlFileFormat.xlCSVWindows : XlFileFormat.xlWorkbookDefault;

            wb.SaveAs(fileName, fileFormat, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);

            Export.Quit();
        }
    }

}
