using System;
using System.Collections;
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
    public partial class MainWindow : Window, IView
    {
        Presenter presenter;

        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            presenter = new Presenter(this, db);

            BirdTable = presenter.GetBirds();
            MammalTable = presenter.GetMammals();
            AmphibianTable = presenter.GetAmphibians();

            buttonDeleteThirdTable.Click += (s, e) => presenter.DeleteAmphibian(ThirdTable.SelectedItem);
        }

        public IEnumerable BirdTable 
        {
            get => FirstTable.ItemsSource;
            set => FirstTable.ItemsSource = value;
        }

        public IEnumerable MammalTable 
        {
            get => SecondTable.ItemsSource;
            set => SecondTable.ItemsSource = value;
        }

        public IEnumerable AmphibianTable 
        {
            get => ThirdTable.ItemsSource;
            set => ThirdTable.ItemsSource = value;
        }
    }
}
