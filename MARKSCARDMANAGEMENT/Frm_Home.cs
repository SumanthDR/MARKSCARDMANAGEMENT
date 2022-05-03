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
using System.Configuration;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }
        public static int var = 0, var1 = 0;
        //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        private void insertMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)	//check if any other child form is open, if open then close //
                ActiveMdiChild.Close();
            Frm_MarksCard objmkrcrd = new Frm_MarksCard();
            objmkrcrd.MdiParent = this;
            objmkrcrd.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Course objcrs = new Frm_Course();
            objcrs.MdiParent = this;
            objcrs.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Subject objsub = new Frm_Subject();
            objsub.MdiParent = this;
            objsub.Show();
        }

        private void subjectMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CrsMgmt objcrsmgmt = new Frm_CrsMgmt();
            objcrsmgmt.MdiParent = this;
            objcrsmgmt.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CrsMgmt objcrsmgmt = new Frm_CrsMgmt();
            objcrsmgmt.MdiParent = this;
            objcrsmgmt.Show();
        }
    
        private void completeResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_StuResult objrslt = new Frm_StuResult();
            objrslt.MdiParent = this;
            objrslt.Show();
        }
        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Stu_Application obj_stuapp = new Frm_Stu_Application();
            obj_stuapp.MdiParent = this;
            obj_stuapp.Show();
        }

        private void viewSubjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CourseView obj_crsview = new Frm_CourseView();
            obj_crsview.MdiParent = this;
            obj_crsview.Show();
        }
        private void viewSubjectToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_SubView obj_subview = new Frm_SubView();
            obj_subview.MdiParent = this;
            obj_subview.Show();
        }
        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_StuView objstuview = new Frm_StuView();
            objstuview.MdiParent = this;
            objstuview.Show();
        }


        public static void txtvalidate_Code(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_crscode = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Code Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the Code.";
                var = 1;
            }
            else if ((len_crscode < 3) || (len_crscode > 20))
            {
                err.SetError(txtbx, "Invalid Code");
                lbl.Text = "ERROR!. -Please, Enter a valid code.";
                var = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                var = 0;
            }
        }

      
        public static void txtvalidate_Name(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_crsname = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Name Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the name.";
                var1 = 1;
            }
            else if ((len_crsname < 3) || (len_crsname > 40))
            {
                err.SetError(txtbx, "Name Invalid");
                lbl.Text = "ERROR!. -Please, Enter a valid name.";
                var1 = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                var1 = 0;
            }
        }

 

        //==========================BIND COURSE INTO COMBO_BOX =================================== //

        public static void Load_SubjectCombo(ComboBox cmb)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("PrcComboSub", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "value";
                cmb.ValueMember = "keys";

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
