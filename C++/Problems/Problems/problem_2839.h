#ifndef PROBLEMS_PROBLEM_2839_H
#define PROBLEMS_PROBLEM_2839_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2839 : public problem {
public:
    bool test() override;

    bool canBeEqual(std::string s1, std::string s2);
};

#endif //PROBLEMS_PROBLEM_2839_H