#ifndef PROBLEM_3625_H
#define PROBLEM_3625_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3625 : public problem {
public:
    bool test() override;

    int countTrapezoids(std::vector<std::vector<int>>& points);
};

#endif //PROBLEM_3625_H
