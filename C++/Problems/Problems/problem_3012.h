#ifndef PROBLEM_3012_H
#define PROBLEM_3012_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3012 : public problem {
public:
    bool test() override;

    int minimumArrayLength(std::vector<int>& nums);
};

#endif //PROBLEM_3012_H
