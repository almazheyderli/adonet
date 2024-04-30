using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public static  class Helper
    {
        public static bool CheckName(this string name)
        {
           for(int i = 0; i < name.Length; i++)
            {
                if (!char.IsUpper(name[0]))
                {
                    return false;
                }
            }
           return true;
        }
    }
}
