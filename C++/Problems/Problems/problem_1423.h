#ifndef PROBLEMS_PROBLEM_1423_H
#define PROBLEMS_PROBLEM_1423_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1423 : public problem {
public:
    bool test() override;

    int maxScore(std::vector<int>& cardPoints, int k);
};

#endif //PROBLEMS_PROBLEM_1423_H