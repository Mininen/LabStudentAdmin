using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ObserverPattern;

namespace WindowsFormsApp1.GUI
{
    public partial class SubjectButton : Button, ISubject
    {
        public SubjectButton()
        {
            InitializeComponent();
        }

        public SubjectButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyAll()
        {
            foreach (IObserver observer in Observers)
            {
                observer.ObserverUpdate();
            }
        }
    }
}
