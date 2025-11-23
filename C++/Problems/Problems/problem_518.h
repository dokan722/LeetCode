#ifndef PROBLEM_518_H
#define PROBLEM_518_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_518 : public problem {
public:
    bool test() override;

    int change(int amount, std::vector<int>& coins);
};



#endif //PROBLEM_518_H
