using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KDTreeDLL;

namespace kdtree
{
    class main
    {
        static void Main()
        {
            double[] A = { 2, 5 };
            double[] B = { 1, 1 };
            double[] C = { 3, 9 };
            double[] T = { 1, 10 };

            var kd = new KDTree(2);
            try
            {
                kd.insert(A, ("A"));
                kd.insert(B, ("B"));
                kd.insert(C, ("C"));
            }
            catch (Exception)
            {
                
            }

            // 查找
            Console.WriteLine(kd.search(B));

            // 寻找最近的一个
            Console.WriteLine(kd.nearest(B));

            // 寻找附近的N个
            var ret = kd.nearest(B, 3);
            foreach (var it in ret)
            {
                Console.WriteLine(it);
            }            

            Console.WriteLine("按任意键退出...");
            Console.ReadKey();
        }
    }
}
