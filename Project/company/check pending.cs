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

namespace company
{
    public partial class check_pending : Form
    {
        private string userSSN;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dataset;

        public check_pending(string ssn)
        {
            this.userSSN = ssn;
            InitializeComponent();
        }

        private void check_pending_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            string cmdstr = "select * from appllication where ssn = :usersn";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("usersn", userSSN);

            dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
