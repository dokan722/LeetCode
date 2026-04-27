#ifndef PROBLEMS_PROBLEM_3365_H
#define PROBLEMS_PROBLEM_3365_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3365 : public problem {
public:
    bool test() override;

    bool isPossibleToRearrange(std::string s, std::string t, int k);
};

#endif //PROBLEMS_PROBLEM_3365_H