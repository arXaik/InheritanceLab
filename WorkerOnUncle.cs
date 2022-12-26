

namespace InheritanceLab
{
    internal class WorkerOnUncle : Worker
    {
        private string post;

        public WorkerOnUncle(string lastname, int salary, string birthday, string post) : base(lastname, salary, birthday)
        {
            this.post = post;
        }

        public string Post { get => post; set => post = value; }

        public void ProgrammerBoost()
        {
            if (post.Equals("программист"))
            {
                Salary = (int)(Salary * 1.2);
            }
        }
    }
}
