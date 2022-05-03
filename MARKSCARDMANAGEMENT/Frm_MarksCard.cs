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
    public partial class Frm_MarksCard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        int courseid, sub_id;
        public Frm_MarksCard()
        {
            InitializeComponent();
           // setFormSize();
        }
        //============================CLEARS ALL TEXTBOXES=============== //
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        //````````````````` Auto-fit form size to the system resolution```````````````````//
        private void setFormSize()
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }
        //=================================== CONVERTS NUMBER TO WORDS ===================================================//
        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKHS ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]   
                    {  
                        "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"  
                    };
                var tensMap = new[]   
                    {  
                        "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"  
                    };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }

       
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        // Sum the cells and display the output in other cell //
        private void btnsum_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["Total_Max"].Index].Value = ((Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Max"].Index].Value)) + (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Max"].Index].Value)));
                row.Cells[dataGridView1.Columns["Total_Sec"].Index].Value = ((Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Sec"].Index].Value)) + (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Sec"].Index].Value)));
                if ((Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Sec"].Index].Value)) >= (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Min"].Index].Value)) && (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Sec"].Index].Value)) >= (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Min"].Index].Value)))
                {
                    row.Cells[dataGridView1.Columns["Result"].Index].Value = "PASS"; 
                }
                else
                {
                    row.Cells[dataGridView1.Columns["Result"].Index].Value = "FAIL";
                }
            }

            //Sum each row //
            int flag = 0;
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
                sum1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[9].Value);
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[10].Value == "PASS")
                    txtbx_result.Text = "PASS";
            }
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells[10].Value == "FAIL")
                    txtbx_result.Text = "FAIL";
            }
            txtbx_max_mks.Text = sum.ToString();
            txtbx_gtotal.Text = sum1.ToString();

            // Display Final Result //
            if(flag==1)
            {
                txtbx_result.Text = "PASS";
            }
            else if(flag==2)
            {
                txtbx_result.Text = "FAIL";
            }

            //Calculate SGPA//
            txtbx_sgpa.Text = ((Convert.ToDouble(txtbx_gtotal.Text)) / (Convert.ToDouble(txtbx_max_mks.Text))*10).ToString();

            //Calculate Percentage//
            txtbx_per.Text = ((Convert.ToDouble(txtbx_gtotal.Text)) / (Convert.ToDouble(txtbx_max_mks.Text)) * 100).ToString();
            txtbx_gtotal_words.Text = ConvertNumbertoWords(Convert.ToInt64(txtbx_gtotal.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_Marks_Save_Grid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cmd.Parameters.Add(new SqlParameter("@Slno", dataGridView1.Rows[i].Cells["SlNo"].Value));
                    cmd.Parameters.Add(new SqlParameter("@regno", dataGridView1.Rows[i].Cells["LBook"].Value));
                    cmd.Parameters.Add(new SqlParameter("@stu_name", dataGridView1.Rows[i].Cells["KClient"].Value));
                    cmd.Parameters.Add(new SqlParameter("@crs_id", dataGridView1.Rows[i].Cells["PEmployee"].Value));
                    cmd.Parameters.Add(new SqlParameter("@crs_name", dataGridView1.Rows[i].Cells["Date"].Value));
                    cmd.Parameters.Add(new SqlParameter("@semester", dataGridView1.Rows[i].Cells["Type"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sub_id", dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@sub_name", dataGridView1.Rows[i].Cells["Remarks"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@th_max", dataGridView1.Rows[i].Cells["FID"].Value));
                    cmd.Parameters.Add(new SqlParameter("@th_min", dataGridView1.Rows[i].Cells["LBook"].Value));
                    cmd.Parameters.Add(new SqlParameter("@th_sec", dataGridView1.Rows[i].Cells["KClient"].Value));
                    cmd.Parameters.Add(new SqlParameter("@IA_max", dataGridView1.Rows[i].Cells["PEmployee"].Value));
                    cmd.Parameters.Add(new SqlParameter("@IA_min", dataGridView1.Rows[i].Cells["Date"].Value));
                    cmd.Parameters.Add(new SqlParameter("@IA_sec", dataGridView1.Rows[i].Cells["Type"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@total_max", dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@total_sec", dataGridView1.Rows[i].Cells["Remarks"].Value.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@result", dataGridView1.Rows[i].Cells["FID"].Value));
                    cmd.Parameters.Add(new SqlParameter("@remarks", dataGridView1.Rows[i].Cells["LBook"].Value));
                    cmd.ExecuteNonQuery();
                }
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

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();   
        }

        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((txtbx_coursename.Text!="")&&(txtbx_name.Text!="")&&(txtbx_Regno.Text!=""))
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("Prc_ViewSemMarks", con);                                
                    cmd.Parameters.AddWithValue("@course_id",courseid);
                    cmd.Parameters.AddWithValue("@semester",cmb_sem.Text);
                    cmd.Parameters.AddWithValue("@regno", txtbx_Regno.Text);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // For Datagrid View in Subsidiary subjects //

                    SqlCommand cmd1 = new SqlCommand("Prc_ViewSemMarks", con);
                    cmd1.Parameters.AddWithValue("@course_id", courseid);
                    cmd1.Parameters.AddWithValue("@semester", cmb_sem.Text);
                    cmd1.Parameters.AddWithValue("@regno", txtbx_Regno.Text);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adt.Fill(dt);

                        ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////

                        // Clear binding
                        dataGridView1.DataSource = null;

                        dataGridView2.DataSource = null;

                        //Set AutoGenerateColumns False
                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView2.AutoGenerateColumns = false;

                        //Set Columns Count
                        dataGridView1.ColumnCount = 14;

                        dataGridView2.ColumnCount = 14;


                        //Add Columns

                        dataGridView1.Columns[1].Name = "Sub_Name";
                        dataGridView1.Columns[1].HeaderText = "Subjects / Papers";
                        dataGridView1.Columns[1].DataPropertyName = "Sub_Name";
                        dataGridView1.Columns[1].ReadOnly = true;
                        dataGridView1.Columns[1].Width = 200;

                        dataGridView1.Columns[2].Name = "Sub_th_Max";
                        dataGridView1.Columns[2].DataPropertyName = "Sub_th_Max";
                        dataGridView1.Columns[2].ReadOnly = true;

                        dataGridView1.Columns[3].Name = "Sub_th_Min";
                        dataGridView1.Columns[3].HeaderText = "Theory/Practical (Min.)";
                        dataGridView1.Columns[3].DataPropertyName = "Sub_th_Min";
                        dataGridView1.Columns[3].ReadOnly = true;

                        dataGridView1.Columns[4].Name = "Sub_th_Sec";
                        dataGridView1.Columns[4].HeaderText = "Theory/Practical (Sec.)";
                        //dataGridView1.Columns[4].DataPropertyName = "";

                        dataGridView1.Columns[5].Name = "Sub_IA_Max";
                        dataGridView1.Columns[5].HeaderText = "I.A/Record/Viva (Max.)";
                        dataGridView1.Columns[5].DataPropertyName = "Sub_IA_Max";
                        dataGridView1.Columns[5].ReadOnly = true;

                        dataGridView1.Columns[6].Name = "Sub_IA_Min";
                        dataGridView1.Columns[6].HeaderText = "I.A/Record/Viva (Min.)";
                        dataGridView1.Columns[6].DataPropertyName = "Sub_IA_Min";
                        dataGridView1.Columns[6].ReadOnly = true;

                        dataGridView1.Columns[7].Name = "Sub_IA_Sec";
                        dataGridView1.Columns[7].HeaderText = "I.A/Record/Viva (Sec.)";
                        //dataGridView1.Columns[7].DataPropertyName = "";

                        dataGridView1.Columns[8].Name = "Total_Max";
                        dataGridView1.Columns[8].HeaderText = "Total (Max.)";
                        dataGridView1.Columns[8].ReadOnly = true;

                        dataGridView1.Columns[9].Name = "Total_Sec";
                        dataGridView1.Columns[9].HeaderText = "Total (Sec.)";

                        dataGridView1.Columns[10].Name = "Result";
                        dataGridView1.Columns[10].HeaderText = "Result";
                        dataGridView1.Columns[10].ReadOnly = true;
                        dataGridView1.Columns[10].Width = 50;

                        dataGridView1.Columns[11].Name = "Year";
                        dataGridView1.Columns[11].HeaderText = "Year";

                        dataGridView1.Columns[12].DataPropertyName = "Cours_Id";
                        dataGridView1.Columns[12].Visible = false;

                        dataGridView1.Columns[13].DataPropertyName = "Sub_Id";
                        dataGridView1.Columns[13].Visible = false;

                        dataGridView1.DataSource = dt;

                       
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            row.Cells[dataGridView1.Columns["Total_Max"].Index].Value = ((Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Max"].Index].Value)) + (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Max"].Index].Value)));
                        }
                    }

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
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtbx_Regno_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_FetchCrsLang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@regno", txtbx_Regno.Text);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtbx_name.Text = (dr["StuName"].ToString());
                        txtbx_coursename.Text = (dr["Course_Name"].ToString());
                        courseid = Int16.Parse(dr["CourseId"].ToString());
                        sub_id = Int16.Parse(dr["ILangId"].ToString());
                    }
                    else
                    {
                        txtbx_name.Text = "";
                        txtbx_coursename.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Please try again!.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
