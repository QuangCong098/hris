using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMngt.Model;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace HRMngt._Repository
{
    public class ThumbTicketRepository : BaseRepository, IThumbTicketRepository
    {
        // Contructor
        public ThumbTicketRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ThumbTicketModel thumbTicketModel)
        { 
            string connectionString = "Data Source=DESKTOP-BM7NF3L;Initial Catalog=hris;Integrated Security=True;TrustServerCertificate=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into thumbticket values(@Id, @Type, @Date, @Sender, @Receiver, @Reason, @Money, @Complain, @Response, @Status";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = thumbTicketModel.Id;
                command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = thumbTicketModel.Type;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = thumbTicketModel.Date;
                command.Parameters.Add("@Sender", SqlDbType.Char).Value = thumbTicketModel.Sender;
                command.Parameters.Add("@Receiver", SqlDbType.Char).Value = thumbTicketModel.Receiver;
                command.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = thumbTicketModel.Reason;
                command.Parameters.Add("@Money", SqlDbType.Int).Value = thumbTicketModel.Money;
                command.Parameters.Add("@Complain", SqlDbType.NVarChar).Value = thumbTicketModel.Complain;
                command.Parameters.Add("@Response", SqlDbType.NVarChar).Value = thumbTicketModel.Response;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = thumbTicketModel.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(int id)
        {
            string connectionString = "Data Source=DESKTOP-BM7NF3L;Initial Catalog=hris;Integrated Security=True;TrustServerCertificate=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from thumbticket where id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(ThumbTicketModel thumbTicketModel)
        {
            string connectionString = "Data Source=DESKTOP-BM7NF3L;Initial Catalog=hris;Integrated Security=True;TrustServerCertificate=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update thumbticket set reason=@Reason, money=@Money, complain=@Complain, response=@Response, status=@Status";
                command.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = thumbTicketModel.Reason;
                command.Parameters.Add("@Money", SqlDbType.Int).Value = thumbTicketModel.Money;
                command.Parameters.Add("@Complain", SqlDbType.NVarChar).Value = thumbTicketModel.Complain;
                command.Parameters.Add("@Response", SqlDbType.NVarChar).Value = thumbTicketModel.Response;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = thumbTicketModel.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<ThumbTicketModel> GetAll()
        {
            var ThumbTicketList = new List<ThumbTicketModel>();
            string connectionString = "Data Source=INSPIRON_14;Initial Catalog=hris;Integrated Security=True;Encrypt=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from thumbticket ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var thumbTicketModel = new ThumbTicketModel();
                        thumbTicketModel.Id = reader[0].ToString();
                        thumbTicketModel.Type = reader[1].ToString();
                        thumbTicketModel.Date = reader[2].ToString();
                        thumbTicketModel.Sender = reader[3].ToString();
                        thumbTicketModel.Receiver = reader[4].ToString();
                        thumbTicketModel.Reason = reader[5].ToString();
                        thumbTicketModel.Money = (int)reader[6];
                        thumbTicketModel.Complain = reader[7].ToString();
                        thumbTicketModel.Response = reader[8].ToString();
                        thumbTicketModel.Status = reader[9].ToString();
                        ThumbTicketList.Add(thumbTicketModel);
                    }
                }
                connection.Close();
            }
            return ThumbTicketList;
        }

        public IEnumerable<ThumbTicketModel> GetByValue()
        {
            throw new NotImplementedException();
        }
    }
}
