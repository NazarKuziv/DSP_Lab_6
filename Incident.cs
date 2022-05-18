using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab_6
{
    class Incident
    {
        private int[,] matrix = null;
        private int n = 0;
        private int m = 0;
        public int GetM() { return this.m; }
        public int GetN() { return this.n; }
        public int[,] GetMatrix() { return this.matrix; }
     
        public int[,] CreateMatrix(FileViewer file, int[,] matrix)
        {
            int[] N = FillN(file.GetN());
            this.n = file.GetN();
            this.m = file.GetM();
            int[,] M = new int[file.GetN() + 1, file.GetM() + 1];
            

            for (int i = 1; i < file.GetN() + 1; i++)
            {
                for (int j = 1; j < file.GetM() + 1; j++)
                {
                    int v = matrix[j, 0];
                    int u = matrix[j, 1];

                    if (N[i] == v && v == u)
                    {
                        M[i, j] = 2;
                    }
                    else if (N[i] == v)
                    {
                        M[i, j] = -1;
                    }
                    else if (N[i] == u)
                    {
                        M[i, j] = 1;
                    }
                    else
                    {
                        M[i, j] = 0;
                    }
                }
            }
            this.matrix = M;
            return M;
        }
        public int[] FillN(int n)
        {
            int[] N = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                N[i] = i;
            }
            return N;
        }
        public static void PrintMatrix(int[,] incidentMatrix, FileViewer file)
        {
            Console.Write("   | ");
            for (int j = 1; j < file.GetM() + 1; j++)
            {
                Console.Write($"{j,2} | ");
            }
            Console.WriteLine();
            for (int i = 1; i < file.GetN() + 1; i++)
            {
                Console.Write($"{i,2} | ");
                for (int j = 1; j < file.GetM() + 1; j++)
                {
                    Console.Write($"{incidentMatrix[i, j],2} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
