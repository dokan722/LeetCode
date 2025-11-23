#ifndef PROBLEM_2162_H
#define PROBLEM_2162_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2162 : public problem {
public:
    bool test() override;

    int maxSumDivThree(std::vector<int>& nums);
};



#endif //PROBLEM_2162_H
