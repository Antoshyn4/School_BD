using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = SautinSoft.Document.Color;
using HorizontalAlignment = SautinSoft.Document.HorizontalAlignment;

namespace KT_2
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Olympiads". При необходимости она может быть перемещена или удалена.
            this.olympiadsTableAdapter.Fill(this.for_kursDataSet.Olympiads);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Classes". При необходимости она может быть перемещена или удалена.
            this.classesTableAdapter.Fill(this.for_kursDataSet.Classes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "for_kursDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.for_kursDataSet.Students);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateDocument(0);
        }

        private void CreateDocument1(int row)
        {
            string docPath = @"";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                docPath = folderBrowserDialog1.SelectedPath + "\\Olympiads.docx";
            }
            if (docPath != "")
            {
                DocumentCore dc = new DocumentCore();
                DocumentBuilder db = new DocumentBuilder(dc);


                Section section = db.Document.Sections[0];
                (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Right;
                section.PageSetup.PaperType = PaperType.A4;
                db.CharacterFormat.Size = 10;
                db.Writeln("Report was created " + DateTime.Today);
                db.CharacterFormat.FontName = "Century Gothic";
                db.CharacterFormat.Bold = true;
                db.CharacterFormat.Size = 18;
                (section.Blocks[1] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Center;
                db.Write("List of olympiads");
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

                db.CharacterFormat.ClearFormatting();
                (section.Blocks[1] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Left;
                db.CharacterFormat.FontName = "Century Gothic";
                db.CharacterFormat.Size = 10;
                db.CharacterFormat.FontColor = Color.Black;
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                //SectionService sectionService = new SectionService();
                //List<Coach> coaches = sectionService.GetCoaches(secs[row].Id);

                int p = 0;
                dataGridView5.RowCount = 1;
                dataGridView5.ColumnCount = 1;
                //int i = 11;
                //if (comboBox1.SelectedIndex != -1)
                //{
                //    i = int.Parse(comboBox1.SelectedItem.ToString());
                //}
                string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand comand = new SqlCommand(@"SELECT [Class number], [Full Name],  [Level of Olympiad], [Name of subject] FROM Olympiads JOIN Classes ON Olympiads.[Group code] = Classes.[Group code] JOIN Students ON Olympiads.[Student code] = Students.[Student code] WHERE        Olympiads.[Had participation] = 'Yes' ", con);
                SqlDataReader reader = comand.ExecuteReader();
                dataGridView5.RowCount = 10;
                dataGridView5.ColumnCount = 3;
                int z = 0;
                while (reader.Read())
                {
                    z++;
                    dataGridView5.Rows.Add();
                    for (int j = 0; j < 3; j++)
                    {
                        dataGridView5.Rows[z].Cells[j].Value = reader[j].ToString();
                    }
                    p++;
                    db.Writeln(reader[0].ToString() + "     Class   " + reader[1].ToString() + "    Level of olympiads :     " + reader[2].ToString() + "    Subject name:  " + reader[3].ToString());
                }
                db.Writeln("Total Olympiads: " + p);
                dc.Save(docPath, new DocxSaveOptions()
                { EmbeddedJpegQuality = 90 });

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(docPath) { UseShellExecute = true });
            }
        }
        private void CreateDocument(int row)
        {
            string docPath = @"";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                docPath = folderBrowserDialog1.SelectedPath + "\\Debtors.docx";
            }
            if (docPath != "")
            {
                DocumentCore dc = new DocumentCore();
                DocumentBuilder db = new DocumentBuilder(dc);

                int p = 0, h = 0;
                Section section = db.Document.Sections[0];
                (section.Blocks[0] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Right;
                section.PageSetup.PaperType = PaperType.A4;
                db.CharacterFormat.Size = 10;
                db.Writeln("Report was created " + DateTime.Today);
                db.CharacterFormat.FontName = "Century Gothic";
                db.CharacterFormat.Bold = true;
                db.CharacterFormat.Size = 18;
                (section.Blocks[1] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Center;
                db.Write("Debt report");
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);

                db.CharacterFormat.ClearFormatting();
                (section.Blocks[1] as Paragraph).ParagraphFormat.Alignment = HorizontalAlignment.Left;
                db.CharacterFormat.FontName = "Century Gothic";
                db.CharacterFormat.Size = 12;
                db.CharacterFormat.FontColor = Color.Black;
                db.InsertSpecialCharacter(SpecialCharacterType.LineBreak);
                //SectionService sectionService = new SectionService();
                //List<Coach> coaches = sectionService.GetCoaches(secs[row].Id);
                

                string connection = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = For_kurs; Integrated Security = True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand comand = new SqlCommand(@"SELECT [Class number], [Full Name], [Amount], [For what] FROM Duty join Students ON Duty.[Student code] = Students.[Student code] 
join Classes ON Duty.[Group code] = Classes.[Group code] ORDER BY [Class number]", con);
                SqlDataReader reader = comand.ExecuteReader();
                dataGridView5.RowCount = 2;
                dataGridView5.ColumnCount = 4;
                int ii = -1;
                while (reader.Read())
                {
                    ii++;
                    dataGridView5.Rows.Add();
                    for (int j = 0; j < 4; j++)
                    {
                        dataGridView5.Rows[ii].Cells[j].Value = reader[j].ToString();
                        
                    }
                    p++;
                    db.Writeln(reader[0].ToString() + "     Class   " + reader[1].ToString() + "    amount of debt :     " + reader[2].ToString() + "    for   " + reader[3].ToString());
                    h += int.Parse(reader[2].ToString());
                }
                reader.Close();
                db.Writeln("Total amount od debters "+ p);
                db.Writeln("Total amount of debt " + h);

                dc.Save(docPath, new DocxSaveOptions()
                { EmbeddedJpegQuality = 90 });

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(docPath) { UseShellExecute = true });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateDocument1(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Begin newForm = new Begin();
            newForm.Show();
            this.Visible = false;   
        }
    }
}
