using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public interface IThumbTicketRepository
    {
        void Add(ThumbTicketModel thumbTicketModel);
        void Edit(ThumbTicketModel thumbTicketModel);
        void Delete(int id);
        IEnumerable<ThumbTicketModel> GetAll();
        IEnumerable<ThumbTicketModel> GetByValue(); // Search
    }
}
