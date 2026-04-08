#include "problem_1299.h"

bool problem_1299::test() {
    std::vector arr { 17, 18, 5, 4, 6, 1 };

    std::vector expected { 18, 6, 6, 6, 1, -1 };

    auto result = replaceElements(arr);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1299::replaceElements(std::vector<int> &arr) {
    int n = arr.size();
    int mx = arr[n - 1];
    arr[n - 1] = -1;
    for (int i = n - 2; i >= 0; --i)
    {
        int tmp = arr[i];
        arr[i] = mx;
        mx = std::max(mx, tmp);
    }

    return arr;
}
