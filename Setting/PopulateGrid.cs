using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreDemo.Setting
{
    static class PopulateGrid
    {
        static public void Populategrid(string cmd,DataGridView DG)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connstr))
            {
                conn.Open();
                string sql = cmd;
                SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DG.DataSource = ds.Tables[0];
            }
        }



        static public void KostylePopulateGrid(string pagesize,ComboBox comboBox1,DataGridView ClientsGrid,TextBox emailtxtbox,TextBox Fiotxtbox,TextBox phonetxtbox,int page,string Sort)
        {
            if (pagesize == "Все")
            {
                if (comboBox1.Text == "" || comboBox1.Text == "Все")
                    PopulateGrid.Populategrid($@"Select * From ClientImport
                                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                                        ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
                else PopulateGrid.Populategrid($@"Select * From ClientImport
                                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                                        ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            }
            else
            {
                if (comboBox1.Text == "" || comboBox1.Text == "Все")
                    PopulateGrid.Populategrid($@"Select * From ClientImport
                                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                                        ([Пол] Like N'%{phonetxtbox.Text}%')
                                        Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
                else PopulateGrid.Populategrid($@"Select * From ClientImport
                                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                                        ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
                                        Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            }
        }
    }
}
