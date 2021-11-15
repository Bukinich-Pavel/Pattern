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

            UpdateAllTable();

            buttonDeleteFirstTable.Click += (s, e) => { presenter.DeleteBird(FirstTable.SelectedItem); UpdateAllTable(); };
            buttonDeleteSecondTable.Click += (s, e) => { presenter.DeleteMammal(SecondTable.SelectedItem); UpdateAllTable(); };
            buttonDeleteThirdTable.Click += (s, e) => { presenter.DeleteAmphibian(ThirdTable.SelectedItem); UpdateAllTable(); };

            buttonAddFirstTable.Click += AddModel;
            buttonAddSecondTable.Click += AddModel;
            buttonAddThirdTable.Click += AddModel;

            buttonSaveToFile.Click += (s, e) => presenter.SaveToFile();

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
        /// <summary>
        /// Обновить все данные
        /// </summary>
        private void UpdateAllTable()
        {
            AmphibianTable = presenter.GetAmphibians();
            MammalTable = presenter.GetMammals();
            BirdTable = presenter.GetBirds();
        }

        /// <summary>
        /// Обновить выбранную можель в первой таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateFirstTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(FirstTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateBird(FirstTable.SelectedItem, newName);
            UpdateAllTable();
        }

        /// <summary>
        /// Обновить выбранную модель во второй таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateSecondTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(SecondTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateMammal(SecondTable.SelectedItem, newName);
            UpdateAllTable();
        }

        /// <summary>
        /// Обновить выбранную модель в третьей таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateThirdTable_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update(ThirdTable.SelectedItem);
            update.ShowDialog();
            string newName = update.textUpdate.Text;
            presenter.UpdateAmphibion(ThirdTable.SelectedItem, newName);
            UpdateAllTable();
        }

        /// <summary>
        /// Добавить модель (исп. фабрика)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddModel(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            string typeAnimal = add.modelName.Text;
            string nameKind = add.nameKind.Text;
            presenter.AddAnimal(typeAnimal, nameKind);
            UpdateAllTable();
        }

        #endregion

    }
}
