using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS21
{
    public class ClassA
    {
        // カウント値を保持する
        private int _count = 0;

        /// <summary>
        /// インスタンス
        /// </summary>
        /// <param name="count">カウントの初期値</param>
        public ClassA(int count)
        {
            _count = count;
        }

        /// <summary>
        /// カウントする
        /// </summary>
        public void Call()
        {
            _count++;
        }

        /// <summary>
        /// カウントされた数を返す
        /// </summary>
        /// <returns>カウントされた数</returns>
        public int GetCount()
        {
            return _count;
        }
    }
}
