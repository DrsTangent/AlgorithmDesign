
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static DynamicProgramming.MatrixMultiplicationAlgorithm;

namespace DynamicProgramming
{
    public class MatrixMultiplicationAlgorithm
    {
        public struct Matrix
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }
        public MatrixMultiplicationAlgorithm()
        {
        }

        public int MatrixChainOrderR(Matrix[] matrices)
        {
            int n = matrices.Length;
            int[,] memo = new int[n, n];

            return MatrixChainOrderRecursive(memo, matrices, 0, n - 1);
        }

        public int MatrixChainOrderRecursive(int[,] memo, Matrix[] matrices, int i, int j)
        {
            if (i >= j)
            {
                return 0;
            }

            if (memo[i, j] != 0)
            {
                return memo[i, j];
            }

            int sum = int.MaxValue;

            
            for (int index = i; index < j; index++)
            {

                int currSum;
                //A . B (Current) . C   => AB . C or A BC
                //Finding A
                int aSum = MatrixChainOrderRecursive(memo, matrices, i, index);
                //Finding C
                int bSum = MatrixChainOrderRecursive(memo, matrices, index + 1, j);

                //AB First
                currSum = 0;
                currSum += aSum;

                // Row of A * Column of Curr *  Row of Curr 
                currSum += matrices[i].Row * matrices[index].Column * matrices[j].Column;

                currSum += bSum;

                sum = Math.Min(sum, currSum);
                
            }
            
            memo[i, j] = sum;

            return sum;
        }
        
        public int MatrixChainOrderI(Matrix[] matrices)
        {
            int n = matrices.Length;
            int[,] dp = new int[n, n];

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    int x = i + j;
                    int y = j;


                    int sum = int.MaxValue;

                    for (int k = 0; k < i; k++)
                    {
                        int yaxisdp = dp[x, y + k + 1];
                        int xaxisdp = dp[x - (i - k), y];
                        Matrix xMatrix = matrices[x];
                        Matrix yMatrix = matrices[y];
                        Matrix currMatrix = matrices[y + k];
                        int currSum = ( yMatrix.Row * xMatrix.Column * currMatrix.Column)  + yaxisdp + xaxisdp;

                        if (sum > currSum)
                        {
                            sum = currSum;
                        }
                    }

                    dp[x, y] = sum;
                }
            }

            // Printing DP
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write($"{dp[j, i]}\t");
            //     }
            //     Console.WriteLine();
            // }


            return dp[n - 1, 0];
        }
    }

    public class MatrixMultiplicationAlgorithmBenchMark
    {
        //Benchmarking Classs
        [Params(2, 3, 4, 5, 6, 7, 8, 9)]
        public int matricesCount;

        private Matrix[] matrices = new Matrix[]
        {
            new Matrix { Row = 30, Column = 35 },
            new Matrix { Row = 35, Column = 15 },
            new Matrix { Row = 15, Column = 5 },
            new Matrix {Row = 5, Column=10},
            new Matrix {Row = 10, Column=20},
            new Matrix {Row = 20, Column=25},
            new Matrix {Row = 25, Column=30},
            new Matrix {Row = 30, Column=45},
            new Matrix {Row = 45, Column=25}
        };

        private Matrix[] targetMatrices;

        [GlobalSetup]
        public void Setup()
        {

            targetMatrices = new Matrix[matricesCount];
            Array.Copy(matrices, targetMatrices, matricesCount);
        }

        [Benchmark]
        public void MatrixChainOrderI()
        {
            MatrixMultiplicationAlgorithm matrixMultiplicationAlgorithm = new MatrixMultiplicationAlgorithm();
            matrixMultiplicationAlgorithm.MatrixChainOrderI(targetMatrices);
        }

        [Benchmark]
        public void MatrixChainOrderR()
        {
            MatrixMultiplicationAlgorithm matrixMultiplicationAlgorithm = new MatrixMultiplicationAlgorithm();
            matrixMultiplicationAlgorithm.MatrixChainOrderR(targetMatrices);
        }
        public static void Runner()
        {
            //Making a simple runner atm
            Matrix[] matrices = new Matrix[]
            {
                new Matrix { Row = 30, Column = 35 },
                new Matrix { Row = 35, Column = 15 },
                new Matrix { Row = 15, Column = 5 },
                new Matrix {Row = 5, Column=10},
                new Matrix {Row = 10, Column=20},
                new Matrix {Row = 20, Column=25}
            };

            MatrixMultiplicationAlgorithm matrixMultiplicationAlgorithm = new MatrixMultiplicationAlgorithm();

            int result = matrixMultiplicationAlgorithm.MatrixChainOrderI(matrices);

            Console.WriteLine($"Iterative : {result}");

            int result2 = matrixMultiplicationAlgorithm.MatrixChainOrderR(matrices);

            Console.WriteLine($"Recursive : {result2}");
        }

        
    }
}