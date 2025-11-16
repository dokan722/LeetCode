#ifndef PROBLEM_1975_H
#define PROBLEM_1975_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1975 : public problem {
public:
    bool test() override;

    long long maxMatrixSum(std::vector<std::vector<int>>& matrix);
};



#endif //PROBLEM_1975_H
