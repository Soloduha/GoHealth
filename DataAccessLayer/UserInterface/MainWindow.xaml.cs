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
using System.Collections.ObjectModel;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>   

    public partial class MainWindow : Window
    {
        //public ObservableCollection<TestClass> myCollection;
        public MainWindow()
        {
            InitializeComponent();
            //myCollection = new ObservableCollection<TestClass>();
            //myCollection.Add(new TestClass() { Name = "Vlad", StartDate = DateTime.Now, EndDate = DateTime.Now});
            //myCollection.Add(new TestClass() { Name = "Oleh", StartDate = DateTime.Now, EndDate = DateTime.Now });
            //myCollection.Add(new TestClass() { Name = "Sasha", StartDate = DateTime.Now, EndDate = DateTime.Now });
            //myCollection.Add(new TestClass() { Name = "Liza", StartDate = DateTime.Now, EndDate = DateTime.Now });
            //MondayListView.ItemsSource = myCollection;
        }

        private void NextWeekButton_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
