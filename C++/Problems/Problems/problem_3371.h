#ifndef PROBLEM_3371_H
#define PROBLEM_3371_H



#include "../problem.h"
#include <vector>

class problem_3371 : public problem {
public:
    bool test() override;

    int getLargestOutlier(std::vector<int>& nums);
};



#endif //PROBLEM_3371_H
