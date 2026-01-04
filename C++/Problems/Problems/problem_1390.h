#ifndef PROBLEMS_PROBLEM_1390_H
#define PROBLEMS_PROBLEM_1390_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1390 : public problem {
public:
    bool test() override;

    int sumFourDivisors(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_1390_H