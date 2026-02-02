#ifndef PROBLEMS_PROBLEM_892_H
#define PROBLEMS_PROBLEM_892_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_892 : public problem {
public:
    bool test() override;

    int surfaceArea(std::vector<std::vector<int>>& grid) ;
};

#endif //PROBLEMS_PROBLEM_892_H