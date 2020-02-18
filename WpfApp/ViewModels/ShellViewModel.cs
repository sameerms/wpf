using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp.ViewModels
{
    public class ShellViewModel: Screen
    {
        private string _firstname = "sam";

        public string Firstname  { get { return _firstname; } set { _firstname = value; } }
    }
}
