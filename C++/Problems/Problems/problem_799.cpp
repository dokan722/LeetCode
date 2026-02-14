#include "problem_799.h"

bool problem_799::test() {
    int poured = 100000009;
    int query_row = 33;
    int query_glass = 17;

    double expected = 1.0;

    auto result = champagneTower(poured, query_row, query_glass);

    std::cout << result << std::endl;

    return std::abs(expected - result) < 1e-5;
}

double problem_799::champagneTower(int poured, int query_row, int query_glass) {
    std::vector<double> row(1);
    row[0] = poured;
    for (int i = 1; i <= query_row; ++i)
    {
        std::vector<double> currRow(i + 1);
        currRow[0] = std::max(0.0, (row[0] - 1) / 2);
        currRow[i] = std::max(0.0, (row[i - 1] - 1) / 2);
        for (int j = 1; j < i; ++j)
            currRow[j] = std::max(0.0, (std::max(0.0, row[j - 1] - 1) + std::max(0.0, row[j] - 1)) / 2);
        row = currRow;
    }

    return std::min(1.0, row[query_glass]);
}
