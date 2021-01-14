# Tree Algorithms

Repository with implementations of various trees and related algorithms.

## Trees Implemented+

- Binary tree
- Binary Heaps (Min, Max)
- Binary search tree
- Arithmetic expressions tree
- AVL tree (Insert method in progress)

## AVL Tree balance pseudocodes

### Left rotation
- Disengage input three `A`:
  - Set: `parent = A.Parent`
  - Set: `right = A.Right`
  - Set: `A.Right = null`
- Keep relations
  - Set: `right.Parent = parent`
  - Set if `parent != null`: `parent.Right = right`
  - Set: `right.Left = A`
  - Set: `A.Parent = right`

### Right rotations
- Disengage input tree `A`:
  - Set: `parent = A.Parent`
  - Set: `left = A.Left`
  - Set: `A.Left = null`
- Keep relations
  - Set: `left.Parent = parent`
  - Set if `parent != null`: `parent.Left = left`
  - Set: `A.Parent = left`
  - Set: `left.Right = A`


## Data Structures Implemented

- Priority Queue (Min, Max)

## Algorithms Implemented

- Floyd's Algorithm (Heapify in O(n) complexity)
- Shunting Yard Algorithm (Used to build arithmetic expressions tree)
- Heap Sort (Sorting with O(nlg(n)) in worst case)

## To do

- Implement recursive traversals for BST
- Implement recursive traversals for BT
- Implement iterative traversals for BT
- Write tests for Heaps
- Write tests for Heapsort
- Migrate all tests from previous project