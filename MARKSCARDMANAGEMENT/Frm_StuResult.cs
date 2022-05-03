using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_StuResult : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public Frm_StuResult()
        {
            InitializeComponent();
        }

        private void cmb_Sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_Cmb_StuRes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cmb_Course.DataSource = dt;
                cmb_Course.DisplayMember = "value";
                cmb_Course.ValueMember = "keys";
                cmb_Sem.DisplayMember = "";
                cmb_Sem.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again !! \n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
