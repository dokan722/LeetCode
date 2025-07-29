#ifndef PROBLEM_2411_H
#define PROBLEM_2411_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2411 : public problem {
public:
    bool test() override;

    std::vector<int> smallestSubarrays(std::vector<int>& nums);
private:
    std::vector<int> intToBit(int value);
};



#endif //PROBLEM_2411_H
