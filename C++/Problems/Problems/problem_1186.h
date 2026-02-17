#ifndef PROBLEMS_PROBLEM_1186_H
#define PROBLEMS_PROBLEM_1186_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1186 : public problem {
public:
    bool test() override;

    int maximumSum(std::vector<int>& arr);
};

#endif //PROBLEMS_PROBLEM_1186_H