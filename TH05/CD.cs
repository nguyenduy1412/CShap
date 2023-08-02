using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TH05
{
    public partial class CD : Form
    {
        string strCon = @"Data Source=DESKTOP-2BKKJ18\SQLEXPRESS;Initial Catalog=DieuTraDS;Integrated Security=True";
        SqlConnection sqlCon = null;
        public CD()
        {
            InitializeComponent();
        }

        private void CD_Load(object sender, EventArgs e)
        {

        }
    }
}
