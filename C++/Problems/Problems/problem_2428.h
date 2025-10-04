#ifndef PROBLEM_2428_H
#define PROBLEM_2428_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2428 : public problem {
public:
    bool test() override;

    int maxSum(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_2428_H
