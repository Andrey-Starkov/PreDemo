using PreDemo.Class;
using PreDemo.Setting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemo.Utils
{
    static class Database
    {
        static public void Add(Client client)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connstr))
            {
                conn.Open();
                string sql = $"Insert Into ClientImport values (N'{client.ID}',N'{client.Name}',N'{client.Surname}',N'{client.ID}',N'{client.BirtDay}',N'{client.RegDay}',N'{client.Email}',N'{client.Phone}',N'{client.Gender}',N'{client.Photo}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
        }

        static public void Delete(int Id)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connstr))
            {
                conn.Open();
                string sql = $"Delete FROM ClientImport Where [Имя] = {Id}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
