using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace labaTxt
{
    class Serialize
    {
        public static bool SerializeToBin(List<Student> students, string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, students);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в bin");
                return false;
            }

            return true;
        }
        public static void SerializeToTxt(List<Student> students, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (var student in students)
                    {
                        sw.WriteLine(student.FullName);
                        sw.WriteLine(student.Date);
                        sw.WriteLine(student.Group);
                        sw.WriteLine(student.Phone);
                        sw.WriteLine(student.Address);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в txt");
            }
        }
    }
}
