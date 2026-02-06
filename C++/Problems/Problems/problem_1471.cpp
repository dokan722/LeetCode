#include "problem_1471.h"

#include <algorithm>

bool problem_1471::test() {
    std::vector arr  { 6, 7, 11, 7, 6, 8 };
    int k = 5;

    std::vector expected { 11, 8, 6, 6, 7 };

    auto result = getStrongest(arr, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1471::getStrongest(std::vector<int> &arr, int k) {
    int n = arr.size();
    if (k == n)
        return arr;
    std::sort(arr.begin(), arr.end());
    std::vector<int> result(k);
    int m = arr[(n - 1) / 2];
    int left = 0;
    int right = n - 1;
    for (int i = 0; i < k; ++i)
    {
        if (std::abs(m - arr[left]) > std::abs(m - arr[right]))
        {
            result[i] = arr[left];
            left++;
        }
        else
        {
            result[i] = arr[right];
            right--;
        }
    }

    return result;
}
