#ifndef PROBLEM_1605_H
#define PROBLEM_1605_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1605 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> restoreMatrix(std::vector<int>& rowSum, std::vector<int>& colSum);
};



#endif //PROBLEM_1605_H
