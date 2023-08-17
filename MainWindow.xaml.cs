using System;
using System.Collections.Generic;
using System.Data;
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

namespace WPF_NotesTaking_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Click(object sender, RoutedEventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void load_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void newNote_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void previousNotes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void noteBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
