#ifndef PROBLEM_498_H
#define PROBLEM_498_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_498 : public problem {
public:
    bool test() override;

    std::vector<int> findDiagonalOrder(std::vector<std::vector<int>>& mat);
};



#endif //PROBLEM_498_H
