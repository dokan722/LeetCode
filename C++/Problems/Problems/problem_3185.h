#ifndef PROBLEMS_PROBLEM_3185_H
#define PROBLEMS_PROBLEM_3185_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3185 : public problem {
public:
    bool test() override;

    long long countCompleteDayPairs(std::vector<int>& hours);
};

#endif //PROBLEMS_PROBLEM_3185_H