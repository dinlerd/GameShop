using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface IDatabaseDal
    {
        void Add();
        void Delete();
        void Update();
    }
}
