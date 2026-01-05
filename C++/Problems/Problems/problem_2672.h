#ifndef PROBLEMS_PROBLEM_2672_H
#define PROBLEMS_PROBLEM_2672_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2672 : public problem {
public:
    bool test() override;

    std::vector<int> colorTheArray(int n, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEMS_PROBLEM_2672_H