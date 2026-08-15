#ifndef PROBLEM_3137_H
#define PROBLEM_3137_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3137 : public problem {
public:
    bool test() override;

    int minimumOperationsToMakeKPeriodic(std::string word, int k);
};

#endif //PROBLEM_3137_H
