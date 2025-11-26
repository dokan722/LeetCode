#ifndef PROBLEM_64_H
#define PROBLEM_64_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_64 : public problem {
public:
    bool test() override;

    int minPathSum(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_64_H
