﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            set => instance = value;
        }


        private DataProvider() { }

        private string connectionStr = "Data Source=(local);Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public DataTable ExecuteQuery(string query, object[] paramater=null)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch { MessageBox.Show("Lỗi truy vấn " + query); }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch { MessageBox.Show("Lỗi truy vấn " + query); }
            return data;
        }
        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = new object();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch { MessageBox.Show("Lỗi truy vấn " + query); }
            return data;
        }
    }
}
