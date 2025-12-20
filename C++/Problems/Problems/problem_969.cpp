#include "problem_969.h"

bool problem_969::test() {
    std::vector arr { 3, 2, 4, 1 };

    std::vector expected { 3, 4, 2, 3, 1, 2 };

    auto result = pancakeSort(arr);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_969::pancakeSort(std::vector<int> &arr) {
    int n = arr.size();
    std::vector<int> result;
    for (int i = 1; i < n; ++i)
    {
        int mi = 0;
        for (int j = 1; j <= n - i; ++j)
        {
            if (arr[j] > arr[mi])
                mi = j;
        }
        if (mi == n - i)
            continue;
        flip(mi, arr);
        result.push_back(mi + 1);
        flip(n - i, arr);
        result.push_back(n - i + 1);
    }

    return result;
}

void problem_969::flip(int k, std::vector<int>& arr) {
    for (int i = 0; i <= k / 2; ++i)
    {
        int tmp = arr[i];
        arr[i] = arr[k - i];
        arr[k - i] = tmp;
    }
}
