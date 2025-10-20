#include "problem_852.h"

bool problem_852::test() {
    std::vector arr { 0, 10, 5, 2 };

    int expected = 1;

    auto result = peakIndexInMountainArray(arr);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_852::peakIndexInMountainArray(std::vector<int> &arr) {
    int left = 0;
    int right = arr.size() - 1;
    while (left < right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] < arr[mid + 1])
            left = mid + 1;
        else
            right = mid;
    }

    return left;
}
