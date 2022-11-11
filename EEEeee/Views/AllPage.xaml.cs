using EEEeee.ViewMdels;
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

namespace EEEeee.Views
{
    /// <summary>
    /// Логика взаимодействия для AllPage.xaml
    /// </summary>
    public partial class AllPage : Page
    {
        public AllPage(Services.CurrentPageControl currentPageControl)
        {
            InitializeComponent();
            DataContext = new AllPageVM(currentPageControl);
        }
    }
}
