#ifndef PROBLEM_2435_H
#define PROBLEM_2435_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2435 : public problem {
public:
    bool test() override;

    int numberOfPaths(std::vector<std::vector<int>>& grid, int k);
};



#endif //PROBLEM_2435_H
