using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleSelectableButtonPanelSample
{
    public class SingleSelectableButtonViewModel : DataContextBase
    {
        private Profile Profile;
        private bool _IsSelected;
        public string Name
        {
            get
            {
                return Profile.Name;
            }
            set { }
        }

        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
            set
            {
                _IsSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }
        public RelayCommand ToggleSelectedCommand { get; set; }
        public EventHandler OnSelectedChanged { get; set; }

        public SingleSelectableButtonViewModel(Profile profile)
        {
            Profile = profile;
            ToggleSelectedCommand = new RelayCommand(ToggleSelectedAndNotifyListeners);
            OnPropertyChanged("Name");
        }
        private void ToggleSelectedAndNotifyListeners(object sender)
        {
            IsSelected = !IsSelected;
            if (OnSelectedChanged != null)
                OnSelectedChanged(this, EventArgs.Empty);
        }
    }
}
