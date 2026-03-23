#ifndef PROBLEM_1594_H
#define PROBLEM_1594_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1594 : public problem {
public:
    bool test() override;

    int maxProductPath(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_1594_H
