#include "problem_2140.h"

bool problem_2140::test() {
    std::vector<std::vector<int>> questions { {21,5}, { 92,3}, { 74,2}, { 39,4}, { 58,2}, { 5,5}, { 49,4}, {65,3} };

    int expected = 157;

    auto result = mostPoints(questions);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2140::mostPoints(std::vector<std::vector<int>> &questions) {
    int n = questions.size();
    long long result = 0;
    long long bestPrev = 0;
    std::vector<long long> dp(n, 0);
    for (int i = 0; i < n; ++i)
    {
        auto question = questions[i];
        bestPrev = std::max(bestPrev, dp[i]);
        long long curr = bestPrev + question[0];
        result = std::max(curr, result);
        int next = i + question[1] + 1;
        if (next < n)
            dp[next] = std::max(curr, dp[next]);
    }

    return result;
}
