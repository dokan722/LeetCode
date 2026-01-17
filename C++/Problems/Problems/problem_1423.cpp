#include "problem_1423.h"

bool problem_1423::test() {
    std::vector cardPoints { 1, 2, 3, 4, 5, 6, 1 };
    int k = 3;

    int expected = 12;

    auto result = maxScore(cardPoints, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1423::maxScore(std::vector<int> &cardPoints, int k) {
    int n = cardPoints.size();
    int curr = 0;
    for (int i = 0; i < k; ++i)
        curr += cardPoints[i];
    int result = curr;
    for (int i = 0; i < k; ++i)
    {
        curr += cardPoints[n - 1 - i] - cardPoints[k - 1 - i];
        result = std::max(result, curr);
    }

    return result;
}
