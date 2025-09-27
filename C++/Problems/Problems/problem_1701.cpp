#include "problem_1701.h"

bool problem_1701::test() {
    std::vector<std::vector<int>> customers {  { 5, 2 },  { 5, 4 },  { 10, 3 },  { 20, 1 } };

    double expected = 3.25;

    auto result = averageWaitingTime(customers);

    std::cout << result << std::endl;

    return std::abs(expected - result) < 1e-5;
}

double problem_1701::averageWaitingTime(std::vector<std::vector<int>> &customers) {
    int n = customers.size();
    int cTime = 0;
    long long totalWait = 0;
    for (auto customer : customers)
    {
        cTime = std::max(cTime, customer[0]);
        cTime += customer[1];
        totalWait += cTime - customer[0];
    }

    return totalWait / (double)n;
}
