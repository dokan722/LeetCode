#include "problem_2161.h"

bool problem_2161::test() {
    std::vector nums  { 9, 12, 5, 10, 14, 3, 10 };
    int pivot = 10;

    std::vector expected { 9, 5, 3, 10, 10, 12, 14 };

    auto result = pivotArray(nums, pivot);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2161::pivotArray(std::vector<int> &nums, int pivot) {
    int n = nums.size();
    std::vector result(n, 0);
    int lp = 0;
    int rp = n - 1;
    for (int i = 0; i < n; ++i)
    {
        int left = nums[i];
        int right = nums[n - 1 - i];
        if (left < pivot)
            result[lp++] = left;
        if (right > pivot)
            result[rp--] = right;
    }
    for (int i = lp; i <= rp; ++i)
        result[i] = pivot;

    return result;
}
