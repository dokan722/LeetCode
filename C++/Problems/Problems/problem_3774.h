#ifndef PROBLEMS_PROBLEM_3774_H
#define PROBLEMS_PROBLEM_3774_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3774 : public problem {
public:
    bool test() override;

    int absDifference(std::vector<int>& nums, int k);
};

#endif //PROBLEMS_PROBLEM_3774_H