using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarDocument
{
    internal class Info
    {

        public virtual bool EvaluateAttributes()
        { 
            return false;
        }

        protected void ShowErrorBox(string errorText)
        {
            MessageBox.Show($"{errorText}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
