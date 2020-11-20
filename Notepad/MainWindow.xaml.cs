using Notepad.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Notepad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<DoModel> _dataList; //Контейнер для хранения модели задачи
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _dataList = new BindingList<DoModel>() 
            {
                new DoModel(){Text = "test"},
                new DoModel(){Text = "asdasd"}
            };
            dgNote.ItemsSource = _dataList;
            _dataList.ListChanged += _dataList_ListChanged; // Подписывание на событие, фиксирующее изменения в листе
        }

        private void _dataList_ListChanged(object sender, ListChangedEventArgs e) 
        {
            throw new NotImplementedException();
        }
    }
}
