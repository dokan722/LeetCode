#ifndef PROBLEM_3462_H
#define PROBLEM_3462_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3462 : public problem {
public:
    bool test() override;

    long long maxSum(std::vector<std::vector<int>>& grid, std::vector<int>& limits, int k);
};



#endif //PROBLEM_3462_H
