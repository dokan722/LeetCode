#ifndef PROBLEM_153_H
#define PROBLEM_153_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_153 : public problem {
public:
    bool test() override;

    int findMin(std::vector<int>& nums);
};



#endif //PROBLEM_153_H
