#ifndef PROBLEMS_PROBLEM_3741_H
#define PROBLEMS_PROBLEM_3741_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3741 : public problem {
public:
    bool test() override;

    int minimumDistance(std::vector<int>& nums);
};

#endif //PROBLEMS_PROBLEM_3741_H