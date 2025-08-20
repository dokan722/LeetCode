#ifndef PROBLEM_1277_H
#define PROBLEM_1277_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1277 : public problem {
public:
    bool test() override;

    int countSquares(std::vector<std::vector<int>>& matrix);
};



#endif //PROBLEM_1277_H
