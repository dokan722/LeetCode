#ifndef PROBLEM_442_H
#define PROBLEM_442_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_442 : public problem {
public:
    bool test() override;

    std::vector<int> findDuplicates(std::vector<int>& nums) ;
};

#endif //PROBLEM_442_H
