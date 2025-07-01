#ifndef PROBLEM_1920_H
#define PROBLEM_1920_H

#include "../problem.h"
#include <vector>

class problem_1920 : public problem {
public:
    bool test() override;

    std::vector<int> buildArray(std::vector<int>& nums);
};



#endif //PROBLEM_1920_H
