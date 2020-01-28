using Caliburn.Micro;

namespace erlewpf.ViewModels
{ 


    public class ShellViewModel : PropertyChangedBase
{

        string name;
		private int myVar;

		public string Name
		{
			get { return name; }
			set { name = value;
				NotifyOfPropertyChange(() => Name);
				
			}
		}

	}
}