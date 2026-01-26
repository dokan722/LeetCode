#include "problem_1200.h"

#include <algorithm>

bool problem_1200::test() {
    std::vector arr { 3, 8, -10, 23, 19, -4, -14, 27 };

    std::vector<std::vector<int>> expected  {  { -14, -10 },  { 19, 23 },  { 23, 27 } };

    auto result = minimumAbsDifference(arr);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_1200::minimumAbsDifference(std::vector<int> &arr) {
    int arrLength = arr.size();
    std::sort(arr.begin(), arr.end());
    int minDiff = arr[1] - arr[0];
    std::vector<std::vector<int>> result  {  { arr[0], arr[1] } };
    for (int i = 2; i < arrLength; ++i)
    {
        int curDiff = arr[i] - arr[i - 1];
        if (curDiff == minDiff)
            result.push_back(std::vector { arr[i - 1], arr[i] });
        else if (curDiff < minDiff)
        {
            minDiff = curDiff;
            result = std::vector<std::vector<int>>{ { arr[i - 1], arr[i] } };
        }
    }

    return result;
}
