using PreDemo.Setting;
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

namespace PreDemo.Forms
{
    public partial class Info : Form
    {
        private string Surname = "";
        public Info(string surname)
        {
            InitializeComponent();
            Surname = surname;
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            using (SqlConnection conn = new SqlConnection(Connection.connstr))
            {
                conn.Open();
                string sql = $@"Select * From ClientImport as C
                                Inner join ClientServiceImport as S
                                on S.[Клиент]=C.[Отчество]
                                Where [Отчество] = N'{Surname}'
                                Order by [Начало оказания услуги]";
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                Service.DataSource = ds.Tables[0];
            }
        }

    }
}
