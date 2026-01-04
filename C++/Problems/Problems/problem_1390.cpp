#include "problem_1390.h"

#include <cmath>

bool problem_1390::test() {
    std::vector nums { 21, 4, 7 };

    int expected = 32;

    auto  result = sumFourDivisors(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1390::sumFourDivisors(std::vector<int> &nums) {
    int result = 0;

    for (auto num : nums)
    {
        double sq = std::sqrt(num);
        int divs = (int)sq * sq == num ? 1 : 0;
        int sum = (int)sq * divs;
        for (int i = 1; i < sq; ++i)
        {
            if (num % i == 0)
            {
                sum += i + num / i;
                divs += 2;
            }
        }

        if (divs == 4)
            result += sum;
    }

    return result;
}
