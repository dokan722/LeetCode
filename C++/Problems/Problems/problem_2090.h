#ifndef PROBLEM_2090_H
#define PROBLEM_2090_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2090 : public problem {
public:
    bool test() override;

    std::vector<int> getAverages(std::vector<int>& nums, int k);
};

#endif //PROBLEM_2090_H
