#ifndef PROBLEMS_PROBLEM_2943_H
#define PROBLEMS_PROBLEM_2943_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_2943 : public problem {
public:
    bool test() override;

    int maximizeSquareHoleArea(int n, int m, std::vector<int>& hBars, std::vector<int>& vBars);
};

#endif //PROBLEMS_PROBLEM_2943_H