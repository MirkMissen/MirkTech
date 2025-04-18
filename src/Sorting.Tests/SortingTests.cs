using Shouldly;

namespace Sorting.Tests;

public class SortingTests {

    public static TheoryData<ISort<int>> SortingStrategies = new() {
        new QuickSort<int>()
    };

    [Theory]
    [MemberData(nameof(SortingStrategies))]
    public void TestSorting(ISort<int> sorting) {

        int[] sample = [10, 3, 8, 4, 6, 8, 1, 0, 5, 7];
        int[] sorted = [0, 1, 3, 4, 5, 6, 7, 8, 8, 10];
        
        sorting.Sort(sample);
        
        for (var i = 0; i < sample.Length; i++) {
            sample[i].ShouldBe(sorted[i]);
        }

        for (var i = 1; i < sample.Length; i++) {
            sample[i - 1].ShouldBeLessThanOrEqualTo(sample[i]);
        }

        sample.ShouldBe(sorted);
    }

}