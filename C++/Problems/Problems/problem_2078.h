#ifndef PROBLEM_2078_H
#define PROBLEM_2078_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2078 : public problem {
public:
    bool test() override;

    int maxDistance(std::vector<int>& colors);
};

#endif //PROBLEM_2078_H
