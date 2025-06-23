#ifndef PROBLEM_2081_H
#define PROBLEM_2081_H


#include <string>

#include "../problem.h"


class problem_2081 : public problem {
public:
    bool test() override;

    long long kMirror(int k, int n);
private:
    bool IsPalindrome(std::string s);
    std::string ConvertToBaseReversed(long long n, long long b);
};




#endif //PROBLEM_2081_H
