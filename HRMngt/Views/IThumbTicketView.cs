using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views
{
    public interface IThumbTicketView
    {
        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;

        // Methods
        void ShowThumbTicketDialogToAddNew();
        void ShowThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList);
        void Show();
    }
}
