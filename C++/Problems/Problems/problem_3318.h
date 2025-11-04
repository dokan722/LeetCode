#ifndef PROBLEM_3318_H
#define PROBLEM_3318_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3318 : public problem {
public:
    bool test() override;

    std::vector<int> findXSum(std::vector<int>& nums, int k, int x) ;
};



#endif //PROBLEM_3318_H
