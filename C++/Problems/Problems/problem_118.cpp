#include "problem_118.h"

bool problem_118::test() {
    int n = 5;

    std::vector<std::vector<int>> expected {  { 1 },  { 1,1 },  { 1,2,1 },  { 1,3,3,1 },  { 1,4,6,4,1 } };

    auto result = generate(n);

    return expected == result;
}

std::vector<std::vector<int>> problem_118::generate(int numRows) {
    std::vector<std::vector<int>> result;
    std::vector prev { 1 };
    result.push_back(prev);
    for (int i = 1; i < numRows; ++i)
    {
        std::vector row { 1 };
        for (int j = 0; j < prev.size() - 1; ++j)
            row.push_back(prev[j] + prev[j + 1]);
        row.push_back(1);
        result.push_back(row);
        prev = row;
    }

    return result;
}
