using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labaTxt
{
    class Deserialize
    {
        public static List<Student> DeserializeBin(string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    return (List<Student>)binaryFormatter.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении bin");
                return null;
            }
        }
        public static List<Student> DeserializeTxt(string path)
        {
            try
            {
                List<Student> students = new List<Student>();
                using(StreamReader sr = new StreamReader(path))
                {
                    while(sr.Peek() >= 0)
                    {
                        string[] fields = sr.ReadLine().Split(' ');
                        students.Add(new Student(fields[0], fields[1], fields[2], fields[3], fields[4]));
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении txt");
                return null;
            }
        }
    }
}
