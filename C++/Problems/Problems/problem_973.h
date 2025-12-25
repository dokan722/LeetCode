#ifndef PROBLEM_973_H
#define PROBLEM_973_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_973 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> kClosest(std::vector<std::vector<int>>& points, int k);
};

#endif //PROBLEM_973_H
