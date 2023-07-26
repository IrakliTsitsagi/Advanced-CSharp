using System.Timers;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
namespace CheckingTasksStatus
{
    internal class CheckingTasksStatus
    {
        static Timer timer;
        static Task task;
        static void Main(string[] args)
        {
            task = new Task(() =>
           {
               for (int i = 0; i <= 500; i++)
               {
                   Console.WriteLine(i);
               }
           });
            task.Start();

            timer = new Timer();
            timer.Elapsed += CheckTheTask; // esec += mere tabi
            timer.Interval = 100;
            timer.Enabled = true;

            Console.ReadLine();
        }

        private static void CheckTheTask(object sender, ElapsedEventArgs e)
        {
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task is running");
            }
            else if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete");
                timer.Enabled = false;
            }
        }
    }
}