using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views
{
    public interface ILoginView
    {
        string UserName { get;}
        string Password { get;}
        event EventHandler LoginEvent;
        void Show();
    }
}
