using CS18_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS18
{
    public class A1
    {
        public A1()
        {
            // アクセス修飾子確認

            // 同一アセンブリ内のinternalはアクセスできる。
            A2 a2 = new A2();
            // public修飾子は他クラスからでもアクセスできる。
            BP bP = new BP();

            // 〇 public どこからでもアクセス可能
            // 〇 internal 同一アセンブリ(exe,dll)のみアクセス可能
            // × private クラス内部のみアクセス可能
            // × protected クラス内部と派生クラス内部のみアクセス可能
            // 〇 protected internal クラス内部と派生クラス内部と同じアセンブリからもアクセス可能
            // × protected private 別アセンブリではないクラス内部と派生クラス内部のみアクセス可能
            A3 a3 = new A3();
            a3.PublicMethod();
            a3.InternalMethod();
            a3.ProtectedInternalMethod();
        }
    }

    class A11 : A3
    {
        public A11()
        {
            // アクセス修飾子確認

            // 同一アセンブリ内のinternalはアクセスできる。
            A2 a2 = new A2();
            // public修飾子は他クラスからでもアクセスできる。
            BP bP = new BP();

            // 〇 public どこからでもアクセス可能
            // 〇 internal 同一アセンブリ(exe,dll)のみアクセス可能
            // × private クラス内部のみアクセス可能
            // 〇 protected クラス内部と派生クラス内部のみアクセス可能
            // 〇 protected internal クラス内部と派生クラス内部と同じアセンブリからもアクセス可能
            // 〇 protected private 別アセンブリではないクラス内部と派生クラス内部のみアクセス可能
            base.PublicMethod();
            base.InternalMethod();
            base.ProtectedMethod();
            base.ProtectedInternalMethod();
            base.ProtectedPrivateMethod();
        }
    }
}
