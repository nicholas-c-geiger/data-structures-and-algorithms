# Merge Two Sorted Linked Lists

## Overview

This problem focuses on merging two sorted singly linked lists into a single sorted linked list while maintaining sorted order throughout the merge process.

The implementation demonstrates fundamental linked list manipulation techniques, pointer management, and the classic merge pattern commonly used in divide-and-conquer algorithms such as merge sort.

---

## Problem Statement

Given two sorted singly linked lists, merge them into a single sorted linked list and return the head of the merged list.

The resulting list should be constructed by reusing existing nodes from both input lists rather than creating a separate collection of values.

---

## Approach

This solution uses an iterative **two-pointer technique**:

- Maintain pointers for both input lists (`list1` and `list2`)
- Compare the current node values at each step
- Select the smaller node and append it to the merged list
- Advance the pointer from the list that provided the selected node
- Continue until both lists have been fully traversed

The merged list is built incrementally by always selecting the smallest available node from the two input lists.

---

## Key Concepts

This implementation reinforces several important computer science fundamentals:

- Linked list traversal
- Pointer manipulation
- Iterative problem solving
- Merge patterns
- Ordered data processing
- In-place node reuse

The solution follows the classic **merge pattern**, which is a foundational technique used in algorithms such as merge sort.

---

## Complexity Analysis

### Time Complexity

O(n + m)

Where:

- `n` = number of nodes in `list1`
- `m` = number of nodes in `list2`

Each node is visited exactly once during the merge process.

---

### Space Complexity

O(1)

The algorithm uses constant auxiliary space because it reuses existing nodes and only maintains a small number of pointer references.

> Note: If considering the returned merged list as part of total memory usage, overall space usage is O(n + m). Auxiliary space remains O(1).

---

## Patterns Used

- Two Pointers
- Merge Pattern
- Linked List Traversal

---

## Notes

- The implementation performs the merge in-place by reusing existing nodes.
- No additional linked list data structure is allocated.
- A dummy head node could also be used to simplify some edge-case handling.
- This pattern is commonly used in sorting and ordered data processing algorithms.

---

## Languages

Current implementation:

- C# (.NET)

Additional implementations in other languages may be added over time.
