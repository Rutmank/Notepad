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

        public string Text // Текст задачи
        {
        get { return _text; }
        set { _text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged; // Имплементация INotifyPropertyChanged, создание события

        protected virtual void PropChanged(string propertyName = "") //вызов PropertyChanged и передача туда двух объектов
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); // 
        }

    }
}
