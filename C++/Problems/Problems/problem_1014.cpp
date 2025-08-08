#include "problem_1014.h"

bool problem_1014::test() {
    std::vector values { 8, 1, 5, 2, 6 };

    auto expected = 11;

    auto result = maxScoreSightseeingPair(values);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1014::maxScoreSightseeingPair(std::vector<int> &values) {
    auto maxPrev = 0;
    auto result = INT_MIN;
    for (int i = 1; i < values.size(); i++)
    {
        auto dist = i - maxPrev;
        auto value = values[i] + values[maxPrev] - dist;
        if (value > result)
            result = value;
        if (values[maxPrev] - dist < values[i])
            maxPrev = i;
    }

    return result;
}
