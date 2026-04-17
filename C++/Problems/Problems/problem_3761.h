#ifndef PROBLEM_3761_H
#define PROBLEM_3761_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3761 : public problem {
public:
    bool test() override;

    int minMirrorPairDistance(std::vector<int>& nums);
};

#endif //PROBLEM_3761_H
