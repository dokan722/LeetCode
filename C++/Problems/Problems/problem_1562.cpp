#include "problem_1562.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_1562::test() {
    std::vector nums { 3, 5, 1, 2, 4 };

    auto m = 1;

    auto expected = 4;

    auto result = findLatestStep(nums, m);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1562::findLatestStep(std::vector<int> &arr, int m) {
    auto groups = new int[arr.size() + 2] {0};
    auto result = -1;
    auto count = 0;
    for (int i = 1; i < arr.size() + 1; i++)
    {
        auto index = arr[i - 1];
        auto left = groups[index - 1];
        auto right = groups[index + 1];
        auto length = left + right + 1;
        groups[index - left] = length;
        groups[index + right] = length;
        if (left == m)
            count--;
        if (right == m)
            count--;
        if (length == m)
            count++;
        if (count > 0)
            result = i;
    }
    delete[] groups;
    return result;
}
