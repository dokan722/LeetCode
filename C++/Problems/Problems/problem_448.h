#ifndef PROBLEM_448_H
#define PROBLEM_448_H

#include "../problem.h"
#include <vector>

class problem_448 : public problem {
public:
    bool test() override;

    std::vector<int> findDisappearedNumbers(std::vector<int>& nums);
};



#endif //PROBLEM_448_H
