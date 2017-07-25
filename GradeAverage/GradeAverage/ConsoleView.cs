using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    class ConsoleView : IView
    {
        public short getInt(string prompt)
        {
            Console.WriteLine(prompt);
            return Int16.Parse(Console.ReadLine());
        }

        public string getString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void show<T>(T message)
        {
         
            Console.WriteLine(message);
        }

        public void start()
        {
            Console.Clear();
        }

        public void stop()
        {
            Console.WriteLine("Press Any Key To Finish");
            Console.ReadKey();
        }
    }
}
