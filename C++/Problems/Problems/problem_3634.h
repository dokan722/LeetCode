#ifndef PROBLEM_3634_H
#define PROBLEM_3634_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3634 : public problem {
public:
    bool test() override;

    int minRemoval(std::vector<int>& nums, int k);
};

#endif //PROBLEM_3634_H
