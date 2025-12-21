#ifndef PROBLEMS_PROBLEM_3285_H
#define PROBLEMS_PROBLEM_3285_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3285 : public problem {
public:
    bool test() override;

    std::vector<int> stableMountains(std::vector<int>& height, int threshold);
};

#endif //PROBLEMS_PROBLEM_3285_H