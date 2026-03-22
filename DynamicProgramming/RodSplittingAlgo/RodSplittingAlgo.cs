
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DynamicProgramming
{
    class RodSplittingAlgorithm
    {
        private int[] prices;

        public RodSplittingAlgorithm(int[] prices)
        {
            this.prices = prices;

        }

        public int TopButtomGetMaxRevenueWithDict(int rodLength)
        {
            Dictionary<int, int> memoization = new();
            return TopButtomGetMaxRevenueWithDictR(rodLength, memoization);
        }
        private int TopButtomGetMaxRevenueWithDictR(int rodLength, Dictionary<int, int> memoization)
        {
            if (rodLength <= 0) return 0;
            if (memoization.TryGetValue(rodLength, out int cachedValue)) return cachedValue;


            int maxRevenue = 0;
            for (int i = 1; i <= rodLength && i <= prices.Length; i++)
            {
                maxRevenue = Math.Max(maxRevenue, prices[i - 1] + TopButtomGetMaxRevenueWithDictR(rodLength - i, memoization));
            }

            memoization[rodLength] = maxRevenue;
            return maxRevenue;
        }


        public int TopButtomGetMaxRevenue(int rodLength)
        {
            int[] memoization = new int[rodLength + 1];
            return TopButtomGetMaxRevenueR(rodLength, memoization);
        }
        private int TopButtomGetMaxRevenueR(int rodLength, int[] memoization)
        {
            if (rodLength <= 0) return 0;
            if (memoization[rodLength] != 0) return memoization[rodLength];

            int maxRevenue = 0;
            for (int i = 1; i <= rodLength && i <= prices.Length; i++)
            {
                maxRevenue = Math.Max(maxRevenue, prices[i - 1] + TopButtomGetMaxRevenueR(rodLength - i, memoization));
            }

            memoization[rodLength] = maxRevenue;
            return maxRevenue;
        }

        public int BottomUpGetMaxRevenue(int rodLength)
        {
            int[] dp = new int[rodLength + 1];
            for (int i = 1; i <= rodLength; i++)
            {
                for (int j = 1; j <= i && j <= prices.Length; j++)
                {
                    dp[i] = Math.Max(dp[i], prices[j - 1] + dp[i - j]);
                }
            }
            return dp[rodLength];
        }
    }

    public class RodSplittingAlgorithmBenchMark
    {
        [Params(10, 100, 1000)]
        public int rodLength;

        private int[] prices;// Prices for rod lengths 0 to 8

        [GlobalSetup]
        public void Setup()
        {

            prices = new[] { 1, 5, 8, 9, 10, 17, 17, 20 };
        }

        [Benchmark]
        public void TopButtomGetMaxRevenueWithDict()
        {
                RodSplittingAlgorithm rodCutting = new(prices);
                rodCutting.TopButtomGetMaxRevenueWithDict(rodLength);
        }
        
        [Benchmark]
        public void TopButtomGetMaxRevenue()
        {
                RodSplittingAlgorithm rodCutting = new(prices);
                rodCutting.TopButtomGetMaxRevenue(rodLength);
        }

        [Benchmark]
        public void BottomUpGetMaxRevenue()
        {
                RodSplittingAlgorithm rodCutting = new(prices);
                rodCutting.BottomUpGetMaxRevenue(rodLength);
        }
    }
}