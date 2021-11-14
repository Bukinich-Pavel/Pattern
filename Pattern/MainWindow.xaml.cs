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

namespace Pattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter presenter;

        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            presenter = new Presenter(this, db);
            FirstTable.ItemsSource = presenter.GetBirds();
        }
    }
}
