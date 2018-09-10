using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class TcUlit
    {
        public static string TC(string al, string Url)
        {
            return "<script>alert(\"" + al+ "\"); location.href=\"" + Url + "\";</script>";
        }
    }
}
