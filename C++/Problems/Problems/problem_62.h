#ifndef PROBLEMS_PROBLEM_62_H
#define PROBLEMS_PROBLEM_62_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_62 : public problem {
public:
    bool test() override;

    int uniquePaths(int m, int n);
};

#endif //PROBLEMS_PROBLEM_62_H