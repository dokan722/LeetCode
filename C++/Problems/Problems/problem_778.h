#ifndef PROBLEM_778_H
#define PROBLEM_778_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_778 : public problem {
public:
    bool test() override;

    int swimInWater(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_778_H
