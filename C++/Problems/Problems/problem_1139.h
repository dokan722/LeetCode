#ifndef PROBLEM_1139_H
#define PROBLEM_1139_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1139 : public problem {
public:
    bool test() override;

    int largest1BorderedSquare(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_1139_H
