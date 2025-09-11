#include "problem_985.h"

bool problem_985::test() {
    std::vector nums { 1, 2, 3, 4 };
    std::vector<std::vector<int>> queries { { 1, 0 }, { -3, 1 }, { -4, 0 }, { 2, 3 } };

    std::vector expected { 8, 6, 2, 4 };

    auto result = sumEvenAfterQueries(nums, queries);

    return result == expected;
}

std::vector<int> problem_985::sumEvenAfterQueries(std::vector<int> &nums, std::vector<std::vector<int>> &queries) {
    int n = nums.size();
    int qn = queries.size();
    int evenSum = 0;
    for (int i = 0; i < n; ++ i)
        if (nums[i] % 2 == 0)
            evenSum += nums[i];


    std::vector<int> result(qn);
    for (int i = 0; i <  qn; ++i)
    {
        bool wasEven = nums[queries[i][1]] % 2 == 0;
        bool willBeEven = (nums[queries[i][1]] % 2 == 0) == (queries[i][0] % 2 == 0);
        int newVal = nums[queries[i][1]] + queries[i][0];
        if (wasEven)
        {
            if (willBeEven)
                evenSum += queries[i][0];
            else
                evenSum -= nums[queries[i][1]];
        }
        else
        {
            if (willBeEven)
                evenSum += newVal;
        }
        nums[queries[i][1]] = newVal;
        result[i] = evenSum;
    }

    return result;
}
