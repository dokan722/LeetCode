#ifndef PROBLEM_1493_H
#define PROBLEM_1493_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1493 : public problem {
public:
    bool test() override;

    int longestSubarray(std::vector<int>& nums);
};



#endif //PROBLEM_1493_H
