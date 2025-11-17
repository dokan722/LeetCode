#ifndef PROBLEM_1437_H
#define PROBLEM_1437_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1437 : public problem {
public:
    bool test() override;

    bool kLengthApart(std::vector<int>& nums, int k);
};



#endif //PROBLEM_1437_H
