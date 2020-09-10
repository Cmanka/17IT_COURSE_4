using System;


namespace labaTxt
{
    [Serializable]
    class Student
    {
        public string FullName { get; set; }
        public string Date { get; set; }
        public string Group { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Student() { }
        public Student(string fullName, string date, string group, string phone, string address)
        {
            this.FullName = fullName;
            this.Date = date;
            this.Group = group;
            this.Phone = phone;
            this.Address = address;
        }
    }

}
