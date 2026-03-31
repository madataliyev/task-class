using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lESSO_TASK.Exseption
{
    internal class ConflictException : Exception
    {
        public ConflictException( string message ):base(message) 
        {
            
        }
    }
}
