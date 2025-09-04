#ifndef PROBLEM_1029_H
#define PROBLEM_1029_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1029 : public problem {
public:
    bool test() override;

    int twoCitySchedCost(std::vector<std::vector<int>>& costs);
};



#endif //PROBLEM_1029_H
