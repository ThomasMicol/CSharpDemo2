using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    interface IView
    {
        void start();
        void stop();
        String getString(String prompt);
        Int16 getInt(String prompt);
        void show<T>(T message);

    }
}
