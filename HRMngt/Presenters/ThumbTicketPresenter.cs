using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMngt.Model;
using HRMngt.Views;

namespace HRMngt.Presenter
{
    public class ThumbTicketPresenter
    {
        //Fields
        private IThumbTicketView view;
        private IThumbTicketRepository repository;
        private IEnumerable<ThumbTicketModel> thumbTicketList;

        public ThumbTicketPresenter(IThumbTicketView view, IThumbTicketRepository repository)
        {

            this.thumbTicketList = new List<ThumbTicketModel>();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            //this.view.SearchEvent += SearchThumbTicket;
            this.view.AddNewEvent += AddNewThumbTicket;
            //this.view.EditEvent += LoadSelectedThumbTicketToEdit;
            //this.view.DeleteEvent += DeleteSelectedThumbTicket;
            //this.view.SaveEvent += SaveThumbTicket;
            //this.view.CancelEvent += CancelAction;
            //Load pet list view
            LoadAllThumbTicketList();
            //Set pets bindind source
            this.view.ShowThumbTicketList(thumbTicketList);
            
            //Show view
            this.view.Show();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveThumbTicket(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedThumbTicket(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedThumbTicketToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewThumbTicket(object sender, EventArgs e)
        {
            view.ShowThumbTicketDialogToAddNew();
        }

        private void SearchThumbTicket(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadAllThumbTicketList()
        {
            thumbTicketList = repository.GetAll();
        }
    }
}
