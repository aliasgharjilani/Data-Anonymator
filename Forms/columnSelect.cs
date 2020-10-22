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
using Anonymator.Enums;

namespace Anonymator
{
    public partial class columnSelect : Form
    {
        private string _tableSelect;
        private Db_Explorer _dbExplorer;
        private Dictionary<string, bool> _columnSelectionStatus = new Dictionary<string, bool>();      
        private Dictionary<string, List<Anonymizers>> _dataTypeToAnonymiserMapping;
        private List<ColumnDetails> _tableColumns;

        //string columnName;
        public columnSelect(Db_Explorer db_Explorer)
        {
            _dbExplorer = db_Explorer;
            InitializeComponent();
        }

        public columnSelect(string tableName, Db_Explorer db_Explorer)
        {
            _tableSelect = tableName;
            _dbExplorer = db_Explorer;
            InitializeComponent();
        }

        private void columnSelect_Load(object sender, EventArgs e)
        {
            lbl_SubTitle.Text = $"Selected Table: {_tableSelect}";
            this.Height = 520;
            gbMain.Height = 400;

            cmb_Anonymizer.Items.Clear();
            cmb_Anonymizer.Items.Add("Choose Anonymator");
            foreach (Anonymizers anonymizer in Enum.GetValues(typeof(Anonymizers)))     //????????
            {
                cmb_Anonymizer.Items.Add(anonymizer.ToString());               
            }

            cbDateOptionsOffsetUnit.Items.Clear();
            foreach (DateOffsetUnit unit in Enum.GetValues(typeof(DateOffsetUnit)))     //????????
            {
                cbDateOptionsOffsetUnit.Items.Add(unit.ToString());
            }
            
            _dataTypeToAnonymiserMapping = new Dictionary<string, List<Anonymizers>>();

            _dataTypeToAnonymiserMapping.Add("int", new List<Anonymizers> { Anonymizers.Integer, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("varchar", new List<Anonymizers> {Anonymizers.Alpha, Anonymizers.AlphaNumeric, Anonymizers.Character, Anonymizers.Double, Anonymizers.Drop, Anonymizers.Float, Anonymizers.Integer, Anonymizers.NoAction });  
            _dataTypeToAnonymiserMapping.Add("date", new List<Anonymizers> { Anonymizers.Date, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("datetime", new List<Anonymizers> { Anonymizers.Date, Anonymizers.DateTime, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("float", new List<Anonymizers> { Anonymizers.Float, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("Double", new List<Anonymizers> { Anonymizers.Double, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("bit", new List<Anonymizers> { Anonymizers.Boolean, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("char", new List<Anonymizers> { Anonymizers.Character, Anonymizers.Drop, Anonymizers.NoAction });
            _dataTypeToAnonymiserMapping.Add("uniqueidentifier", new List<Anonymizers> { Anonymizers.Drop, Anonymizers.GUID, Anonymizers.NoAction });

            int width = 122;
            lv_AnonymizerDetails.Columns.Clear();
            ColumnHeader col1 = lv_AnonymizerDetails.Columns.Add("Column Name", width);
            col1.ListView.Font = new Font(col1.ListView.Font, FontStyle.Bold);

            lv_AnonymizerDetails.Columns.Add("Column Type", width);
            lv_AnonymizerDetails.Columns.Add("Anonymator Type", width);
            lv_AnonymizerDetails.Columns.Add("Selected Option", width);

            _tableColumns = _dbExplorer.GetColumnList(_tableSelect);

            foreach (var column in _tableColumns)           
            {
                _columnSelectionStatus.Add(column.Name, false);
            }

            PopulateColumnList();
        }

        private void PopulateColumnList()           
        {
            columnList.Items.Clear();
            foreach (var col in _columnSelectionStatus)
            {
                if(col.Value == false)
                    columnList.Items.Add(col.Key);
            }
        }

        private void pb_Select_Click(object sender, EventArgs e)
        {
            if (this.columnList.SelectedIndex != -1 && this.cmb_Anonymizer.SelectedIndex > 0)
            {

                string selectedColName = columnList.SelectedItem.ToString();
                string selectedAnonymizer = cmb_Anonymizer.SelectedItem.ToString();

                ColumnDetails columnDetails = _tableColumns.First(c => c.Name.Equals(selectedColName));
                List<Anonymizers> allowedAnonymizers = _dataTypeToAnonymiserMapping[columnDetails.Type];

                Anonymizers anonymizer = (Anonymizers)Enum.Parse(typeof(Anonymizers), selectedAnonymizer);

                if (!allowedAnonymizers.Contains(anonymizer))
                {
                    string errorMessage = "Select appropriate anonymizer";
                    foreach (Anonymizers allowedAnonymizer in allowedAnonymizers)
                    {
                        errorMessage += Environment.NewLine + "-\t" + allowedAnonymizer.ToString();
                    }

                    MessageBox.Show(errorMessage, "Select anonymizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                

                Mapping mapping = null;                

                switch (anonymizer)
                {
                    case Anonymizers.Alpha:
                        AlphaMapping alphaMapping = new AlphaMapping();
                        if (radbtn_InitAlpha.Checked)
                            alphaMapping.SelectedOption = AlphaOptions.InitCase;
                        else if (radbtn_LowerAlpha.Checked)
                            alphaMapping.SelectedOption = AlphaOptions.LowerCase;
                        else if (radbtn_UpperAlpha.Checked)
                            alphaMapping.SelectedOption = AlphaOptions.UpperCase;
                        
                        mapping = alphaMapping;
                        break;

                    case Anonymizers.AlphaNumeric:
                    case Anonymizers.Character:
                        AlphaMapping alphaNumericMapping = new AlphaMapping();
                        if (radbtn_InitAlphaNum.Checked)
                            alphaNumericMapping.SelectedOption = AlphaOptions.InitCase;
                        else if (radbtn_LowerAlphaNum.Checked)
                            alphaNumericMapping.SelectedOption = AlphaOptions.LowerCase;
                        else if (radbtn_UpperAlphaNum.Checked)
                            alphaNumericMapping.SelectedOption = AlphaOptions.UpperCase;
                        else if(radbtn_IntegerAlphaNum.Checked)
                            alphaNumericMapping.SelectedOption = AlphaOptions.IntegerOnly;
                        
                        mapping = alphaNumericMapping;
                        break;

                    case Anonymizers.Integer:
                    case Anonymizers.Float:
                    case Anonymizers.Double:
                        if (ValidateNumericOptions() == false)
                            return;
                        
                        NumericMapping numericMapping = new NumericMapping
                        {
                            MatchSize = false,
                            IsPercentage = false,
                            MinRange = 0,
                            MaxRange = 0
                        };

                        if (radbtn_MatchInteger.Checked)
                        {
                            numericMapping.MatchSize = true;                            
                        }
                        else if (radbtn_RangeInteger.Checked)
                        {
                            numericMapping.MinRange = (int)nupMinInteger.Value;
                            numericMapping.MaxRange = (int)nupMaxInteger.Value;
                        }
                        else
                        {
                            numericMapping.IsPercentage = true;
                            numericMapping.PercentageValue = (int)nupPercentInteger.Value;
                        }
                        

                        mapping = numericMapping;
                        break;

                    case Anonymizers.Date:
                    case Anonymizers.DateTime:
                        if (ValidateDateOptions() == false)
                            return;
                        
                        DateMapping dateMapping = new DateMapping
                        {
                            IsPast = false,
                            IsFuture = false,
                            Offset = (int)nupDateOffset.Value,
                            OffsetUnit = (DateOffsetUnit)Enum.Parse(typeof(DateOffsetUnit), cbDateOptionsOffsetUnit.SelectedItem.ToString()),
                            IsDateTime = anonymizer == Anonymizers.DateTime
                        };

                        if (radbtn_PastDate.Checked)
                        {
                            dateMapping.IsPast = true;
                        }
                        else if (radbtn_FutureDate.Checked)
                        {
                            dateMapping.IsFuture = true;
                        }
                        else if (radbtn_BothDate.Checked)
                        {
                            dateMapping.IsPast = true;
                            dateMapping.IsFuture = true;
                        }

                        mapping = dateMapping;
                        break;
                                                           
                    default:
                        mapping = new Mapping();
                        break;
                }

                mapping.Column = columnDetails;
                mapping.Anonymiser = anonymizer;

                ListViewItem item = lv_AnonymizerDetails.Items.Add(selectedColName);
                item.Font = new Font(item.Font, FontStyle.Regular);
                item.Tag = mapping;
                item.SubItems.Add(columnDetails.Type);
                item.SubItems.Add(selectedAnonymizer);
                item.SubItems.Add(mapping.GetSelectedOptions());

                _columnSelectionStatus[selectedColName] = true;
                PopulateColumnList();

                this.columnList.SelectedIndex = -1;
                this.cmb_Anonymizer.SelectedIndex = 0;

                ResetOptions();
            }
            else
            {
                MessageBox.Show("Select both Column and Anonymizer", "Select anonymizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetOptions()
        {
            radbtn_MatchInteger.Checked = true;
            nupMinInteger.Value = 0;
            nupMaxInteger.Value = 0;
            nupPercentInteger.Value = 1;
            radbtn_BothDate.Checked = true;
            nupDateOffset.Value = 1;
            cbDateOptionsOffsetUnit.SelectedIndex = 0;
            radbtn_InitAlpha.Checked = true;
            radbtn_InitAlphaNum.Checked = true;
        }

        private void pb_Deselect_Click(object sender, EventArgs e)
        {
            if (this.lv_AnonymizerDetails.SelectedItems.Count > 0)
            {
                _columnSelectionStatus[lv_AnonymizerDetails.SelectedItems[0].Text] = false;
                PopulateColumnList();
                lv_AnonymizerDetails.SelectedItems[0].Remove();
            }
        }

        private void btn_Anonymize_Click(object sender, EventArgs e)
        {
            if (this.lv_AnonymizerDetails.Items.Count == 0) {
                MessageBox.Show("Enter Detais to Anonymize");
            }
            else 
            {
                if (this.columnList.Items.Count != 0)
                {
                    MessageBox.Show("Select anonymizer for all columns", "Select anonymizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MappingDetails mappingDetails = GetMappingDetails();

                    Anonymate A = new Anonymate(mappingDetails, _dbExplorer, this);
                    A.Show();
                    this.Hide();
                }
            }
        }

        private MappingDetails GetMappingDetails()
        {
            MappingDetails mappingDetails = new MappingDetails(_tableSelect);

            foreach (ListViewItem item in lv_AnonymizerDetails.Items)
            {
                Mapping mapping = (Mapping)item.Tag;

                mappingDetails.AddMapping(mapping);
            }

            return mappingDetails;
        }


        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (this.lv_AnonymizerDetails.Items.Count == 0)
            {
                MessageBox.Show("Select anonymizer for all columns", "Select anonymizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (this.columnList.Items.Count != 0)
                {
                    MessageBox.Show("Select anonymizer for all columns", "Select anonymizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MappingDetails mappingDetails = GetMappingDetails();
                    Preview P = new Preview(mappingDetails, _dbExplorer, this);
                    P.Show();
                    this.Hide();
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (lv_AnonymizerDetails.Items.Count > 0)
            { 
                if (MessageBox.Show("Mappings will be lost!\nAre you sure to continue?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            }

            tableSelect tabSelect = new tableSelect(_dbExplorer);
            tabSelect.Show();
            this.Hide();
        }

        private void cmb_Anonymizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbNumricOptions.Left = 12;
            gbNumricOptions.Top = 499;
            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Integer.ToString()))
            {
                gbNumricOptions.Left = 258;
                gbNumricOptions.Top = 284;
            }

            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Float.ToString()))
            {
                gbNumricOptions.Left = 258;
                gbNumricOptions.Top = 284;
            }

            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Double.ToString()))
            {
                gbNumricOptions.Left = 258;
                gbNumricOptions.Top = 284;
            }

            gbDateOptions.Left = 197;
            gbDateOptions.Top = 512;
            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Date.ToString()))
            {
                gbDateOptions.Left = 258;
                gbDateOptions.Top = 284;
            } 

            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.DateTime.ToString()))
            {
                gbDateOptions.Left = 258;
                gbDateOptions.Top = 284;
            }

            gbAlphaOptions.Left = 382;
            gbAlphaOptions.Top = 512;
            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Alpha.ToString()))
            {
                gbAlphaOptions.Left = 258;
                gbAlphaOptions.Top = 284;
            }

            gbAlphaNumericOptions.Left = 567;
            gbAlphaNumericOptions.Top = 513;
            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.AlphaNumeric.ToString()))
            {
                gbAlphaNumericOptions.Left = 258;
                gbAlphaNumericOptions.Top = 284;
            }
            if (cmb_Anonymizer.SelectedItem.ToString().Equals(Anonymizers.Character.ToString()))
            {
                gbAlphaNumericOptions.Left = 258;
                gbAlphaNumericOptions.Top = 284;
            }
           
            
        }

        private void columnSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private bool ValidateDateOptions()
        {
            if (cbDateOptionsOffsetUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Select date offset unit from the list");
                return false;
            }
            return true;
        }

        private bool ValidateNumericOptions()
        {
            if (radbtn_RangeInteger.Checked && nupMinInteger.Value == 0 && nupMaxInteger.Value == 0)
            {
                MessageBox.Show("Enter range values", "Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radbtn_RangeInteger.Checked && nupMinInteger.Value == nupMaxInteger.Value)
            {
                MessageBox.Show("Range values should be different", "Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (radbtn_RangeInteger.Checked && nupMinInteger.Value > nupMaxInteger.Value)
            {
                MessageBox.Show("Value of Minimum range should be smaller then Maximum range", "Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        //private convertDateTime()
        //{
        //    var dateAndTime = DateTime.Now;
        //    var date = dateAndTime.Date;
        //    var time = dateAndTime.TimeOfDay;
        //    ColumnDetails Column = new ColumnDetails();
        //    return Date;
        //}

    }
}
