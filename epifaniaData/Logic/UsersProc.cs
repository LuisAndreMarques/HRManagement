using epifaniaData.DataAccess;
using epifaniaData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace epifaniaData.Logic
{
    public static class UsersProc
    {
        public static int CreateUser(string username, string password, string firstName, string lastName, string email, string telephone,
            string address1, string address2, string nif)
        {
            UserModel data = new UserModel
            {
                Address1 = address1,
                Address2 = address2,
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                NIF = nif,
                Password = password,
                Telephone = telephone,
                Username = username
            };

            string sql = @"INSERT INTO dbo.Users (Address1,Address2,Email,FirstName,LastName,NIF,Password,Telephone,Username)
                            VALUES (@Address1,@Address2,@Email,@FirstName,@LastName,@NIF,@Password,@Telephone,@Username)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"SELECT Id,Address1,Address2,Email,FirstName,LastName,NIF,Password,Telephone,Username)
                            FROM dbo.Users";
            
            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
