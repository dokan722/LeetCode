#ifndef PROBLEM_948_H
#define PROBLEM_948_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_948 : public problem {
public:
    bool test() override;

    int bagOfTokensScore(std::vector<int>& tokens, int power);
};

#endif //PROBLEM_948_H
