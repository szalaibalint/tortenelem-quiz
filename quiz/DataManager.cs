using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace quiz
{
    static class DataManager
    {
        static List<Question> questions = new List<Question>();
        public static List<Question> Questions => questions;


        public static void LoadData()
        {
            Questions.Clear();

            string[] paths = Directory.GetFiles("data", "*.json");
            foreach (string path in paths)
            {
                Questions.Add(Question.LoadFromJSON(path));
            }
        }
    }
}
