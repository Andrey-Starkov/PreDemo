using PreDemo.Forms;
using PreDemo.Setting;
using PreDemo.Utils;
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

namespace PreDemo
{
    public partial class Form1 : Form
    {
        private int page = 1;
        private string pagesize = "10";
        private string Sort = "Имя";
        public Form1()
        {
            InitializeComponent();
            if (pagesize == "Все")
                PopulateGrid.Populategrid($@"Select * From ClientImport", ClientsGrid);
            else
                PopulateGrid.Populategrid($@"Select * From ClientImport Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY",ClientsGrid);
            DataGridViewButtonColumn Count = new DataGridViewButtonColumn 
            {
            
            Name = "Count",
            Text = "Узнать",
            HeaderText = "Посещения",
            UseColumnTextForButtonValue = true
            };

            ClientsGrid.Columns.Add(Count);

            DataGridViewButtonColumn Date = new DataGridViewButtonColumn
            {

                Name = "Date",
                Text = "Узнать",
                HeaderText = "Последнее посещение",
                UseColumnTextForButtonValue = true
            };

            ClientsGrid.Columns.Add(Date);

            DataGridViewButtonColumn Delete = new DataGridViewButtonColumn
            {

                Name = "Delete",
                Text = "Удалить",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };

            ClientsGrid.Columns.Add(Delete);


            pages.Text = page.ToString();
        }



        private void ClientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ClientsGrid.Columns["Count"].Index && e.RowIndex >= 0)
            {
                string Surname = ClientsGrid.CurrentRow.Cells[5].Value.ToString();
                Info inf = new Info(Surname);
                inf.Show();
            }

            if (e.ColumnIndex == ClientsGrid.Columns["Date"].Index && e.RowIndex >= 0)
            {
                string Surname = ClientsGrid.CurrentRow.Cells[5].Value.ToString();
                Info inf = new Info(Surname);
                inf.Show();
            }

            if (e.ColumnIndex == ClientsGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int Id = Convert.ToInt32(ClientsGrid.CurrentRow.Cells[3].Value.ToString());
                Database.Delete(Id);
                PopulateGrid.Populategrid($@"Select * From ClientImport Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            }

          
        }

        private void Fiotxtbox_TextChanged(object sender, EventArgs e)
        {
            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void emailtxtbox_TextChanged(object sender, EventArgs e)
        {
            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void phonetxtbox_TextChanged(object sender, EventArgs e)
        {
            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void right_Click(object sender, EventArgs e)
        { 
            page++;
            pages.Text = page.ToString();
            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void pagecount_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagesize = pagecount.Text;
            page = 1;
            pages.Text = page.ToString();

            //if (pagesize == "Все")
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
            //}
            //else
            //{
            //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
            //        PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%')
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //    else PopulateGrid.Populategrid($@"Select * From ClientImport
            //                             Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
            //                            ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
            //                            ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
            //                            Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
            //}
            PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
        }

        private void left_Click_1(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                pages.Text = page.ToString();
                //if (pagesize == "Все")
                //{
                //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
                //        PopulateGrid.Populategrid($@"Select * From ClientImport
                //                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                //                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                //                        ([Пол] Like N'%{phonetxtbox.Text}%')", ClientsGrid);
                //    else PopulateGrid.Populategrid($@"Select * From ClientImport
                //                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                //                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                //                        ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'", ClientsGrid);
                //}
                //else
                //{
                //    if (comboBox1.Text == "" || comboBox1.Text == "Все")
                //        PopulateGrid.Populategrid($@"Select * From ClientImport
                //                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                //                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                //                        ([Пол] Like N'%{phonetxtbox.Text}%')
                //                        Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
                //    else PopulateGrid.Populategrid($@"Select * From ClientImport
                //                         Where ([Телефон] Like N'%{emailtxtbox.Text}%') and 
                //                        ([Фамилия] Like N'%{Fiotxtbox.Text}%' or [Отчество] Like N'%{Fiotxtbox.Text}%' or [Датарождения] Like N'%{Fiotxtbox.Text}%') and 
                //                        ([Пол] Like N'%{phonetxtbox.Text}%') and [Фотографияклиента]=N'{comboBox1.Text}'
                //                        Order by {Sort} OFFSET {(page - 1) * Convert.ToInt32(pagesize)} ROWS FETCH NEXT {pagesize} ROWS ONLY", ClientsGrid);
                //}
                PopulateGrid.KostylePopulateGrid(pagesize, comboBox1, ClientsGrid, emailtxtbox, Fiotxtbox, phonetxtbox, page, Sort);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }
    }
}
