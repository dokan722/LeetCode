#include "problem_1792.h"

#include <queue>

bool problem_1792::test() {
    std::vector<std::vector<int>> classes {  { 583, 868 },  { 783, 822 },  { 65, 262 },  { 121, 508 },  { 461, 780 },  { 484, 668 } };
    int extraStudents = 8;

    double expected = 0.57472;

    auto result = maxAverageRatio(classes, extraStudents);

    std::cout << result << std::endl;

    return std::abs(expected - result) < 1e-5;
}

double problem_1792::maxAverageRatio(std::vector<std::vector<int>> &classes, int extraStudents) {
    int n = classes.size();
    std::priority_queue<std::pair<double, int>> profits;
    for (int i = 0; i < n; ++i)
        profits.push(std::pair((double)(classes[i][0] + 1) / (classes[i][1] + 1) - (double)classes[i][0] / classes[i][1], i));
    for (int i = 0; i < extraStudents; ++i)
    {
        auto best = profits.top();
        profits.pop();
        auto id = best.second;
        classes[id][0]++;
        classes[id][1]++;
        profits.push(std::pair((double)(classes[id][0] + 1) / (classes[id][1] + 1) - (double)classes[id][0] / classes[id][1], id));
    }

    double result = 0.0;
    for (int i = 0; i < n; ++i)
        result += (double)classes[i][0] / classes[i][1];

    return result / n;
}
