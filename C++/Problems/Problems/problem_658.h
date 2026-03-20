#ifndef PROBLEM_658_H
#define PROBLEM_658_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_658 : public problem {
public:
    bool test() override;

    std::vector<int> findClosestElements(std::vector<int>& arr, int k, int x);
};

#endif //PROBLEM_658_H
