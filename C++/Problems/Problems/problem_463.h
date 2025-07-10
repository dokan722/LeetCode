#ifndef PROBLEM_463_H
#define PROBLEM_463_H

#include "../problem.h"
#include <vector>

class problem_463 : public problem {
public:
    bool test() override;

    int islandPerimeter(std::vector<std::vector<int>>& grid);
private:
    int checkCell(int i, int j, std::vector<std::vector<int>>& grid);
};



#endif //PROBLEM_463_H
