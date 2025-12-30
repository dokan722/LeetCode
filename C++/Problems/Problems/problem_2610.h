#ifndef PROBLEMS_PROBLEM_2610_H
#define PROBLEMS_PROBLEM_2610_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2610 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> findMatrix(std::vector<int>& nums);
};


#endif //PROBLEMS_PROBLEM_2610_H