#ifndef PROBLEM_3201_H
#define PROBLEM_3201_H

#include "../problem.h"
#include <vector>

class problem_3201 : public problem {
public:
    bool test() override;

    int maximumLength(std::vector<int>& nums);
};



#endif //PROBLEM_3201_H
