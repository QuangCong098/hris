using HRMngt.Model;
using HRMngt.View.Popup;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.View
{
    public partial class ThumbTicketView : Form, IThumbTicketView
    {
        public ThumbTicketView()
        {
            InitializeComponent();
            RunEvent();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;

        private void RunEvent()
        {
            // Add Event
            btnCreateThumbTicket.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
            // Search Event
            txtChooseUserID.TextChanged += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void ShowThumbTicketDialogToAddNew()
        {
            ThumbTicketDialog thumbTicketDialog = new ThumbTicketDialog("Create", null);
            thumbTicketDialog.ShowDialog();
        }
        public void ShowThumbTicketList(IEnumerable<ThumbTicketModel> thumbTicketList)
        {
            dgvThumbTicketTable.Rows.Clear();

            foreach (var thumbTicketModel in thumbTicketList)
            {
                int rowIndex = dgvThumbTicketTable.Rows.Add();

                dgvThumbTicketTable.Rows[rowIndex].Cells[0].Value = "• " + thumbTicketModel.Type;
                dgvThumbTicketTable.Rows[rowIndex].Cells[0].Style.ForeColor = Color.FromArgb(69, 158, 26);
                dgvThumbTicketTable.Rows[rowIndex].Cells[1].Value = thumbTicketModel.Date;
                dgvThumbTicketTable.Rows[rowIndex].Cells[2].Value = thumbTicketModel.Receiver;
                dgvThumbTicketTable.Rows[rowIndex].Cells[3].Value = thumbTicketModel.Reason;
                dgvThumbTicketTable.Rows[rowIndex].Cells[4].Value = thumbTicketModel.Money.ToString("#,##0");
                dgvThumbTicketTable.Rows[rowIndex].Cells[5].Value = "• " + thumbTicketModel.Status;
            }

        }

        private static ThumbTicketView instance;
        public static ThumbTicketView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ThumbTicketView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                
            }      
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }    
            return instance;
        }
    }
}
