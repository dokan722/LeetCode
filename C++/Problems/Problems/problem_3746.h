#ifndef PROBLEMS_PROBLEM_3746_H
#define PROBLEMS_PROBLEM_3746_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3746 : public problem {
public:
    bool test() override;

    int minLengthAfterRemovals(std::string s);
};

#endif //PROBLEMS_PROBLEM_3746_H