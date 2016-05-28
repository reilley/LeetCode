O(n) solution  with two simple pass in the array

For Example: A = [2,1,3,4,6,3,8,9,10,12,56], w=4

partition the array in blocks of size w=4. The last block may have less then w. 2, 1, 3, 4 | 6, 3, 8, 9 | 10, 12, 56|

Traverse the list from start to end and calculate maxsofar. Reset max after each block boundary (of w elements). left_max[] = 2, 2, 3, 4 | 6, 6, 8, 9 | 10, 12, 56

Similarly calculate max in future by traversing from end to start. right_max[] = 4, 4, 4, 4 | 9, 9, 9, 9 | 56, 56, 56

now, sliding max at each position i in current window, sliding-max(i) = max{rightmax(i), leftmax(i+w-1)} sliding_max = 4, 6, 6, 8, 9, 10, 12, 56