using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DTF_DAL.SQLData
{
    public class SQLConnect
    {
        private SqlConnection SqlObject;

        public SQLConnect(string dataSource, string DBName, string DBUserName, string DBPassword)
        {
            this.SqlObject = new SqlConnection("Data Source=" + dataSource + ";" +
            "Initial Catalog=" + DBName + ";" +
            "User id=" + DBName + ";" +
            "Password=" + DBPassword + ";");
        }
    }
}
