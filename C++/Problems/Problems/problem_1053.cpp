#include "problem_1053.h"

bool problem_1053::test() {
    std::vector arr { 3, 2, 1 };

    std::vector expected { 3, 1, 2 };

    auto result = prevPermOpt1(arr);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1053::prevPermOpt1(std::vector<int> &arr) {
    int n = arr.size();
    for (int i = n - 2; i >= 0; --i)
    {
        if (arr[i] > arr[i + 1])
        {
            int m = n - 1;
            while (arr[m] >= arr[i] || arr[m - 1] == arr[m])
                m--;
            int tmp = arr[i];
            arr[i] = arr[m];
            arr[m] = tmp;
            break;
        }
    }

    return arr;
}

