#ifndef PROBLEM_120_H
#define PROBLEM_120_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_120: public problem {
public:
    bool test() override;

    int minimumTotal(std::vector<std::vector<int>>& triangle);
};



#endif //PROBLEM_120_H
