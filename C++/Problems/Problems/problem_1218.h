#ifndef PROBLEM_1218_H
#define PROBLEM_1218_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1218 : public problem {
public:
    bool test() override;

    int longestSubsequence(std::vector<int>& arr, int difference);
};

#endif //PROBLEM_1218_H
