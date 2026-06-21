#include "problem_978.h"

bool problem_978::test() {
    std::vector arr  { 9, 4, 2, 10, 7, 8, 8, 1, 9 };

    int expected = 5;

    auto result = maxTurbulenceSize(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_978::maxTurbulenceSize(std::vector<int> &arr) {
    int n = arr.size();
    int result = 1;
    std::vector cur { 1, 1 };
    for (int i = 1; i < n; ++i)
    {
        if (i % 2 == 0)
        {
            if (arr[i] < arr[i - 1])
            {
                cur[0]++;
                cur[1] = 1;
            }
            else if (arr[i] > arr[i - 1])
            {
                cur[0] = 1;
                cur[1]++;
            }
            else
            {
                cur[0] = 1;
                cur[1] = 1;
            }
        }
        else
        {
            if (arr[i] < arr[i - 1])
            {
                cur[0] = 1;
                cur[1]++;
            }
            else if (arr[i] > arr[i - 1])
            {
                cur[0]++;
                cur[1] = 1;
            }
            else
            {
                cur[0] = 1;
                cur[1] = 1;
            }
        }
        result = std::max(result, std::max(cur[0], cur[1]));
    }

    return result;
}
