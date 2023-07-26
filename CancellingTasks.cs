namespace CancellingTasks
{
    internal class CancellingTasks
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancel = new CancellationTokenSource();
            CancellationToken token = cancel.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is cancelled");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }                  
                }
                Console.WriteLine("Task is Complete");
            });
            
            task.Start();

            // Thread.Sleep(1000);
            // cancel.Cancel();
            cancel.CancelAfter(1000); // ase jobs

            Console.ReadLine();
        }
    }
}