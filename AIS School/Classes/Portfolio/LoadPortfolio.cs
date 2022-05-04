using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_School.Classes.Portfolio
{
    internal class LoadPortfolio : IPorifolio
    {
        string select;

        public DataSet LoadData(string PkUser)
        {
            Console.WriteLine("Load portfolio...");
            select = $@"select surname, first_name, second_name, name_event, date_event, terrain_factor_name, name_win_coeff, name_event_coefficient,  (win_coeff_balls + event_coefficient_balls + terrain_factor_balls) as balls
from pupil, participation, events, event_coefficients, terrain_coefficients,  prize_winning_coefficient, users, class
where fk_pupil = PK_pupil and FK_event = PK_event and FK_event_coefficient = pk_event_coeff
and fk_place_factor = PK_Terr_Coeff and FK_win_coeff = pk_win_coeff and pk_users = fk_user and
fk_class = pk_class and 
pk_class = (select pk_class from users, class, teacher
where fk_user = pk_users and fk_teacher=pk_teacher and pk_users = {PkUser});";
            DataSet ds =  DBUtils.GetDataSetFromDataBase(select);
            return ds;
        }
    }
}


