#include "problem_2545.h"

#include <algorithm>

bool problem_2545::test() {
    std::vector<std::vector<int>> score { { 10, 6, 9, 1 }, { 7, 5, 11, 2 }, { 4, 8, 3, 15 } };
    int k = 2;

    std::vector<std::vector<int>> expected { { 7, 5, 11, 2 }, { 10, 6, 9, 1 }, { 4, 8, 3, 15 } };

    auto result = sortTheStudents(score, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_2545::sortTheStudents(std::vector<std::vector<int>> &score, int k) {
    std::sort(score.begin(), score.end(), [k](std::vector<int> a, std::vector<int> b) { return a[k] > b[k]; });
    return score;
}
