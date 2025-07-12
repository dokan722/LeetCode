#ifndef PROBLEM_2208_H
#define PROBLEM_2208_H

#include "../problem.h"
#include <vector>

class problem_2208 : public problem {
public:
    bool test() override;

    int halveArray(std::vector<int>& nums);
};



#endif //PROBLEM_2208_H
