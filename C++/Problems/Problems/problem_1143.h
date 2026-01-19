#ifndef PROBLEMS_PROBLEM_1143_H
#define PROBLEMS_PROBLEM_1143_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1143 : public problem {
public:
    bool test() override;

    int longestCommonSubsequence(std::string text1, std::string text2);
};

#endif //PROBLEMS_PROBLEM_1143_H