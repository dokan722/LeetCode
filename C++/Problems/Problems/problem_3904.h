#ifndef PROBLEM_3904_H
#define PROBLEM_3904_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_3904 : public problem {
public:
    bool test() override;

    int firstStableIndex(std::vector<int>& nums, int k) ;
};

#endif //PROBLEM_3904_H
