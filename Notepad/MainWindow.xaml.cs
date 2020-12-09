using Notepad.Json;
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
        private readonly string PATH = $"{Environment.CurrentDirectory}\\dataList.json"; // создание пути файла
        private BindingList<DoModel> _dataList; //Контейнер для хранения модели задачи
        private InOutput _inOutput;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _inOutput = new InOutput(PATH); // передача в конструктор пути 

            _dataList = _inOutput.LoadData(); //  получение данных

            dgNote.ItemsSource = _dataList;
            _dataList.ListChanged += _dataList_ListChanged; // Подписывание на событие, фиксирующее изменения в листе
        }

        private void _dataList_ListChanged(object sender, ListChangedEventArgs e) // Cобытие, фиксирующее изменения в листе и сохраняющее их на диске
        {
            switch (e.ListChangedType) // Список отслеживаемых событий с помощью ListChanged
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                default:
                    break;
            } // для улучшения оптимизации лучше создать использование данного списка через if с конкретными задачами
        }
    }
}
