using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface IUser:IBaseDao<users>
    {
        bool Login(users us);
    }
}
