```

BenchmarkDotNet v0.15.8, Linux Kali GNU/Linux 2024.4
Intel Core i5-6300U CPU 2.40GHz (Max: 2.80GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.411
  [Host]     : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3


```
| Method                         | rodLength | Mean         | Error       | StdDev      | Median       |
|------------------------------- |---------- |-------------:|------------:|------------:|-------------:|
| **TopButtomGetMaxRevenueWithDict** | **10**        |     **794.8 ns** |    **13.99 ns** |    **11.68 ns** |     **797.0 ns** |
| TopButtomGetMaxRevenue         | 10        |     252.6 ns |     6.59 ns |    17.81 ns |     245.3 ns |
| BottomUpGetMaxRevenue          | 10        |     125.1 ns |     1.42 ns |     1.33 ns |     124.9 ns |
| **TopButtomGetMaxRevenueWithDict** | **100**       |   **9,426.4 ns** |   **154.06 ns** |   **144.11 ns** |   **9,421.7 ns** |
| TopButtomGetMaxRevenue         | 100       |   4,156.0 ns |    82.11 ns |   181.95 ns |   4,135.9 ns |
| BottomUpGetMaxRevenue          | 100       |   2,297.2 ns |    39.68 ns |    35.17 ns |   2,297.5 ns |
| **TopButtomGetMaxRevenueWithDict** | **1000**      | **101,151.3 ns** | **2,002.00 ns** | **3,558.55 ns** | **100,994.7 ns** |
| TopButtomGetMaxRevenue         | 1000      |  33,276.2 ns |   656.77 ns | 1,495.80 ns |  32,681.0 ns |
| BottomUpGetMaxRevenue          | 1000      |  23,132.1 ns |   449.87 ns |   630.65 ns |  23,063.3 ns |
