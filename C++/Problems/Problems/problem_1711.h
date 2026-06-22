#ifndef PROBLEMS_PROBLEM_1711_H
#define PROBLEMS_PROBLEM_1711_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1711 : public problem {
public:
    bool test() override;

    int countPairs(std::vector<int>& deliciousness);
};

#endif //PROBLEMS_PROBLEM_1711_H