#ifndef PROBLEMS_PROBLEM_2678_H
#define PROBLEMS_PROBLEM_2678_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2678 : public problem {
public:
    bool test() override;

    int countSeniors(std::vector<std::string>& details);
};

#endif //PROBLEMS_PROBLEM_2678_H