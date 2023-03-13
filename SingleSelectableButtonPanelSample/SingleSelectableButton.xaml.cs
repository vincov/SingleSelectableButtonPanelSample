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
    /// Interaction logic for SingleSelectableButton.xaml
    /// </summary>
    public partial class SingleSelectableButton : UserControl
    {
        public SingleSelectableButton(Profile profile, EventHandler selectedChangedHandler)
        {
  
            InitializeComponent();
            var vm = new SingleSelectableButtonViewModel(profile);
            vm.OnSelectedChanged += selectedChangedHandler;
            DataContext = vm;
        }     
    }
}
