# Reverse Integer

## Overview

This problem implements a function to reverse the digits of a 32-bit signed integer while preserving its sign and handling integer overflow constraints.

The solution demonstrates digit extraction using modulus operations, iterative number reconstruction, and strict overflow detection—commonly used in low-level numeric manipulation and interview-style algorithm problems.

---

## Problem Statement

Implement a function `Reverse(int x)` that takes a 32-bit signed integer and returns its digits reversed.

The function must follow these rules:

### 1. Sign Preservation
- The sign of the input integer must be preserved in the output.

### 2. Digit Reversal
- The digits of the integer are reversed in order.
- Example: `123 → 321`, `-123 → -321`

### 3. 32-bit Integer Overflow Handling
If reversing the integer causes the value to exceed the 32-bit signed integer range:
- Return `0` instead of the reversed value.

Valid range:
- `Int32.MaxValue` (2³¹ - 1)
- `Int32.MinValue` (-2³¹)

---

## Approach

This solution uses a single-pass iterative digit extraction strategy:

### Steps:

- Initialize a result variable to store the reversed number
- Extract the last digit of the number using modulo 10
- Remove the last digit using integer division by 10
- Rebuild the reversed number incrementally
- Perform overflow detection before each multiplication step
- Continue until all digits are processed

---

## Key Concepts

- Integer digit extraction using modulus (`x % 10`)
- Integer reduction using division (`x / 10`)
- Incremental number construction (`result = result * 10 + digit`)
- Overflow detection using boundary checks
- Handling negative numbers without normalization
- Constant-space numeric transformation

---

## Edge Cases Handled

- Positive integers
- Negative integers
- Single-digit inputs
- Inputs ending in zero (e.g. `120 → 21`)
- Maximum and minimum 32-bit integer values
- Overflow scenarios (returning `0`)
- Mixed sign-digit arithmetic behavior

---

## Complexity Analysis

### Time Complexity

O(n)

Where n is the number of digits in the input integer.

Each digit is processed exactly once.

---

### Space Complexity

O(1)

Only a fixed number of integer variables are used regardless of input size.

---

## Patterns Used

- Digit extraction and reconstruction
- Iterative numeric decomposition
- Greedy accumulation
- Integer overflow boundary validation
- Sign-aware arithmetic handling

---

## Notes

- This implementation avoids string conversion (e.g., `ToString()` / parsing).
- Overflow is handled during construction rather than after completion.
- The solution relies on C# remainder behavior for negative numbers, which preserves correctness without explicit sign normalization.
- A safer alternative approach can use `long` for intermediate storage to simplify overflow handling.

---

## Languages

- C# (.NET)
