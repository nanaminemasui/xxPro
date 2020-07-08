using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS25
{
    internal class Counter
    {
        // 静的メンバー
        // クラス、変数名にstaticキーワードを付ける
        // インスタンス単位ではなく、クラス単位で生成される
        // アプリケーションに一つだけしか生成されない
        private static int _count = 0;

        /// <summary>
        /// 静的メソッド
        /// </summary>
        internal static void Call()
        {
            // 処理の中で使えるのは静的メンバーのみ
            _count++;
        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
