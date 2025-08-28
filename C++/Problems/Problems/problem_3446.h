#ifndef PROBLEM_3446_H
#define PROBLEM_3446_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3446 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> sortMatrix(std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_3446_H
