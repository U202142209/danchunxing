/// author: @我不是大佬
/// qq    : 2869210303
/// email : 2869210303@qq.com
/// wx    : safeseaa
/// CopyRight Protected.
using System;

namespace 单纯形法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("线性规划求解程序...");
            matrix C = new matrix(1,6, "1,-1,1,1,-1,1");
            matrix A = new matrix(3, 6, 
                "1,6,0,1,0,0," +
                "3,2,-4,0,1,0," +
                "1,2,3,0,0,1");
            matrix B = new matrix(3, 1, "9,2,6");
            // 单纯型表
            DanChunXingSolver dcx = new DanChunXingSolver(A, B, C);
            matrix X;
            string out_string;
            Retional S= dcx.Solve(out X,out out_string);
            Console.WriteLine("求解过程：\n" + out_string);
            Console.WriteLine(X.ToString());
            Console.ReadKey();
        }
    }
}
