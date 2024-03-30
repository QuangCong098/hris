using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public class ThumbTicketModel
    {
        // Fields
        private string id;
        private string type;
        private string date;
        private string sender;
        private string receiver;
        private string reason;
        private int money;
        private string complain;
        private string response;
        private string status;

        // Constructor
        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Date { get => date; set => date = value; }
        public string Sender { get => sender; set => sender = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public string Reason { get => reason; set => reason = value; }
        public int Money { get => money; set => money = value; }
        public string Complain { get => complain; set => complain = value; }
        public string Response { get => response; set => response = value; }
        public string Status { get => status; set => status = value; }
    }
}
