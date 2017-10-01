using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONARIOS
{
    class Usuario
    {
        public static int _Login;
        public static int Login
        {
            get { return _Login;  }
            set { _Login = value; }
        }
    }
}
