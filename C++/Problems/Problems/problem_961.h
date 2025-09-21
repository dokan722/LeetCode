#ifndef PROBLEM_961_H
#define PROBLEM_961_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_961: public problem {
public:
    bool test() override;

    int repeatedNTimes(std::vector<int>& nums);
};



#endif //PROBLEM_961_H
