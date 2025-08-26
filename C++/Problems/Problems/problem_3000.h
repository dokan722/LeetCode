#ifndef PROBLEM_3000_H
#define PROBLEM_3000_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3000 : public problem {
public:
    bool test() override;

    int areaOfMaxDiagonal(std::vector<std::vector<int>>& dimensions);
};



#endif //PROBLEM_3000_H
