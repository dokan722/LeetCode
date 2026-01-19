#ifndef PROBLEMS_PROBLEM_1292_H
#define PROBLEMS_PROBLEM_1292_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1292 : public problem {
public:
    bool test() override;

    int maxSideLength(std::vector<std::vector<int>>& mat, int threshold);
};

#endif //PROBLEMS_PROBLEM_1292_H