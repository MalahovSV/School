using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_School.Forms
{
    public partial class RatingPupil : Form
    {
        MainMenuWindow _mainMenu;
        public RatingPupil(MainMenuWindow mainMenuWindow)
        {
            InitializeComponent();
            _mainMenu = mainMenuWindow;
            _mainMenu.Hide();
            loadData();
        }

        private void loadData()
        {
            gridPupilsRating.Rows.Clear();
            DataSet ds = Classes.DBUtils.GetDataSetFromDataBase("call sp_Get_pupils_balls");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                gridPupilsRating.Rows.Add(dr.ItemArray[0], //ID
                                       dr.ItemArray[1], //name pupil
                                       dr.ItemArray[2], //class
                                       dr.ItemArray[3] //balls
                                       );
            }
        }

        private void RatingPupil_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
