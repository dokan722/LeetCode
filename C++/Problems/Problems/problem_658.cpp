#include "problem_658.h"

bool problem_658::test() {
    std::vector arr { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8 };
    int k = 3;
    int x = 5;

    std::vector expected { 3, 3, 4 };

    auto result = findClosestElements(arr, k, x);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_658::findClosestElements(std::vector<int> &arr, int k, int x) {
    int n = arr.size();
    if (n == k)
        return arr;
    int l = 0;
    int r = n - 1;
    while (l < r)
    {
        int mid = (l + r) / 2;
        if (arr[mid] >= x)
            r = mid;
        else
            l = mid + 1;
    }

    if (arr[l] > x)
        l--;
    r = l + 1;
    std::vector<int> result(k);
    for (int i = 0; i < k; ++i)
    {
        if (r >= n)
            l--;
        else if (l < 0)
            r++;
        else
        {
            if (std::abs(arr[l] - x) > std::abs(arr[r] - x))
                r++;
            else
                l--;
        }
    }
    for (int i = 1; i <= k; ++i)
        result[i - 1] = arr[l + i];

    return result;
}
