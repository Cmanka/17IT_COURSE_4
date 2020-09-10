using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student
    {
        public string FIO;
        public string date;
        public string group;
        public string phone;
        public string address;

        public Student()
        {
        }

        public Student(string fIO, string date, string group, string phone, string address)
        {
            FIO = fIO;
            this.date = date;
            this.group = group;
            this.phone = phone;
            this.address = address;
        }
    }

    class SerialazbleWork
    {
        public static bool SerialazeToXML(List<Student> Student, string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

                xmlSerializer.Serialize(new StreamWriter(path), Student);
            }
            catch (Exception ex)
            {
                //MessegeBox

                return false;
            }

            return true;
        }

        public static bool SerialazeToBin(List<Student> Student, string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, Student);
                }
            }
            catch (Exception ex)
            {
                //MessegeBox

                return false;
            }

            return true;
        }

        public static List<Student> DeserializeToBin(string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    var res = (List<Student>)binaryFormatter.Deserialize(fileStream);

                    return res;
                }
            }
            catch (Exception ex)
            {
                //MessegeBox

                return null;
            }
        }

        public static List<Student> DeserializeToXML(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

                var res = (List<Student>)xmlSerializer.Deserialize(new StreamReader(path));

                return res;
            }
            catch (Exception ex)
            {
                //MessegeBox

                return null;
            }
        }

    }
}
