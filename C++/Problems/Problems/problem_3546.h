#ifndef PROBLEM_3546_H
#define PROBLEM_3546_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3546 : public problem {
public:
    bool test() override;

    bool canPartitionGrid(std::vector<std::vector<int>>& grid) ;
};

#endif //PROBLEM_3546_H
