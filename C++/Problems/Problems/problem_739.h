#ifndef PROBLEM_739_H
#define PROBLEM_739_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_739: public problem {
public:
    bool test() override;

    std::vector<int> dailyTemperatures(std::vector<int>& temperatures);
};



#endif //PROBLEM_739_H
