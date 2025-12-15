#ifndef PROBLEMS_PROBLEM_945_H
#define PROBLEMS_PROBLEM_945_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_945 : public problem {
public:
    bool test() override;

    int minIncrementForUnique(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_945_H