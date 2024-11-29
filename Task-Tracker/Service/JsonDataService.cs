using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task_Tracker.Data;

namespace Task_Tracker.Service
{
    public class JsonDataService
    {

        private string _jsonData = File.ReadAllText("C:\\Users\\Came\\Desktop\\Priv. Projcets\\Task-Tracker-CLI\\Task-Tracker\\Data\\TaskStorage.json");

        public void ReadJsonData()
        {
            // Deserialize JSOn Data to Object
            Task taskList = JsonSerializer.Deserialize<Task>(_jsonData);

            Console.WriteLine(taskList.Id);
            Console.WriteLine(taskList.Name);
            Console.WriteLine(taskList.Desc);
        }

    }
}
