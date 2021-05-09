using Client.Helpers;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UIControllers
{
    public class AddGrupaController
    {
        
        internal bool Save(TextBox txtName)
        {
            if (FormHelper.EmptyFieldValidation(txtName))
            {
                return false;
            }
            GrupaLekova grupa = new GrupaLekova { NazivGrupe = txtName.Text};
            if (!Communication.Communication.Instance.AddGrupa(grupa))
            {
                return false;
            }

            return true;
        }
    }
}
