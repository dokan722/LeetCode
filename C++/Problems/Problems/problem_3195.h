#ifndef PROBLEM_3195_H
#define PROBLEM_3195_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3195 : public problem {
public:
    bool test() override;

    int minimumArea(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_3195_H
