using System;

namespace DependencyInjection
{
    public class MyDependencyBad
    {
        public void WriteMessage(string Message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called. Message: {Message}");
        }
    }
}
