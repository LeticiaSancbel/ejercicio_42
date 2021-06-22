using System;

namespace Ejercicio42
{
    public class ClassOperator
    {
       public int result(string value)
        {
            int counter = 0;

            if (value.Contains("!"))
            {
                counter++;
            }
            if (value.Contains("&&"))
            {
                counter++;
            }
            if (value.Contains("||"))
            {
                counter++;
            }

            return counter;
        }
    }
}
