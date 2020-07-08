using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS28
{
    class Orders : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("発注テーブル登録");
        }
    }
}
