namespace Sorting;

public interface ISort<in T> where T : IComparable<T> {
    void Sort(T[] array);
}