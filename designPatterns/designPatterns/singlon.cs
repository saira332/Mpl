using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    class singlon
    {
        public static int objCount;
        public static singlon obj;

        private singlon()
        {
            objCount++;
        }

        public static singlon setObj()
        {
            if (obj == null)
            {
                obj = new singlon();
            }

            return obj;
        }

        public string Message(string msg)
        {
            Console.WriteLine(msg);
            return msg;
        }
    }
}
