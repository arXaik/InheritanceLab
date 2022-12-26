
namespace InheritanceLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WorkerOnUncle[] workersList =
            {
                new("Иванов",20000,"1972-12-26","токарь"),
                new("Петров",250000,"2000-01-22","программист"),
                new("Сидорова",50000,"1985-03-8","бухгалтер"),
            };

            for (int worker_index = 0; worker_index < workersList.Length; worker_index++)
            {
                WorkerOnUncle worker = workersList[worker_index];
                Console.Write($"{worker.Lastname} зарплата до: {worker.Salary} ");
                worker.ProgrammerBoost();
                Console.WriteLine($"зарплата после: {worker.Salary}");
            }
        }
    }
}