#ifndef PROBLEMS_PROBLEM_1033_H
#define PROBLEMS_PROBLEM_1033_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1033 : public problem {
public:
    bool test() override;

    std::vector<int> numMovesStones(int a, int b, int c);
};

#endif //PROBLEMS_PROBLEM_1033_H