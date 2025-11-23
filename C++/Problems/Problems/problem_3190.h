#ifndef PROBLEM_3190_H
#define PROBLEM_3190_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3190 : public problem {
public:
    bool test() override;

    int minimumOperations(std::vector<int>& nums);
};



#endif //PROBLEM_3190_H
