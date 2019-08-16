using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DisconnectedMode_Startup
{
    public partial class SearchFilms : Form
    {
        public SearchFilms()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Search using 'Tom Hanks' or 'Will Smith'
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr;
            
        }
    }
}
