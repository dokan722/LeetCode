#ifndef PROBLEM_3115_H
#define PROBLEM_3115_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3115 : public problem {
public:
    bool test() override;

    int maximumPrimeDifference(std::vector<int>& nums);
};



#endif //PROBLEM_3115_H
