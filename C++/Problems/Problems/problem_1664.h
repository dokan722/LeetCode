#ifndef PROBLEM_1664_H
#define PROBLEM_1664_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1664 : public problem {
public:
    bool test() override;

    int waysToMakeFair(std::vector<int>& nums);
};



#endif //PROBLEM_1664_H
