# Merge Two Sorted Linked Lists

## Problem Statement

Given two sorted singly linked lists, merge them into a single sorted linked list and return the head of the merged list.

The resulting list should be constructed by reusing existing nodes from both lists while maintaining sorted order.

---

## Approach

This solution uses an iterative **two-pointer technique**:

- Maintain pointers for both input lists (`list1` and `list2`)
- Compare current node values at each step
- Select the smaller node and append it to the result list
- Advance the pointer from the selected list
- Repeat until both lists are fully traversed

The algorithm builds the merged list incrementally by always choosing the smallest available node.

---

## Key Idea

At each step, the algorithm selects the smallest current node from either list, ensuring the final merged list remains sorted without requiring additional sorting operations.

This follows the classic **merge pattern**, commonly used in merge sort.
