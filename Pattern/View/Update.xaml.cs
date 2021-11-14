using Pattern.Model;
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
using System.Windows.Shapes;

namespace Pattern.View
{
    public partial class Update : Window
    {
        public Update(object obj)
        {
            InitializeComponent();

            IAnimal animal = obj as IAnimal;
            if(animal != null) textUpdate.Text = animal.KindAnimal;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
