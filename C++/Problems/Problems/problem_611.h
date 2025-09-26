#ifndef PROBLEM_611_H
#define PROBLEM_611_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_611: public problem {
public:
    bool test() override;

    int triangleNumber(std::vector<int>& nums);
};



#endif //PROBLEM_611_H
