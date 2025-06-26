//
// Created by peite on 26.06.2025.
//

#ifndef PROBLEM_2311_H
#define PROBLEM_2311_H



#include "../problem.h"
#include <string>

class problem_2311 : public problem {
public:
    bool test() override;

    int longestSubsequence(std::string s, int k);
};



#endif //PROBLEM_2311_H
