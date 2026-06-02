#ifndef PROBLEMS_PROBLEM_3633_H
#define PROBLEMS_PROBLEM_3633_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3633 : public problem {
public:
    bool test() override;

    int earliestFinishTime(std::vector<int>& landStartTime, std::vector<int>& landDuration, std::vector<int>& waterStartTime, std::vector<int>& waterDuration) ;
};

#endif //PROBLEMS_PROBLEM_3633_H