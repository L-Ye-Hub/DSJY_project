using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum StatusCode
    {
        OK = 200,
        NotFound = 404,
        Frozen = 403,
        Error = 500
    }
}
