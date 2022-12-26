namespace InheritanceLab
{
    internal class Worker
    {
        private string lastname;
        private int salary;
        private DateTime birthday;

        public string Lastname { get => lastname; set => lastname = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public Worker(string lastname, int salary, string birthday)
        {
            this.lastname = lastname;
            this.salary = salary;
            this.birthday = DateTime.Parse(birthday);
        }

        public int GetAge()
        {
            var now = DateTime.Now;
            return now.Year - birthday.Year - (now.Month > birthday.Month || now.Month == birthday.Month && now.Day >= birthday.Day ? 0 : 1);
        }

        public int GetDaysTo50Year()
        {
            var now = DateTime.Now;
            return (int)birthday.AddYears(50).Subtract(now).TotalDays;
        }
    }
}
