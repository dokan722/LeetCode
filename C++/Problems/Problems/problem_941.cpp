#include "problem_941.h"

bool problem_941::test() {
    std::vector arr { 0, 3, 2, 1 };

    auto expected = true;

    auto result = validMountainArray(arr);

    return expected == result;
}

bool problem_941::validMountainArray(std::vector<int> &arr) {
    if (arr.size() < 3 || arr[0] >= arr[1])
        return false;
    auto climbing = true;
    for (int i = 1; i < arr.size(); i++)
    {
        if (climbing && arr[i] > arr[i - 1])
            continue;
        climbing = false;
        if (arr[i] < arr[i - 1])
            continue;
        return false;
    }

    return !climbing;
}
