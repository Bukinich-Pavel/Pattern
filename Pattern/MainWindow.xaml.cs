using Pattern.View;
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

            UpdateBird();
            UpdateMammals();
            UpdateAmphibian();

            buttonDeleteFirstTable.Click += (s, e) => { presenter.DeleteBird(FirstTable.SelectedItem); UpdateBird(); };
            buttonDeleteSecondTable.Click += (s, e) => { presenter.DeleteMammal(SecondTable.SelectedItem); UpdateMammals(); };
            buttonDeleteThirdTable.Click += (s, e) => { presenter.DeleteAmphibian(ThirdTable.SelectedItem); UpdateAmphibian(); };


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


        #region private method
        private void UpdateAmphibian()
        {
            AmphibianTable = presenter.GetAmphibians();
        }

        private void UpdateMammals()
        {
            MammalTable = presenter.GetMammals();
        }

        private void UpdateBird()
        {
            BirdTable = presenter.GetBirds();
        }
        #endregion

        private void buttonUpdateFirstTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(FirstTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateBird(FirstTable.SelectedItem, newName);
            UpdateBird();
        }

        private void buttonUpdateSecondTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(SecondTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateMammal(SecondTable.SelectedItem, newName);
            UpdateMammals();
        }

        private void buttonUpdateThirdTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(ThirdTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateAmphibion(ThirdTable.SelectedItem, newName);
            UpdateAmphibian();
        }
    }
}
