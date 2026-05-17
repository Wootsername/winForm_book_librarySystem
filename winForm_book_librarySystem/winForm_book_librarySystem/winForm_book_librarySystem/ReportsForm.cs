using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using winForm_book_librarySystem.Models;

namespace winForm_book_librarySystem
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            ThemeSettings.ApplyTheme(this);
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            
            try
            {
                using (var context = new LibraryContext())
                {
                    DataTable dt = new DataTable("DataSet1");

                    string selectedReport = cmbReportType.SelectedItem.ToString();
                    if (selectedReport == "Books Availability")
                    {
                        var books = context.Books.Select(b => new { b.Title, b.Author, b.TotalCopies, b.AvailableCopies }).ToList();
                        dt.Columns.Add("Title", typeof(string));
                        dt.Columns.Add("Author", typeof(string));
                        dt.Columns.Add("TotalCopies", typeof(int));
                        dt.Columns.Add("AvailableCopies", typeof(int));
                        foreach (var b in books) dt.Rows.Add(b.Title, b.Author, b.TotalCopies, b.AvailableCopies);
                    }
                    else if (selectedReport == "All Reservations")
                    {
                        var res = context.Reservations.Include(r => r.User).Include(r => r.Book).ToList();
                        dt.Columns.Add("Student", typeof(string));
                        dt.Columns.Add("Book", typeof(string));
                        dt.Columns.Add("Status", typeof(string));
                        dt.Columns.Add("Date", typeof(DateTime));
                        foreach (var r in res) dt.Rows.Add(r.User.FullName, r.Book.Title, r.Status, r.ReservedDate);
                    }
                    else if (selectedReport == "Student Borrowing History")
                    {
                        var res = context.Reservations.Include(r => r.User).Include(r => r.Book)
                                         .Where(r => r.Status == "Returned" || r.Status == "Cancelled").ToList();
                        dt.Columns.Add("Student", typeof(string));
                        dt.Columns.Add("Book", typeof(string));
                        dt.Columns.Add("Status", typeof(string));
                        foreach (var r in res) dt.Rows.Add(r.User.FullName, r.Book.Title, r.Status);
                    }

                    string rdlcXml = GenerateDynamicRdlc(dt);
                    using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(rdlcXml)))
                    {
                        reportViewer1.LocalReport.LoadReportDefinition(stream);
                    }

                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = reportViewer1.LocalReport.Render(
                   "PDF", null, out mimeType, out encoding, out extension,
                   out streamids, out warnings);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files|*.pdf";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, bytes);
                        MessageBox.Show("Exported successfully to PDF!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private string GenerateDynamicRdlc(DataTable dt)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<Report xmlns=\"http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition\">");
            sb.AppendLine("  <DataSources><DataSource Name=\"DummyDataSource\"><ConnectionProperties><DataProvider>System.Data.DataSet</DataProvider><ConnectString>/* Local Connection */</ConnectString></ConnectionProperties></DataSource></DataSources>");
            sb.AppendLine("  <DataSets><DataSet Name=\"DataSet1\"><Query><DataSourceName>DummyDataSource</DataSourceName><CommandText>/* Local Query */</CommandText></Query><Fields>");
            foreach (DataColumn col in dt.Columns)
            {
                sb.AppendLine($"<Field Name=\"{col.ColumnName}\"><DataField>{col.ColumnName}</DataField></Field>");
            }
            sb.AppendLine("  </Fields></DataSet></DataSets>");
            sb.AppendLine("  <Body><ReportItems><Tablix Name=\"Tablix1\">");
            sb.AppendLine("  <TablixBody><TablixColumns>");
            foreach (DataColumn col in dt.Columns) sb.AppendLine("<TablixColumn><Width>1.5in</Width></TablixColumn>");
            sb.AppendLine("  </TablixColumns><TablixRows>");
            
            sb.AppendLine("<TablixRow><Height>0.25in</Height><TablixCells>");
            foreach (DataColumn col in dt.Columns)
            {
                sb.AppendLine($"<TablixCell><CellContents><Textbox Name=\"Header{col.ColumnName}\"><Paragraphs><Paragraph><TextRuns><TextRun><Value>{col.ColumnName}</Value><Style><FontWeight>Bold</FontWeight></Style></TextRun></TextRuns></Paragraph></Paragraphs><Style><TextAlign>Left</TextAlign><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style></Textbox></CellContents></TablixCell>");
            }
            sb.AppendLine("</TablixCells></TablixRow>");
            
            sb.AppendLine("<TablixRow><Height>0.25in</Height><TablixCells>");
            foreach (DataColumn col in dt.Columns)
            {
                sb.AppendLine($"<TablixCell><CellContents><Textbox Name=\"Data{col.ColumnName}\"><Paragraphs><Paragraph><TextRuns><TextRun><Value>=Fields!{col.ColumnName}.Value</Value></TextRun></TextRuns></Paragraph></Paragraphs><Style><TextAlign>Left</TextAlign><PaddingLeft>2pt</PaddingLeft><PaddingRight>2pt</PaddingRight><PaddingTop>2pt</PaddingTop><PaddingBottom>2pt</PaddingBottom></Style></Textbox></CellContents></TablixCell>");
            }
            sb.AppendLine("</TablixCells></TablixRow>");

            sb.AppendLine("  </TablixRows></TablixBody>");
            sb.AppendLine("  <TablixColumnHierarchy><TablixMembers>");
            foreach (DataColumn col in dt.Columns) sb.AppendLine("<TablixMember />");
            sb.AppendLine("  </TablixMembers></TablixColumnHierarchy>");
            sb.AppendLine("  <TablixRowHierarchy><TablixMembers><TablixMember><KeepWithGroup>After</KeepWithGroup></TablixMember><TablixMember><Group Name=\"Details\" /></TablixMember></TablixMembers></TablixRowHierarchy>");
            sb.AppendLine("  <Top>0.5in</Top><Left>0.5in</Left>");
            sb.AppendLine("  </Tablix></ReportItems><Height>2in</Height></Body>");
            sb.AppendLine("  <Width>8in</Width><Page><PageHeight>11in</PageHeight><PageWidth>8.5in</PageWidth></Page>");
            sb.AppendLine("</Report>");

            return sb.ToString();
        }
    }
}
