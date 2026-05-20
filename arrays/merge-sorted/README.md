# Merge Sorted Array

## Overview

This problem implements an in-place merge operation for two sorted integer arrays.

The solution demonstrates the two-pointer technique using reverse traversal, allowing the merge to occur directly inside `nums1` without requiring additional memory allocation.

This is a classic array manipulation and interview-style algorithm problem focused on efficient in-place modification.

---

## Problem Statement

Implement a function `merge(nums1, m, nums2, n)` that merges two sorted arrays into a single sorted array stored directly inside `nums1`.

The function must follow these rules:

### 1. Sorted Input Arrays
- Both input arrays are already sorted in non-decreasing order.

### 2. In-Place Merge
- The merged result must be stored directly in `nums1`.
- No additional array should be returned.

### 3. Extra Capacity in nums1
- `nums1` has a total length of `m + n`.
- The first `m` elements are valid values.
- The remaining `n` elements are placeholders (`0`) reserved for the merge result.

### 4. Maintain Sorted Order
- The final array must remain sorted in non-decreasing order.

---

## Approach

This solution uses a reverse two-pointer merge strategy.

Instead of shifting elements forward, the algorithm fills `nums1` from the end toward the beginning.

### Steps:

- Initialize a pointer at the end of the valid portion of `nums1`
- Initialize a pointer at the end of `nums2`
- Initialize a write pointer at the last index of `nums1`
- Compare elements from the back of both arrays
- Insert the larger element into the write position
- Move pointers accordingly
- Continue until one array is exhausted
- Copy any remaining elements from either array

This approach avoids overwriting unprocessed values in `nums1`.

---

## Key Concepts

- Two-pointer technique
- Reverse traversal
- In-place array modification
- Sorted array merging
- Pointer/index management
- Greedy element placement
- Constant-space optimization

---

## Edge Cases Handled

- Empty `nums2`
- Empty valid portion of `nums1`
- Arrays with duplicate values
- Arrays of different lengths
- Single-element arrays
- All elements from one array smaller than the other
- All elements from one array larger than the other

---

## Complexity Analysis

### Time Complexity

O(m + n)

Each element from both arrays is processed at most once.

---

### Space Complexity

O(1)

The merge is performed entirely in-place using only pointer variables.

---

## Patterns Used

- Two-pointer traversal
- Reverse iteration
- In-place mutation
- Greedy comparison strategy
- Sorted merge processing

---

## Notes

- Reverse traversal is critical to avoid overwriting values in `nums1` before they are processed.
- This implementation does not allocate an auxiliary array.
- The algorithm efficiently handles duplicate values while preserving sorted order.
- Remaining elements from `nums2` must still be copied if `nums1` is exhausted first.
- Remaining elements from `nums1` are already in the correct position if `nums2` becomes exhausted first.

---

## Languages

- Python
