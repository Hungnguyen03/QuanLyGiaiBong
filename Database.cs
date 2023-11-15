﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace QuanLyGiaiBong
{
    internal class Database
    {
        string connectionString = @"Data Source=LAPTOP-7DP7U4ND\SQLEXPRESS;Initial Catalog=QLGiaiBongDa;Integrated Security=True";
        //string connectionString = $"Server={config.SERVER};Database={config.DATABASE};Integrated Security={config.Integrated_Security};";
        SqlConnection con;
        private SqlCommand command;
        private SqlDataReader reader;

        public Database()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
            command = new SqlCommand();
            command.Connection = con;
            con.Open();

        }

        public string ConnectionString { get => connectionString; }



        public void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }



        //Dung de lay cau truy van 
        public void SetQuery(string sql)
        {
            this.command.CommandText = sql;
        }

        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            SqlDataAdapter sqldataAdapte = new SqlDataAdapter(sql, con);
            sqldataAdapte.Fill(dtBang);
            return dtBang;
        }

        private List<string> getValueOfQuery()
        {
            List<string> result = new List<string>();
            MatchCollection matches = Regex.Matches(command.CommandText, @"\@\w+");

            foreach (Match match in matches)
            {
                string parameterName = match.Value;
                result.Add(parameterName);
            }
            return result;
        }

        //Dung de danh cho nhung cau lenh update,insert
        public SqlDataReader Excute(params object[] parameters)
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            if (parameters != null)
            {
                List<string> res = getValueOfQuery();
                for (int i = 0; i < parameters.Length; i++)
                {
                    command.Parameters.AddWithValue(res[i], parameters[i]);
                }
            }
            reader = command.ExecuteReader();
            command.Parameters.Clear();
            return reader;
        }

        //Lay nhieu dong du lieu

        public List<Dictionary<string, object>> LoadAllRows(params object[] parameters)
        {
            List<Dictionary<string, object>> res = new List<Dictionary<string, object>> { };
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            using (reader = Excute(parameters))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) == DBNull.Value)
                            {
                                row[reader.GetName(i)] = null;
                            }
                            else
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }

                        }
                        res.Add(row);
                    }
                }
            }
            command.Parameters.Clear();
            return res;
        }
        public int getNumberOfRecorder(params object[] parameters)
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            int count = 0;
            using (reader = Excute(parameters))
            {
                while (reader.Read())
                {
                    count++;
                }
            }
            command.Parameters.Clear();
            return count;
        }

        public Dictionary<string, object> LoadRow(params object[] parameters)
        {
            if (reader != null && !reader.IsClosed)
            {
                reader.Close();
            }
            Dictionary<string, object> res = new Dictionary<string, object>();
            using (SqlDataReader reader = Excute(parameters))
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetValue(i) == DBNull.Value)
                            {
                                res[reader.GetName(i)] = null;
                            }
                            else
                            {
                                res[reader.GetName(i)] = reader.GetValue(i);
                            }

                        }
                    }
                }

            }
            command.Parameters.Clear();
            return res;
        }
    }
}
