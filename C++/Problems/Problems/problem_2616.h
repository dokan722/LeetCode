#ifndef PROBLEM_2616_H
#define PROBLEM_2616_H

#include <vector>

#include "../problem.h"

class problem_2616 : public problem {
public:
    bool test() override;

    int minimizeMax(std::vector<int>& nums, int p);
private:
    int countDiffs(std::vector<int>& nums, int maxDiff);
};



#endif //PROBLEM_2616_H
