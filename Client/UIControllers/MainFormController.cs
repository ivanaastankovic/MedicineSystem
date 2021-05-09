using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.UIControllers
{
    public class MainFormController
    {
        internal void LogOut()
        {
            Communication.Communication.Instance.LogOut();
        }
    }
}
