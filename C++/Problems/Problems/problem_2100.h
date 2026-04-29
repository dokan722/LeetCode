#ifndef PROBLEM_2100_H
#define PROBLEM_2100_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2100 : public problem {
public:
    bool test() override;

    std::vector<int> goodDaysToRobBank(std::vector<int>& security, int time);
};

#endif //PROBLEM_2100_H
