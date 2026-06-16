#ifndef PROBLEM_3122_H
#define PROBLEM_3122_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_3122 : public problem {
public:
    bool test() override;

    int minimumOperations(std::vector<std::vector<int>>& grid);
};

#endif //PROBLEM_3122_H
