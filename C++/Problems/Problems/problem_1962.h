#ifndef PROBLEM_1962_H
#define PROBLEM_1962_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1962 : public problem {
public:
    bool test() override;

    int minStoneSum(std::vector<int>& piles, int k);
};



#endif //PROBLEM_1962_H
