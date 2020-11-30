using Newtonsoft.Json;
using Notepad.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Json
{
    class InOutput // для обработки данных используется Json, методы для считывания и сохранения данных
    {
        private readonly string PATH; // переменная, куда закладывается путь файла

        public InOutput(string path) // Путь для сохранения файла
        {
            PATH = path;
        }

        public BindingList<DoModel> LoadData() // Считывание данных 
        {
            var fileExists = File.Exists(PATH); // проверка на существование файла через путь к файлу
            if (!fileExists) // цикл для проверки
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<DoModel>();
            }
        }

        public void SaveData(BindingList<DoModel> _dataList) // Сохранение данных на жесткий диск
        {
            using (StreamWriter writer = File.CreateText(PATH)) //using позволяет автоматически использовать метод dispose для освобождения памяти
            { // Передается путь к файлу
                string output = JsonConvert.SerializeObject(_dataList); // Сериализация в поток, а затем в строку
                writer.Write(output); // Строка записывается в файл
            }
        }
    }
}
