using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIS_School.Classes;

namespace AIS_School.Forms
{
    public partial class RatingPupil : Form
    {
        MainMenuWindow _mainMenu;
        public RatingPupil(MainMenuWindow mainMenuWindow)
        {
            InitializeComponent();
            setupDate();
            _mainMenu = mainMenuWindow;
            _mainMenu.Hide();
            loadData("call sp_Get_pupils_balls");
        }

        private void setupDate()
        {
            if (DateTime.Now.Month > 8)
            {
                startDate.Value = new DateTime(DateTime.Now.Year, 9, 1);
                endData.Value = new DateTime(DateTime.Now.Year + 1, 8, 31);
            }
            else 
            {
                startDate.Value = new DateTime(DateTime.Now.Year-1, 9, 1);
                endData.Value = new DateTime(DateTime.Now.Year, 8, 31);
            }
        }

        private void loadData(string command)
        {
            gridPupilsRating.Rows.Clear();
            DataTable table = Classes.DBUtils.GetDataSetFromDataBase(command, _mainMenu.MyConnection);
            int counter = 0;
            foreach(DataRow dr in table.Rows)
            {
                gridPupilsRating.Rows.Add(
                                       ++counter,
                                       dr.ItemArray[0], //ID
                                       dr.ItemArray[1], //name pupil
                                       dr.ItemArray[2], //class
                                       dr.ItemArray[3] //balls
                                       ) ;
            }
        }

        private void RatingPupil_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData($@"call sp_Get_pupils_balls_Date('{stupidDate(startDate)}', '{stupidDate(endData)}')");
        }

        private string stupidDate (DateTimePicker timePicker)
        {
            return $@"{timePicker.Value.Year}-{timePicker.Value.Month}-{timePicker.Value.Day}";
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void выводНаПечатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void вДокументWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
            string pathDocument = AppDomain.CurrentDomain.BaseDirectory + "PrintReport.docx";
            WordDocument wordDoc = null;
            try
            {
                wordDoc = new WordDocument(pathDocument);

                wordDoc.SetSelectionToBookmark("startDate");
                wordDoc.Selection.Text = startDate.Text;
                wordDoc.SetSelectionToBookmark("endDate");
                wordDoc.Selection.Text = endData.Text;

            }
            catch (Exception error)
            {
                if (wordDoc != null) { wordDoc.Close(); }
                MessageBox.Show("Ошибка при вставке текста на закладку в документе  Word. Подробности " + error.Message);
                return;
            }
            insertTable(wordDoc);
            wordDoc.Visible = true;
        }
        // ВСТАВКА ТАБЛИЦЫ
        private void insertTable(WordDocument wordDoc)
        {
            wordDoc.SetSelectionToBookmark("table");


            wordDoc.InsertTable(gridPupilsRating.RowCount+1, 4);
            Console.WriteLine("Strings in table : " + gridPupilsRating.RowCount);
            wordDoc.SetColumnWidth(1, 80);
            wordDoc.SetColumnWidth(2, 200);
            wordDoc.SetColumnWidth(3, 80);
            wordDoc.SetColumnWidth(4, 80);
            wordDoc.SetSelectionToCell(1, 1);
            wordDoc.Selection.Text = "№ п/п";

            wordDoc.SetSelectionToCell(1, 2);
            wordDoc.Selection.Text = "ФИО";

            wordDoc.SetSelectionToCell(1, 3);
            wordDoc.Selection.Text = "Класс";

            wordDoc.SetSelectionToCell(1, 4);
            wordDoc.Selection.Text = "Баллов";
            int counter = 1;
            foreach(DataGridViewRow row in gridPupilsRating.Rows)
            {
                wordDoc.SetSelectionToCell(++counter, 1);
                wordDoc.Selection.Text = row.Cells[0].Value.ToString();

                wordDoc.SetSelectionToCell(counter, 2);
                wordDoc.Selection.Text = row.Cells[2].Value.ToString();

                wordDoc.SetSelectionToCell(counter, 3);
                wordDoc.Selection.Text = row.Cells[3].Value.ToString();

                wordDoc.SetSelectionToCell(counter, 4);
                wordDoc.Selection.Text = row.Cells[4].Value.ToString();
                Console.WriteLine($@"{counter} : {row.Cells[0].Value}/{row.Cells[2].Value}/{row.Cells[3].Value}/{row.Cells[4].Value}");
            }
        }
    }
}
