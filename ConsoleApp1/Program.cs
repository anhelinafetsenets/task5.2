using System;

namespace ConsoleApp1
{
    class Body
    {
        int[, ,] bodyArr;
        int[,] xy;
        int[,] xz;
        int[,] yz;
        int m;
        int n;
        int p;
        public Body(int[, ,] bodyArr, int m, int n, int p)
        {
            this.m = m;
            this.n = n;
            this.p = p;

            this.bodyArr = new int[this.m,this.n,this.p];
            this.xy = new int[this.m, this.n];
            this.xz = new int[this.m, this.p];
            this.yz = new int[this.n, this.p];

            this.bodyArr = bodyArr;
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; j++)
                {
                    for(int k = 0; k < p; k++)
                    {
                        if (this.bodyArr[i,j,k] == 1)
                        {
                            this.xy[i,j] = 1;
                            this.xz[i, k] = 1;
                            this.yz[j, k] = 1;
                        }
                        else
                        {
                            this.xy[i, j] = 0;
                            this.xz[i, k] = 0;
                            this.yz[j, k] = 0;
                        }
                    }
                }
            }

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
