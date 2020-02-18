using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfApp.ViewModels;

namespace WpfApp
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
