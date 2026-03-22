

using BenchmarkDotNet.Running;
using DynamicProgramming;

void Main()
{
    // Call the runner method of the desired algorithm here
    // For example, to run the Rod Splitting Algorithm:
    BenchmarkRunner.Run<DynamicProgramming.RodSplittingAlgorithmBenchMark>();
    //BenchmarkRunner.Run<DynamicProgramming.MatrixMultiplicationAlgorithmBenchMark>();
}

Main();