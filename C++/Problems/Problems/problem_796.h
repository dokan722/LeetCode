#ifndef PROBLEMS_PROBLEM_796_H
#define PROBLEMS_PROBLEM_796_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_796 : public problem {
public:
    bool test() override;

    bool rotateString(std::string s, std::string goal);
};

#endif //PROBLEMS_PROBLEM_796_H