#include "problem_1089.h"

bool problem_1089::test() {
    std::vector arr { 1, 0, 2, 3, 0, 4, 5, 0 };

    std::vector expected { 1, 0, 0, 2, 3, 0, 0, 4 };

    duplicateZeros(arr);

    return arr == expected;
}

void problem_1089::duplicateZeros(std::vector<int> &arr) {
    int n = arr.size();
    std::vector<int> result(n);
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[j] == 0)
        {
            result[i] = 0;
            i++;
            if (i < n)
                result[i] = 0;
        }
        else
            result[i] = arr[j];
        j++;
    }

    std::copy(result.begin(), result.end(), arr.begin());
}
