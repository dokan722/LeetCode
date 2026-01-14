#ifndef PROBLEM_2225_H
#define PROBLEM_2225_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2225 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> findWinners(std::vector<std::vector<int>>& matches);
};

#endif //PROBLEM_2225_H
