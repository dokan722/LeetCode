#ifndef PROBLEM_3523_H
#define PROBLEM_3523_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3523 : public problem {
public:
    bool test() override;

    int maximumPossibleSize(std::vector<int>& nums);
};



#endif //PROBLEM_3523_H
