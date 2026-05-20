# String to Integer (atoi)
## Overview

This problem implements a custom version of the atoi (ASCII to Integer) function, which converts a string into a 32-bit signed integer following strict parsing rules.

The solution demonstrates controlled string parsing, state tracking, and integer overflow handling—common in low-level parsing logic and interview-style string manipulation problems.

---

## Problem Statement

Implement a function MyAtoi(string s) that converts a string into a 32-bit signed integer.

The function must follow these rules:

### 1. Whitespace Handling
Ignore any leading whitespace characters.

### 2. Sign Determination
- If the next character is `'-'`, the result is negative.
- If it is `'+'`, the result is positive.
- If neither is present, assume positive.

### 3. Digit Parsing
Read numeric characters until a non-digit character is encountered or the string ends.

### 4. Leading Zeros
Ignore leading zeros in the numeric portion.

### 5. 32-bit Integer Clamping
If the value exceeds the 32-bit signed integer range:
- Clamp to `Int32.MaxValue` (2³¹ - 1)
- Clamp to `Int32.MinValue` (-2³¹)

---


## Approach

This solution uses a single-pass iterative parsing strategy:

### Steps:

- Use an index pointer to traverse the string
- Skip leading whitespace
- Capture optional sign (`+` or `-`)
- Skip leading zeros
- Convert digit characters into an integer incrementally
- Check for overflow/underflow before updating result
- Stop when a non-digit character is encountered

---

## Key Concepts

- String traversal using index pointer
- Character classification (`char.IsDigit`)
- Manual numeric conversion (`s[i] - '0'`)
- Integer overflow detection
- State-based parsing (whitespace → sign → digits)
- Defensive handling of edge cases

---

## Edge Cases Handled

- Empty string
- Only whitespace input
- No numeric characters
- Mixed alphanumeric strings (e.g. `"1337c0d3"`)
- Leading zeros (e.g. `"-042"`)
- Overflow / underflow scenarios
- Sign-only inputs (`"+"`, `"-"`)

---

## Complexity Analysis

### Time Complexity

O(n)
Where n is the length of the input string.
Each character is processed at most once.

---

### Space Complexity

O(1)
Only a fixed number of variables are used regardless of input size.

---

## Patterns Used

- Linear string scanning (index-based traversal)
- Token parsing pattern
- Greedy digit accumulation
- Integer boundary clamping

---

## Notes

- This implementation avoids built-in parsing methods like `int.Parse` or `Convert.ToInt32`.
- Overflow is handled during accumulation instead of after computation.
- The logic mirrors low-level parsing behavior used in systems programming and runtime libraries.

---

## Languages

- C# (.NET)
