using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webFacebook.Dock = DockStyle.Top;
            axAcroPDF1.Hide();
            ExportToExcelButton.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signInButton.Enabled = false;
            string OAuthUrl = @"https://www.facebook.com/v2.10/dialog/oauth?client_id=1501718503208965
                                &redirect_uri=https://www.facebook.com/connect/login_success.html
                                &response_type=token
                                &scope=user_posts";
            webFacebook.Navigate(OAuthUrl);
        }

        public string access_token;
        public List<Post> posts;
        private void webFacebook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webFacebook.Url.AbsoluteUri.Contains("access_token"))
            {
                string url1 = webFacebook.Url.AbsoluteUri;
                string url2 = url1.Substring(url1.IndexOf("access_token") + 13);
                access_token = url2.Substring(0, url2.IndexOf("&"));
                MessageBox.Show("Login Sucessful");

                webFacebook.Hide();
                signInButton.Hide();
                
                axAcroPDF1.Dock = DockStyle.Top;
                axAcroPDF1.Show();
                getStatusButton.Show();
                showStatusToolStripMenuItem1.Enabled = true;
            }
        }

        private void getStatusButton_Click(object sender, EventArgs e)
        {
            FacebookClient fb = new FacebookClient(access_token);
            posts = new List<Post>();

            dynamic postMessages = fb.Get("/me/posts?limit=40");

            do
            {
                int count = (int)postMessages.data.Count;
                for (int i = 0; i < count; i++)
                {
                    if (postMessages.data[i].message != null)
                    {
                        Post currentPost = new Post(postMessages.data[i].id, postMessages.data[i].message, postMessages.data[i].created_time);
                        posts.Add(currentPost);
                    }       
                }
                try
                {
                    postMessages = fb.Get(postMessages.paging.next);
                }
                catch (Exception)
                {

                    break;
                }

            } while (true);
            string path = @"C:/Users/ECJ4REAL.ECJ4REAL-PC/Desktop/mypdffile.pdf";
            createTable(posts, path);


            axAcroPDF1.LoadFile(path);
            axAcroPDF1.src = @path;
            axAcroPDF1.setView("FitH");
            axAcroPDF1.setLayoutMode("SinglePage");
            axAcroPDF1.setShowToolbar(false);
            axAcroPDF1.Show();

            getStatusButton.Hide();
            exportStatusToolStripMenuItem.Enabled = true;
            ExportToExcelButton.Show();
        }

        public static void createTable(List<Post> postMessages, string path)
        {
            Document doc = new Document();

            PdfPTable table = new PdfPTable(3);

            foreach (Post postMessage in postMessages)
            {
                table.AddCell(postMessage.getPostID());
                table.AddCell(postMessage.getMessage());
                table.AddCell(postMessage.getDateCreated());
            }

            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));

            doc.Open();
            doc.Add(table);
            doc.Close();

        }

        public static System.Data.DataTable ExportToExcel(List<Post> postFeeds)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("PostID", typeof(string));
            table.Columns.Add("Message", typeof(string));
            table.Columns.Add("Date_Created", typeof(string));

            foreach(Post pos in postFeeds)
            {
                table.Rows.Add(pos.getPostID(), pos.getMessage(), pos.getDateCreated());
            }
            return table;
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Workbook worKbooK;
            Worksheet worKsheeT;
            Range celLrangE;

            saveFileDialog1.Filter = "Excel Files|*.xls";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1 != null)
            {
                string path = saveFileDialog1.FileName;
                path.Replace('\\', '/');

                try
                {
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    worKbooK = excel.Workbooks.Add(Type.Missing);


                    worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                    worKsheeT.Name = "StudentRepoertCard";

                    worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 3]].Merge();
                    worKsheeT.Cells[1, 1] = "Post Messages";
                    worKsheeT.Cells.Font.Size = 15;

                    int rowcount = 2;

                    foreach (DataRow datarow in ExportToExcel(posts).Rows)
                    {
                        rowcount += 1;
                        for (int i = 1; i <= ExportToExcel(posts).Columns.Count; i++)
                        {
                            if (rowcount == 3)
                            {
                                worKsheeT.Cells[2, i] = ExportToExcel(posts).Columns[i - 1].ColumnName;
                                worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;
                            }
                            worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
                            if (rowcount > 3)
                            {
                                if (i == ExportToExcel(posts).Columns.Count)
                                {
                                    if (rowcount % 2 == 0)
                                    {
                                        celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, ExportToExcel(posts).Columns.Count]];
                                    }
                                }
                            }
                        }
                    }
                    celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, ExportToExcel(posts).Columns.Count]];
                    celLrangE.EntireColumn.AutoFit();
                    Borders border = celLrangE.Borders;
                    border.LineStyle = XlLineStyle.xlContinuous;
                    border.Weight = 2d;

                    celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, ExportToExcel(posts).Columns.Count]];

                    worKbooK.SaveAs(path);
                    worKbooK.Close();
                    excel.Quit();

                    Process.Start(path);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    worKsheeT = null;
                    celLrangE = null;
                    worKbooK = null;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when formi is closed
            System.Windows.Forms.Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //exit application when formi is closed
            System.Windows.Forms.Application.Exit();
        }

        private void signInFaceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signInButton_Click(sender, e);
            signInFaceBookToolStripMenuItem.Enabled = false;
        }

        private void showStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getStatusButton_Click(sender, e);
            showStatusToolStripMenuItem1.Enabled = false;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelButton_Click(sender, e);
        }

        private void aboutFaceBookStausReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FbsrAboutBox abtBox = new FbsrAboutBox();
            abtBox.ShowDialog();
        }

        private void documentationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }
    }

    public class Post{
        private string postID;
        private string message;
        private string dateCreated;

        public Post(string postID, string message, string dateCreated)
        {
            this.postID = postID;
            this.message = message;
            this.dateCreated = dateCreated;
        }

        public string getPostID()
        {
            return postID;
        }
        public string getMessage()
        {
            return message;
        }
        public string getDateCreated()
        {
            return dateCreated;
        }

    }

}
