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
using System.Collections;
using System.Drawing.Printing;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_SubView : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public static string id = string.Empty;
        public static string code = string.Empty;
        public static string name = string.Empty;
        public static string course_Id = string.Empty;
        public static string category = string.Empty;
        public static string descript = string.Empty;
        public static string thmax = string.Empty;
        public static string thmin = string.Empty;
        public static string iamax = string.Empty;
        public static string iamin = string.Empty;
        public static int flag = 0;
        public Frm_SubView()
        {
            InitializeComponent();
        }
       
        private void Load_GridView(string prc,int flag)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(prc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(flag==1)
                {
                    cmd.Parameters.AddWithValue("@Parameter", cmb_coursename.SelectedValue);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Parameter", txtbx_SubCode.Text);
                }
                cmd.Parameters.AddWithValue("@flag", flag);
                con.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////

                    // Clear binding
                    dataGridView1.DataSource = null;

                    //Set AutoGenerateColumns False
                    dataGridView1.AutoGenerateColumns = false;

                    //Set Columns Count
                    dataGridView1.ColumnCount = 13;


                    //Add Columns

                    dataGridView1.Columns[1].HeaderText = "Subject Code";
                    dataGridView1.Columns[1].Name = "Sub_Code";
                    dataGridView1.Columns[1].DataPropertyName = "Sub_Code";

                    dataGridView1.Columns[2].Name = "Subject Name";
                    dataGridView1.Columns[2].HeaderText = "Subject Name";
                    dataGridView1.Columns[2].DataPropertyName = "Sub_Name";

                    dataGridView1.Columns[3].Name = "Sub_Category";
                    dataGridView1.Columns[3].HeaderText = "Category";
                    dataGridView1.Columns[3].DataPropertyName = "Sub_Category";

                    dataGridView1.Columns[4].Name = "Course_Code";
                    dataGridView1.Columns[4].HeaderText = "Course Code";
                    dataGridView1.Columns[4].DataPropertyName = "Course_Code";

                    dataGridView1.Columns[5].Name = "Course_Name";
                    dataGridView1.Columns[5].HeaderText = "Course Name";
                    dataGridView1.Columns[5].DataPropertyName = "Course_Name";

                    // THESE ARE NOT DISPLAYED . FOR PROGRAMMING PURPOSE ONLY //

                    dataGridView1.Columns[6].DataPropertyName = "Sub_Id";
                    dataGridView1.Columns[6].Visible = false;

                    dataGridView1.Columns[7].DataPropertyName = "Crs_Id";
                    dataGridView1.Columns[7].Visible = false;

                    dataGridView1.Columns[8].DataPropertyName = "Sub_Descript";
                    dataGridView1.Columns[8].Visible = false;

                    dataGridView1.Columns[9].DataPropertyName = "Sub_th_Max";
                    dataGridView1.Columns[9].Visible = false;

                    dataGridView1.Columns[10].DataPropertyName = "Sub_th_Min";
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[11].DataPropertyName = "Sub_IA_Max";
                    dataGridView1.Columns[11].Visible = false;

                    dataGridView1.Columns[12].DataPropertyName = "Sub_IA_Min";
                    dataGridView1.Columns[12].Visible = false;

                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    dataGridView1.Columns.Add(btn);
                    btn.HeaderText = "Action";
                    btn.Text = "Edit";
                    btn.Name = "btnGrid_Edit";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.DataSource = dt;
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
        private void Frm_SubView_Load(object sender, EventArgs e)
        {
           Frm_Home.Load_SubjectCombo(cmb_coursename);
        }

        private void btn_search_crs_Click(object sender, EventArgs e)
        {
            Load_GridView("Prc_SubView",1);
        }
        // EVENTS ----------- This block creates sl.no (eg-1,2,3,4,5...) //////////

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Frm_Subject objSub = new Frm_Subject();

                //populate the textbox from specific value of the coordinates of column and row.
                Frm_SubView.id= row.Cells[6].Value.ToString();
                Frm_SubView.code= row.Cells[1].Value.ToString();
                Frm_SubView.name = row.Cells[2].Value.ToString();
                Frm_SubView.descript= row.Cells[8].Value.ToString();
                Frm_SubView.course_Id= row.Cells[7].Value.ToString();
                Frm_SubView.category= row.Cells[3].Value.ToString();
                Frm_SubView.thmax= row.Cells[9].Value.ToString();
                Frm_SubView.thmin = row.Cells[10].Value.ToString();
                Frm_SubView.iamax = row.Cells[11].Value.ToString();
                Frm_SubView.iamin = row.Cells[12].Value.ToString();

                Frm_SubView.flag = 1;
                objSub.Show();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Load_GridView("Prc_SubView", 2);
        }

     

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument.Print();
                ClsPrint _ClsPrint = new ClsPrint(dataGridView1, "header doc text");
                _ClsPrint.PrintForm();
            }

        }

    }
    class ClsPrint
    {
        #region Variables

        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        private PrintDocument _printDocument = new PrintDocument();
        private DataGridView gw = new DataGridView();
        private string _ReportHeader;

        #endregion

        public ClsPrint(DataGridView gridview, string ReportHeader)
        {
            _printDocument.PrintPage += new PrintPageEventHandler(_printDocument_PrintPage);
            _printDocument.BeginPrint += new PrintEventHandler(_printDocument_BeginPrint);
            gw = gridview;
            _ReportHeader = ReportHeader;
        }

        public void PrintForm()
        {
            ////Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = _printDocument;
            //printDialog.UseEXDialog = true;

            ////Get the document
            //if (DialogResult.OK == printDialog.ShowDialog())
            //{
            //    _printDocument.DocumentName = "Test Page Print";
            //    _printDocument.Print();
            //}

            //Open the print preview dialog
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
                objPPdialog.Document = _printDocument;
                objPPdialog.ShowDialog();
            }
                
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int iCellHeight = 0; //Used to get/set the datagridview cell height
            int iTotalWidth = 0; //
            int iRow = 0;//Used as counter
            bool bFirstPage = false; //Used to check whether we are printing first page
            bool bNewPage = false;// Used to check whether we are printing a new page
            int iHeaderHeight = 0; //Used for the header height
            StringFormat strFormat; //Used to format the grid rows.
            ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
            ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
            PrintDocument _printDocument = new PrintDocument();
            DataGridView gw = new DataGridView();
            string _ReportHeader;
            //try
            //{
            //Set the left margin
            int iLeftMargin = e.MarginBounds.Left;
            //Set the top margin
            int iTopMargin = e.MarginBounds.Top;
            //Whether more pages have to print or not
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;

            //For the first page to print set the cell width and header height
            if (bFirstPage)
            {
                foreach (DataGridViewColumn GridCol in gw.Columns)
                {
                    iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                        (double)iTotalWidth * (double)iTotalWidth *
                        ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                    iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                    // Save width and height of headers
                    arrColumnLefts.Add(iLeftMargin);
                    arrColumnWidths.Add(iTmpWidth);
                    iLeftMargin += iTmpWidth;
                }
            }
            //Loop till all the grid rows not get printed
            while (iRow <= gw.Rows.Count - 1)
            {
                DataGridViewRow GridRow = gw.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 0;
                //Check whether the current page settings allows more rows to print
                if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    bNewPage = true;
                    bFirstPage = false;
                    bMorePagesToPrint = true;
                    break;
                }
                else
                {

                    if (bNewPage)
                    {
                        //Draw Header
                        e.Graphics.DrawString(_ReportHeader,
                            new Font(gw.Font, FontStyle.Bold),
                            Brushes.Black, e.MarginBounds.Left,
                            e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader,
                            new Font(gw.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Height - 13);

                        String strDate = "";
                        //Draw Date
                        e.Graphics.DrawString(strDate,
                            new Font(gw.Font, FontStyle.Bold), Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                            new Font(gw.Font, FontStyle.Bold),
                            e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString(_ReportHeader,
                            new Font(new Font(gw.Font, FontStyle.Bold),
                            FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        DataGridViewColumn[] _GridCol = new DataGridViewColumn[gw.Columns.Count];
                        int colcount = 0;
                        //Convert ltr to rtl
                        foreach (DataGridViewColumn GridCol in gw.Columns)
                        {
                            _GridCol[colcount++] = GridCol;
                        }
                        for (int i = (_GridCol.Count() - 1); i >= 0; i--)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawString(_GridCol[i].HeaderText,
                                _GridCol[i].InheritedStyle.Font,
                                new SolidBrush(_GridCol[i].InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                            iCount++;
                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 0;
                    DataGridViewCell[] _GridCell = new DataGridViewCell[GridRow.Cells.Count];
                    int cellcount = 0;
                    //Convert ltr to rtl
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        _GridCell[cellcount++] = Cel;
                    }
                    //Draw Columns Contents                
                    for (int i = (_GridCell.Count() - 1); i >= 0; i--)
                    {
                        if (_GridCell[i].Value != null)
                        {
                            e.Graphics.DrawString(_GridCell[i].FormattedValue.ToString(),
                                _GridCell[i].InheritedStyle.Font,
                                new SolidBrush(_GridCell[i].InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount],
                                (float)iTopMargin,
                                (int)arrColumnWidths[iCount], (float)iCellHeight),
                                strFormat);
                        }
                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                            (int)arrColumnWidths[iCount], iCellHeight));
                        iCount++;
                    }
                }
                iRow++;
                iTopMargin += iCellHeight;
            }
            //If more lines exist, print another page.
            if (bMorePagesToPrint)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
            //       MessageBoxIcon.Error);
            //}
        }

        private void _printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in gw.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
