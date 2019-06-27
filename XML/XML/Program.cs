using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = Path.Combine(System.Environment.CurrentDirectory,"student.xml");
            string connection = "Data Source=.;Initial Catalog=login;Integrated Security=True";
            string query = "SELECT * FROM student";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.WriteXml(filepath);


            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(filepath);
            //XmlNode node = xmldoc.DocumentElement.SelectSingleNode("Table");

            //Console.WriteLine(node.SelectSingleNode("std_id").InnerText);
            //Console.WriteLine(node.SelectSingleNode("std_name").InnerText);
            //Console.WriteLine(node.SelectSingleNode("age").InnerText);
            //Console.WriteLine(node.SelectSingleNode("smester").InnerText);
            XmlNodeList nodeList = xmldoc.DocumentElement.SelectNodes("Table");
            foreach(XmlNode node in nodeList)
            {
                Console.WriteLine(node.SelectSingleNode("std_id").InnerText);
                Console.WriteLine(node.SelectSingleNode("std_name").InnerText);
                Console.WriteLine(node.SelectSingleNode("age").InnerText);
                Console.WriteLine(node.SelectSingleNode("smester").InnerText);
            }




            Console.ReadKey();


        }
    }
}
