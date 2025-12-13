#ifndef PROBLEMS_PROBLEM_2414_H
#define PROBLEMS_PROBLEM_2414_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_2414 : public problem {
public:
    bool test() override;

    int longestContinuousSubstring(std::string s);
};

#endif //PROBLEMS_PROBLEM_2414_H