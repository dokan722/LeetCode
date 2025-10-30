#ifndef PROBLEM_1526_H
#define PROBLEM_1526_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1526 : public problem {
public:
    bool test() override;

    int minNumberOperations(std::vector<int>& target);
};



#endif //PROBLEM_1526_H
