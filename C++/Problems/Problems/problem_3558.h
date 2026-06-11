#ifndef PROBLEM_3558_H
#define PROBLEM_3558_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3558 : public problem {
public:
    bool test() override;

    int assignEdgeWeights(std::vector<std::vector<int>>& edges);
};

#endif //PROBLEM_3558_H
