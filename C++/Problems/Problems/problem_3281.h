#ifndef PROBLEMS_PROBLEM_3281_H
#define PROBLEMS_PROBLEM_3281_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3281 : public problem {
public:
    bool test() override;

    int maxPossibleScore(std::vector<int>& start, int d);
};

#endif //PROBLEMS_PROBLEM_3281_H