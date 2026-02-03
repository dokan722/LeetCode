#ifndef PROBLEM_3637_H
#define PROBLEM_3637_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3637 : public problem {
public:
    bool test() override;

    bool isTrionic(std::vector<int>& nums);
};

#endif //PROBLEM_3637_H
