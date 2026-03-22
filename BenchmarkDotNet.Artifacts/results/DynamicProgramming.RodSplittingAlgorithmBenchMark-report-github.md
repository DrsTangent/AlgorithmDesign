```

BenchmarkDotNet v0.15.8, Linux Kali GNU/Linux 2024.4
Intel Core i5-6300U CPU 2.40GHz (Max: 2.80GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.411
  [Host]     : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3


```
| Method                         | rodLength | Mean         | Error        | StdDev        | Median       |
|------------------------------- |---------- |-------------:|-------------:|--------------:|-------------:|
| **TopButtomGetMaxRevenueWithDict** | **10**        |   **3,065.5 ns** |    **215.05 ns** |     **634.09 ns** |   **2,923.5 ns** |
| TopButtomGetMaxRevenue         | 10        |     860.1 ns |     47.79 ns |     140.91 ns |     869.9 ns |
| BottomUpGetMaxRevenue          | 10        |     462.4 ns |     30.66 ns |      89.93 ns |     463.2 ns |
| **TopButtomGetMaxRevenueWithDict** | **100**       |  **46,582.7 ns** |  **3,687.93 ns** |  **10,873.94 ns** |  **46,788.6 ns** |
| TopButtomGetMaxRevenue         | 100       |  13,992.2 ns |  1,103.59 ns |   3,253.95 ns |  12,993.2 ns |
| BottomUpGetMaxRevenue          | 100       |   7,006.5 ns |    404.28 ns |   1,192.04 ns |   7,009.0 ns |
| **TopButtomGetMaxRevenueWithDict** | **1000**      | **516,091.2 ns** | **53,147.17 ns** | **149,902.54 ns** | **525,000.2 ns** |
| TopButtomGetMaxRevenue         | 1000      | 175,605.8 ns | 18,388.40 ns |  54,218.61 ns | 173,000.7 ns |
| BottomUpGetMaxRevenue          | 1000      |  76,428.7 ns |  5,987.99 ns |  17,655.71 ns |  75,204.3 ns |
