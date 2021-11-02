using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ObserverPattern;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class ObserverCheckBox : CheckBox, IObserver
    {
        public void ObserverUpdate()
        {
            ForeColor = Color.Green;
            Checked = true;
        }
    }
}
