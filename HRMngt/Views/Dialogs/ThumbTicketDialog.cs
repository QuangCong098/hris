using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HRMngt.View.Popup
{
    public partial class ThumbTicketDialog : Form, IThumbTicketDialog
    {
        private string popUpType;
        private string modelId;

        public ThumbTicketDialog(string popUpType, string modelId)
        {
            InitializeComponent();
            this.popUpType = popUpType;
            this.modelId = modelId;

            Button btnComplain = new Button();

            if (popUpType == "Create")
            {
                this.Text = "Create Thumb/Ticket";
                lblTitle.Text = "Create Thumb/Ticket";
                btnCreateUpdate.Text = "Create";

            }
            else if (popUpType == "Update")
            {
                this.Text = "Update Thumb/Ticket";
                lblTitle.Text = "Update Thumb/Ticket";
                btnCreateUpdate.Text = "Update";
            }    

            RunEvent();
        }

        public void RunEvent()
        {
            if (btnCreateUpdate.Text == "Create")
            {
                btnCreateUpdate.Click += delegate { SaveAddNewEvent?.Invoke(this, EventArgs.Empty); };
            }    
            else
            {
                btnCreateUpdate.Click += delegate { SaveUpdateEvent?.Invoke(this, EventArgs.Empty); };
            }
        }

        public string Id
        {
            get { return lblIdDetail.Text; }
            set { lblIdDetail.Text = value; }

        }
        public string Type
        {
            get { return cmbTypeDetail.SelectedValue.ToString(); }
            set { cmbTypeDetail.SelectedValue = value; }
        }

        public DateTime Date
        {
            get { return dtpDateDetail.Value; }
            set { dtpDateDetail.Value = value; }
        }

        public string Sender 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Receiver
        {
            get
            {
                string selectedValue = cmbReceiverDetail.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(selectedValue))
                {
                    string[] parts = selectedValue.Split('-');
                    if (parts.Length == 2)
                    {
                        return parts[0].Trim(); // Return only the ID
                    }
                }
                return null; // Or throw an exception if necessary
            }
            set
            {
                // Setting the value is not implemented
                throw new NotImplementedException();
            }
        }

        public string Reason 
        { 
            get { return txtReasonDetail.Text; }
            set {txtReasonDetail.Text = value; }
        }

        public int Money 
        {
            get { return int.Parse(txtMoneyDetail.Text); }
            set { lblComplainDetail.Text = value.ToString(); }
        }
        public string Complain 
        {
            get { return lblComplainDetail.Text; }
            set { lblComplainDetail.Text = value; }
        }
        public string Response 
        {
            get { return lblResponseDetail.Text; }
            set { lblResponseDetail.Text = value; }
        }
        public string Status 
        {
            get { return lblStatusDetail.Text; }
            set { lblStatusDetail.Text = value; }
        }

        public event EventHandler CancelEvent;
        public event EventHandler SaveAddNewEvent;
        public event EventHandler SaveUpdateEvent;

        private void btnComplain_Click(object sender, EventArgs e)
        {
            string complainText = Interaction.InputBox("Nhập nội dung khiếu nại", "Complain Content Box");
            lblComplainDetail.Text = complainText;
        }
    }
}
