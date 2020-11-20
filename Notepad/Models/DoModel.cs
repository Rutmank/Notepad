using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Models
{
    class DoModel: INotifyPropertyChanged
    {
        public DateTime DateOfCreation { get; set; } = DateTime.Now; // Присваивание даты и времени в переменную

        private bool _isDone; // Переменная для обозначения завершения задачи

        public bool IsDone // Состояние задачи
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string _text; // Переменная для обозначения в нем текста. 

        public event PropertyChangedEventHandler PropertyChanged; // Имплементация INotifyPropertyChanged

        public string Text // Текст задачи
        {
        get { return _text; }
        set { _text = value; }
        }

    }
}
