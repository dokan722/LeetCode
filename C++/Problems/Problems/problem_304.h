#ifndef PROBLEMS_PROBLEM_304_H
#define PROBLEMS_PROBLEM_304_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_304 : public problem {
public:
    bool test() override;
private:
    class NumMatrix {
    public:
        NumMatrix(std::vector<std::vector<int>>& matrix);

        int sumRegion(int row1, int col1, int row2, int col2);
    private:
        std::vector<std::vector<int>> _prefs;
    };
};

#endif //PROBLEMS_PROBLEM_304_H