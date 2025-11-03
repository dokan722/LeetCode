#include "problem_1578.h"

bool problem_1578::test() {
    std::string colors = "abaac";

    std::vector neededTime { 1, 2, 3, 4, 5 };

    int expected = 3;

    auto result = minCost(colors, neededTime);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1578::minCost(std::string colors, std::vector<int> &neededTime) {
    int n = colors.size();
    int sum = neededTime[0];
    int maxTime = neededTime[0];
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        if (colors[i] != colors[i - 1])
        {
            if (sum != maxTime)
                result += sum - maxTime;
            sum = neededTime[i];
            maxTime = neededTime[i];
        }
        else
        {
            sum += neededTime[i];
            maxTime = std::max(maxTime, neededTime[i]);
        }
    }
    if (sum != maxTime)
        result += sum - maxTime;
    return result;
}
