#ifndef PROBLEM_2419_H
#define PROBLEM_2419_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2419 : public problem {
public:
    bool test() override;

    int longestSubarray(std::vector<int>& nums);
};



#endif //PROBLEM_2419_H
