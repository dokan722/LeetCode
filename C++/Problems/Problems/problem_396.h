#ifndef PROBLEM_396_H
#define PROBLEM_396_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_396: public problem {
public:
    bool test() override;

    int maxRotateFunction(std::vector<int>& nums);
};



#endif //PROBLEM_396_H
