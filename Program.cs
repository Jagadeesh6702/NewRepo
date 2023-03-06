using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Xml;

namespace Import_Xml_to_Db
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adpter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string sql;

            string opco;
            string ElementName;
            string ProductNo;
            string ProductName;
            string ProductRevision;
            string ProductVersion;
            string Vendor;
            string UnitLocation;
            string HardWareType;

            connetionString = @"Data Source=STLINDADM002\SQLEXPRESS;Initial Catalog=database45;Integrated Security=True";

            connection = new SqlConnection(connetionString);

            xmlFile = XmlReader.Create(@"C:\Users\sandhata\source\repos\XMLFileHandlings\XMLFileHandlings\Employees.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            int i;
            connection.Open();
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
                name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                positon = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                joinYear = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                salary = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                sql = "insert into Employee values(" + id + ",'" + name.Replace("'", "''") + "','" + positon.Replace("'", "''") + "','" + joinYear.Replace("'", "''") + "','" + salary.Replace("'", "''");
                command = new SqlCommand(sql, connection);
                adpter.InsertCommand = command;
                adpter.InsertCommand.ExecuteNonQuery();
            }
            Console.WriteLine("success");
            connection.Close();

            //Dts.TaskResult = (int)ScriptResults.Success;

        }
    }
}