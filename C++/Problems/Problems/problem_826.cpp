#include "problem_826.h"

bool problem_826::test() {
    std::vector difficulty {2, 4, 6, 8, 10};
    std::vector profit {10, 20, 30, 40, 50};
    std::vector worker { 4, 5, 6, 7 };

    int expected = 100;

    auto result = maxProfitAssignment(difficulty, profit, worker);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_826::maxProfitAssignment(std::vector<int> &difficulty, std::vector<int> &profit, std::vector<int> &worker) {
    int n = difficulty.size();
    int m = worker.size();
    int maxSkill = 0;
    for (int i = 0; i < m; ++i)
        maxSkill = std::max(maxSkill, worker[i]);
    std::vector bestJobs(maxSkill + 1, 0);
    for (int i = 0; i < n; ++i)
    {
        if (difficulty[i] <= maxSkill)
            bestJobs[difficulty[i]] = std::max(bestJobs[difficulty[i]], profit[i]);
    }
    int curr = 0;
    for (int i = 0; i <= maxSkill; ++i)
    {
        curr = std::max(curr, bestJobs[i]);
        bestJobs[i] = curr;
    }
    int result = 0;
    for (int i = 0; i < m; ++i)
        result += bestJobs[worker[i]];

    return result;
}
