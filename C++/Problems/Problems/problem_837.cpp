#include "problem_837.h"

bool problem_837::test() {
    int n = 21;
    int k = 17;
    int maxPts = 10;

    double expected = 0.73278;

    auto result = new21Game(n, k, maxPts);

    std::cout << result << std::endl;

    return std::abs(expected - result) < 1e-5;
}

double problem_837::new21Game(int n, int k, int maxPts) {
    std::vector probs(n + 1, 0.0);
    probs[0] = 1;
    auto sumProb = 0.0;
    for (int i = 1; i <= n; ++i)
    {
        auto start = i - maxPts - 1;
        if (start < k && start >= 0)
            sumProb -= probs[start] / maxPts;
        if (i <= k)
            sumProb += probs[i - 1] / maxPts;
        probs[i] = sumProb;
    }

    auto result = 0.0;
    for (int i = k; i <= n; ++i)
        result += probs[i];

    return result;
}
