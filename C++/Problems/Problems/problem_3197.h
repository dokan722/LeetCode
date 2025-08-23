#ifndef PROBLEM_3197_H
#define PROBLEM_3197_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3197 : public problem {
public:
    bool test() override;

    int minimumSum(std::vector<std::vector<int>>& grid);
private:
    int minimumArea(std::vector<std::vector<int>>& grid, int topB, int botB, int leftB, int rightB);
};



#endif //PROBLEM_3197_H
