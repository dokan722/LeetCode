#ifndef PROBLEM_86_H
#define PROBLEM_86_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_85 : public problem {
public:
    bool test() override;

    int maximalRectangle(std::vector<std::vector<char>>& matrix);
};

#endif //PROBLEM_86_H
