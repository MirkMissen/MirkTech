namespace Sorting;

public class QuickSort<T> : ISort<T> where T : IComparable<T> {
    
    /**
     *
     * There are mainly three steps in the algorithm:
        Choose a Pivot: Select an element from the array as the pivot. The choice of pivot can vary (e.g., first element, last element, random element, or median).
        Partition the Array: Rearrange the array around the pivot. After partitioning, all elements smaller than the pivot will be on its left, and all elements greater than the pivot will be on its right. The pivot is then in its correct position, and we obtain the index of the pivot.
        Recursively Call: Recursively apply the same process to the two partitioned sub-arrays (left and right of the pivot).
        Base Case: The recursion stops when there is only one element left in the sub-array, as a single element is already sorted.
     */
    
    public void Sort(T[] array) {
        Sort(array, 0, array.Length - 1);
    }

    private void Sort(T[] array, int start, int end) {
        if (start >= end) return;
        
        var pivotIndex = Partition(array, start, end);
        Sort(array, start, pivotIndex - 1);
        Sort(array, pivotIndex + 1, end);
    }

    private int Partition(T[] array, int start, int end) {
        
        // Pivot is the LAST element.
        var pivot = array[end];
        
        // Defines the current point where the pivot should be stored.
        var i = start;

        for (var j = start; j < end; j++) {
            if (array[j].CompareTo(pivot) < 0) {
                
                // When something is less than the pivot, it is placed on the ith position.
                array.Swap(i, j);
                
                // The pivot position is moved 1 up.
                i++;
            }
        }
        
        array.Swap(i, end);
        return i;
    }

}