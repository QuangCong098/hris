using HRMngt.Model;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using HRMngt.Model;
using HRMngt.View;

namespace HRMngt.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private IUserRepository repository;

        public LoginPresenter(ILoginView view, IUserRepository repository, EventHandler login)
        {
            this.view = view;
            this.repository = repository;
            this.view.LoginEvent += ;
            this.view.Show();
        }

        private void DangNhap(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
