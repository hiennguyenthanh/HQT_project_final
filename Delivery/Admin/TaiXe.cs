﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Delivery.Admin
{
    public partial class TaiXe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-2DSFN631\HUYNHTHANHMY;Initial Catalog=QLHD;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from TAIXE";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_taixe.DataSource = table;
        }
        public TaiXe()
        {
            InitializeComponent();
        }

        private void TaiXe_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            connection.Close();
        }
    }
}
