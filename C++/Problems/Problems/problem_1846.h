#ifndef PROBLEM_1846_H
#define PROBLEM_1846_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1846 : public problem {
public:
    bool test() override;

    int maximumElementAfterDecrementingAndRearranging(std::vector<int>& arr);
};

#endif //PROBLEM_1846_H
