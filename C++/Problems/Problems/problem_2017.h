#ifndef PROBLEM_2017_H
#define PROBLEM_2017_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2017 : public problem {
public:
    bool test() override;

    long long gridGame(std::vector<std::vector<int>>& grid);
};
#endif //PROBLEM_2017_H
