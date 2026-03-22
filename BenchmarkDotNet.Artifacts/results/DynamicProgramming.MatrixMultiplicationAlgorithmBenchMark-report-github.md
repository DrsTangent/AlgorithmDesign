```

BenchmarkDotNet v0.15.8, Linux Kali GNU/Linux 2024.4
Intel Core i5-6300U CPU 2.40GHz (Max: 2.70GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.411
  [Host]     : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 8.0.17 (8.0.17, 8.0.1725.26602), X64 RyuJIT x86-64-v3


```
| Method            | matricesCount | Mean        | Error     | StdDev     | Median      |
|------------------ |-------------- |------------:|----------:|-----------:|------------:|
| **MatrixChainOrderI** | **2**             |    **98.20 ns** |  **2.028 ns** |   **2.490 ns** |    **97.83 ns** |
| MatrixChainOrderR | 2             |   105.65 ns |  2.119 ns |   3.171 ns |   105.19 ns |
| **MatrixChainOrderI** | **3**             |   **134.29 ns** |  **2.330 ns** |   **3.189 ns** |   **133.47 ns** |
| MatrixChainOrderR | 3             |   137.36 ns |  1.720 ns |   1.343 ns |   137.59 ns |
| **MatrixChainOrderI** | **4**             |   **170.45 ns** |  **3.456 ns** |   **3.979 ns** |   **171.04 ns** |
| MatrixChainOrderR | 4             |   222.32 ns |  4.510 ns |   5.538 ns |   221.28 ns |
| **MatrixChainOrderI** | **5**             |   **247.76 ns** |  **4.923 ns** |   **5.861 ns** |   **245.47 ns** |
| MatrixChainOrderR | 5             |   315.81 ns |  5.986 ns |   4.999 ns |   313.57 ns |
| **MatrixChainOrderI** | **6**             |   **351.44 ns** |  **3.907 ns** |   **3.655 ns** |   **350.61 ns** |
| MatrixChainOrderR | 6             |   494.13 ns |  8.414 ns |   7.870 ns |   493.60 ns |
| **MatrixChainOrderI** | **7**             |   **467.47 ns** |  **2.905 ns** |   **2.575 ns** |   **468.07 ns** |
| MatrixChainOrderR | 7             |   851.63 ns | 31.351 ns |  91.948 ns |   820.53 ns |
| **MatrixChainOrderI** | **8**             |   **663.68 ns** |  **7.604 ns** |   **6.349 ns** |   **665.11 ns** |
| MatrixChainOrderR | 8             | 1,202.31 ns | 47.052 ns | 137.997 ns | 1,134.75 ns |
| **MatrixChainOrderI** | **9**             |   **852.12 ns** |  **9.747 ns** |   **9.117 ns** |   **852.21 ns** |
| MatrixChainOrderR | 9             | 1,500.95 ns | 28.619 ns |  69.662 ns | 1,490.42 ns |
