using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRMngt.Model;

namespace HRMngt._Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        // Contructor
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            var UsernameList = new List<UserModel>();
            string connectionString = "Data Source=INSPIRON_14;Initial Catalog=hris;Integrated Security=True;Encrypt=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from users ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Username = reader[9].ToString();
                        userModel.Password = reader[10].ToString();
                        UsernameList.Add(UserModel);
                    }
                }
                connection.Close();
            }
            return UsernameList;
        }

        public IEnumerable<UserModel> GetByValue()
        {
            throw new NotImplementedException();
        }

        public string Validation(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
