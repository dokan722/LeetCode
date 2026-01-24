#ifndef PROBLEM_1685_H
#define PROBLEM_1685_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_1685 : public problem {
public:
    bool test() override;

    std::vector<int> getSumAbsoluteDifferences(std::vector<int>& nums);
};

#endif //PROBLEM_1685_H
