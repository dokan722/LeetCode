#ifndef PROBLEMS_PROBLEM_978_H
#define PROBLEMS_PROBLEM_978_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_978 : public problem {
public:
    bool test() override;

    int maxTurbulenceSize(std::vector<int>& arr);
};

#endif //PROBLEMS_PROBLEM_978_H