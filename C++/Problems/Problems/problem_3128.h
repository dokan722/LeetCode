#ifndef PROBLEM_3128_H
#define PROBLEM_3128_H

#include "../problem.h"
#include <vector>

class problem_3128 : public problem {
public:
    bool test() override;

    long long numberOfRightTriangles(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_3128_H
