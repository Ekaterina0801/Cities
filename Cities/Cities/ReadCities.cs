using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Cities
{
    public class ReadCities
    {
        /// <summary>
        /// Считывает из файла названия городов
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns>Массив строк, где каждая строка - название города</returns>
        public static string[] ReadCitiesFunc(string path)
        {
            return File.ReadAllLines(path);
        }

        public static string[] citiesList = ReadCities.ReadCitiesFunc("cities_list.txt"); // список городов

    }
}