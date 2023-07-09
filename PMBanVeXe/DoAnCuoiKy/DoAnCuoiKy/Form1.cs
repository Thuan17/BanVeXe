using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Collections;


namespace DoAnCuoiKy
{
    public partial class Form1 : Form
    {
        DB connection;
        DataColumn[] primaryKey;
        SqlDataAdapter adapter1, adapter2;
        public Form1()
        {
            InitializeComponent();
            connection = new DB();
            primaryKey = new DataColumn[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
