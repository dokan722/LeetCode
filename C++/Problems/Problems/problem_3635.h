#ifndef PROBLEMS_PROBLEM_3635_H
#define PROBLEMS_PROBLEM_3635_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_3635 : public problem {
public:
    bool test() override;

    int earliestFinishTime(std::vector<int>& landStartTime, std::vector<int>& landDuration, std::vector<int>& waterStartTime, std::vector<int>& waterDuration) ;
};

#endif //PROBLEMS_PROBLEM_3635_H