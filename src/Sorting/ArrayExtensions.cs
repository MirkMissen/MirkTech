namespace Sorting;

public static class ArrayExtensions {
    public static void Swap<T>(this T[] array, int i, int j) {
        (array[i], array[j]) = (array[j], array[i]);
    }
}