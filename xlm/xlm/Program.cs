using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace xlm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string conncection = "Data Source=LAPTOP-AOCATCH2\\SQLEXPRESS;Initial Catalog=ali;Integrated Security=True";
            string query = "SELECT * FROM student";

            SqlDataAdapter da = new SqlDataAdapter(query, conncection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            string filepath = Path.Combine(System.Environment.CurrentDirectory, "student.xml");
            ds.WriteXml(filepath);

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(filepath);

            //for multipal product
            XmlNodeList nodelist = xmldoc.DocumentElement.SelectNodes("Table");
            foreach (XmlNode node in nodelist)
            {
                Console.WriteLine(node.SelectSingleNode("id").InnerText);
                Console.WriteLine(node.SelectSingleNode("name").InnerText);
            }

            //XmlNode node = xmldoc.DocumentElement.SelectSingleNode("student");

            //Console.WriteLine(node.SelectSingleNode("id").InnerText);
            //Console.WriteLine(node.SelectSingleNode("name").InnerText);

            Console.ReadKey();
        }
    }
}
