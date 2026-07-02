#ifndef PROBLEM_2811_H
#define PROBLEM_2811_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2811 : public problem {
public:
    bool test() override;

    bool canSplitArray(std::vector<int>& nums, int m);
};

#endif //PROBLEM_2811_H
