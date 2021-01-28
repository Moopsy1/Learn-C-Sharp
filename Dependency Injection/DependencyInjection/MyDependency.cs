using System;

namespace DependencyInjection
{   //note how interfaces are a different color
    public class MyDependency : IMyDependency
    {
        public void WriteMessage(string Message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called. Message: {Message}");
        }
    }
}
