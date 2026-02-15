#ifndef PROBLEMS_PROBLEM_3290_H
#define PROBLEMS_PROBLEM_3290_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3290 : public problem {
public:
    bool test() override;

    long long maxScore(std::vector<int>& a, std::vector<int>& b);
};

#endif //PROBLEMS_PROBLEM_3290_H