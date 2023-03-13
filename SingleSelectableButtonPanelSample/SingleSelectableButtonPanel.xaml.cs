using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SingleSelectableButtonPanelSample
{
    /// <summary>
    /// Interaction logic for SingleSelectableButtonPanel.xaml
    /// </summary>
    public partial class SingleSelectableButtonPanel : UserControl
    {
        private List<SingleSelectableButton> Buttons;
        public SingleSelectableButtonPanel(List<Profile> profiles)
        {
            InitializeComponent();
            Buttons = new List<SingleSelectableButton>();

            foreach(var profile in profiles)
            {
                var button = new SingleSelectableButton(profile, SomethingChangedHandler);
                Buttons.Add(button);
                InnerPanel.Children.Add(button);
            }
        }

        private void SomethingChangedHandler(object sender, EventArgs args)
        {
            var vm = (SingleSelectableButtonViewModel)sender;
            var clickedButtonName = vm.Name;

            foreach(var button in Buttons)
            {
                vm = (SingleSelectableButtonViewModel)button.DataContext;
                if(vm.Name != clickedButtonName)
                {
                    vm.IsSelected = false;
                }
            }
        }
    }
}
