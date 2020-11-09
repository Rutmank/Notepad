﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Models
{
    class DoModel
    {
        public DateTime DateOfCreation { get; set; } = DateTime.Now; // Присваивание даты и времени в переменную

        private bool _isDone; // Переменная для обозначения завершения задачи

        public bool IsDone // Состояние задачи
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        private string _text; // Переменная для обозначения в нем текста. 
        
        private string Text // Текст задачи
        {
        get { return _text; }
        set { _text = value; }
        }

    }
}
