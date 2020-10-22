using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Anonymator
{
    public class Db_Explorer
    {
        private string _connectionString, _databaseName;

        public Db_Explorer(string dataSource, string initialCatalog, string userId, string password)
        {
            _connectionString = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3}", dataSource, initialCatalog, userId, password);
            _databaseName = initialCatalog;
        }
        public Db_Explorer(string connectionString)        
        {
            _connectionString = connectionString;
        }
        private void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }

        private SqlConnection GetConnection()           
        {
            return new SqlConnection(_connectionString);
        }
        public void TestConnection()
        {
            var connection = GetConnection();
            connection.Open();
            CloseConnection(connection);
        }

        public List<string> GetTableList()
        {
            List<string> tables = new List<string>();
            //Dont Hardcode
            string qry = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_CATALOG='{_databaseName}'";
            
            var connection = GetConnection();
            connection.Open();
            var cmd = new SqlCommand(qry, connection);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tables.Add(dr["TABLE_NAME"].ToString());
            }
            CloseConnection(connection);
            return tables;
        }
        public List<ColumnDetails> GetColumnList(String tName)
        {
            List<string> primaryKeys = GetPrimaryKeys(tName);

            List<ColumnDetails> columns = new List<ColumnDetails>();

            string qry = "SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION, DATETIME_PRECISION, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tName + "' ORDER BY ORDINAL_POSITION";
            //string qry = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tName  + "' ORDER BY ORDINAL_POSITION";
 
            var connection = GetConnection();
            connection.Open();
            var cmd = new SqlCommand(qry, connection);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ColumnDetails columnDetails = new ColumnDetails();                
                columnDetails.Name = dr["COLUMN_NAME"].ToString();
                columnDetails.Type = dr["DATA_TYPE"].ToString();
                if (!dr.IsDBNull(dr.GetOrdinal("CHARACTER_MAXIMUM_LENGTH")))
                    columnDetails.Size = float.Parse(dr["CHARACTER_MAXIMUM_LENGTH"].ToString());

                columnDetails.Nullable = dr["IS_NULLABLE"].ToString() == "YES" ? true : false;
                columnDetails.IsPK = primaryKeys.Contains(columnDetails.Name);

                columns.Add(columnDetails);
            }

            CloseConnection(connection);

            return columns;
        }

        public DataSet LoadData(string query)
        {
            var connection = GetConnection();
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dataSet);

            return dataSet;
        }

        private List<string> GetPrimaryKeys(string tableName)       
        {
            List<string> primaryKeys = new List<string>();

            string query = @"SELECT Col.Column_Name 
                             FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col 
                             WHERE Col.Constraint_Name = Tab.Constraint_Name 
                             AND Col.Table_Name = Tab.Table_Name    
                             AND Constraint_Type = 'PRIMARY KEY'
                             AND Col.Table_Name = '" + tableName + "'";

            var connection = GetConnection();
            connection.Open();
            var cmd = new SqlCommand(query, connection);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                primaryKeys.Add(dr["COLUMN_NAME"].ToString());
            }

            CloseConnection(connection);

            return primaryKeys;
        }
    }
}
