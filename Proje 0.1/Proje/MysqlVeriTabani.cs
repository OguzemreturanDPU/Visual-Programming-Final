﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proje
{
    public partial class MysqlVeriTabani : Form
    {
        public MysqlVeriTabani()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=kisiler;Uid=root;Pwd=secret;Port=3307");
        private void MysqlVeriTabani_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from kisiler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
