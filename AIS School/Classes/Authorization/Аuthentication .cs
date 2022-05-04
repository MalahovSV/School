using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_School.Classes.Authorization
{
    static class Аuthentication 
    {
        /// <summary>
        /// Проверка введённых логина и пароля пользователя.
        /// </summary>
        /// <param name="Login">Логин пользователя</param>
        /// <param name="Password">Пароль пользователя</param>
        /// <returns></returns>
        public static User CheckDataUser(string Login, string Password)
        {
            User userActual;
            DataSet userDataSet = Classes.DBUtils.GetDataSetFromDataBase($@"select * from users where login_user = '{Login}' and password_user = '{Password}'");


            if (userDataSet.Tables[0].Rows.Count > 0)
            {
                userActual = new User(
                    uint.Parse(userDataSet.Tables[0].Rows[0].ItemArray[0].ToString()), //ID
                    userDataSet.Tables[0].Rows[0].ItemArray[1].ToString(), //Login
                    userDataSet.Tables[0].Rows[0].ItemArray[2].ToString(), //password
                    userDataSet.Tables[0].Rows[0].ItemArray[3].ToString(), //Surname
                    userDataSet.Tables[0].Rows[0].ItemArray[4].ToString(), //FirstName
                    userDataSet.Tables[0].Rows[0].ItemArray[5].ToString(), //SecondName
                    userDataSet.Tables[0].Rows[0].ItemArray[8].ToString(), // email
                    userDataSet.Tables[0].Rows[0].ItemArray[7].ToString(),// phone
                    CheckRoleUser(userDataSet.Tables[0].Rows[0].ItemArray[0].ToString()), //Role
                    DateTime.Parse(userDataSet.Tables[0].Rows[0].ItemArray[6].ToString())); //DateBirth
                return userActual;
            }
            return null;
        }

        /// <summary>
        /// Проверка ролей пользователя
        /// </summary>
        /// <param name="ID">Первичный ключ пользователя</param>
        /// <returns>Выделенная роль пользователю</returns>
        private static string CheckRoleUser(string ID)
        {            
            DataSet role = Classes.DBUtils.GetDataSetFromDataBase($@"select * from system_administrator where fk_user = {ID}");
            if (role.Tables[0].Rows.Count > 0)
            {
                return "sysadmin";
            }
            role = Classes.DBUtils.GetDataSetFromDataBase($@"select * from administration where fk_user = {ID}");   
            if (role.Tables[0].Rows.Count > 0)    
            {
                return "admin";
            }
            role = Classes.DBUtils.GetDataSetFromDataBase($@"select * from teacher where fk_user = {ID}");
            if (role.Tables[0].Rows.Count > 0)
            {
                return "teacher";
            }
            role = Classes.DBUtils.GetDataSetFromDataBase($@"select * from pupil where fk_user = {ID}");
            if (role.Tables[0].Rows.Count > 0)
            {
                return "pupil";
            }
            return "Error";
        }
    }
}
