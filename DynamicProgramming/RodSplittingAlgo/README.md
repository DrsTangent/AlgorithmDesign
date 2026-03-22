# Rod Cutting Algorithms

This project implements three approaches to solve the Rod Cutting problem using dynamic programming.

## Problem

Given a rod of length `n` and an array `prices[]` where `prices[i]` represents the price of a rod of length `i + 1`, find the maximum revenue obtainable by cutting the rod.

---

## Implementations

### 1. Top-Down with Dictionary

`TopButtomGetMaxRevenueWithDict`

This approach uses recursion with memoization stored in a `Dictionary<int, int>`.

**How it works:**

* Break the problem into smaller subproblems recursively
* Store computed results in a dictionary
* Reuse cached results to avoid recomputation

**Pros:**

* Simple and intuitive
* Avoids redundant calculations

**Cons:**

* Dictionary operations are not truly constant time
* Higher memory overhead due to hashing
* Recursive call overhead

---

### 2. Top-Down with Array

`TopButtomGetMaxRevenue`

This approach also uses recursion, but stores results in an array instead of a dictionary.

**How it works:**

* Same recursive logic
* Uses direct indexing for memoization

**Pros:**

* Faster than dictionary-based approach
* True constant time access
* Lower overhead

**Cons:**

* Still uses recursion
* Stack usage increases with input size

---

### 3. Bottom-Up (Iterative)

`BottomUpGetMaxRevenue`

This approach builds the solution iteratively.

**How it works:**

* Start from smaller rod lengths
* Build up the solution using previously computed values

**Pros:**

* No recursion
* Better performance in practice
* Efficient memory access

**Cons:**

* Slightly less intuitive

---

## Complexity

All three approaches have:

* Time Complexity: O(n²)
* Space Complexity: O(n)

---

## Notes

### Dictionary Performance

Although dictionaries are often considered O(1), in practice:

* Hash collisions can occur
* Resizing can be expensive
* Memory access is less efficient than arrays

In worst cases, performance can degrade.

For problems like this where indices are known, arrays are a better choice.

---

### Recursive Overhead

Recursive solutions have additional costs:

* Function call overhead
* Stack frame allocation

Even with memoization, these costs remain.

Iterative solutions remove this overhead and are usually faster.

---

## Conclusion

* Dictionary-based memoization is the slowest among the three
* Array-based memoization is better but still has recursion cost
* Bottom-up approach is generally the most efficient

For performance-critical scenarios, prefer the bottom-up approach.


IMPORTANT:

Benchmarking:

| Method                         | rodLength | Mean         | Error       | StdDev      | Median       |
|------------------------------- |---------- |-------------:|------------:|------------:|-------------:|
| TopButtomGetMaxRevenueWithDict | 10        |     794.8 ns |    13.99 ns |    11.68 ns |     797.0 ns |
| TopButtomGetMaxRevenue         | 10        |     252.6 ns |     6.59 ns |    17.81 ns |     245.3 ns |
| BottomUpGetMaxRevenue          | 10        |     125.1 ns |     1.42 ns |     1.33 ns |     124.9 ns |
| TopButtomGetMaxRevenueWithDict | 100       |   9,426.4 ns |   154.06 ns |   144.11 ns |   9,421.7 ns |
| TopButtomGetMaxRevenue         | 100       |   4,156.0 ns |    82.11 ns |   181.95 ns |   4,135.9 ns |
| BottomUpGetMaxRevenue          | 100       |   2,297.2 ns |    39.68 ns |    35.17 ns |   2,297.5 ns |
| TopButtomGetMaxRevenueWithDict | 1000      | 101,151.3 ns | 2,002.00 ns | 3,558.55 ns | 100,994.7 ns |
| TopButtomGetMaxRevenue         | 1000      |  33,276.2 ns |   656.77 ns | 1,495.80 ns |  32,681.0 ns |
| BottomUpGetMaxRevenue          | 1000      |  23,132.1 ns |   449.87 ns |   630.65 ns |  23,063.3 ns |

A Massive Error can be noted in Dict Algorihtms Due to Function Calls and Dict Overhead.
