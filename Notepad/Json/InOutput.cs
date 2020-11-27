using Notepad.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Json
{
    class InOutput // для обработки данных используется Json, методы для считывания и сохранения данных
    {
        private readonly string PATH;

        public InOutput(string path) 
        { 

        }

        public BindingList<DoModel> LoadData() // Считывание данных 
        {
            return null;
        }

        public void SaveData(BindingList<DoModel> _dataList) // Сохранение данных на жесткий диск
        {
            
        }
    }
}
