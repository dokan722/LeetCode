#ifndef PROBLEM_645_H
#define PROBLEM_645_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_645 : public problem {
public:
    bool test() override;

    std::vector<int> findErrorNums(std::vector<int>& nums);
};



#endif //PROBLEM_645_H
