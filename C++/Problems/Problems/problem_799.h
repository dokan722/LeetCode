#ifndef PROBLEMS_PROBLEM_799_H
#define PROBLEMS_PROBLEM_799_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_799 : public problem {
public:
    bool test() override;

    double champagneTower(int poured, int query_row, int query_glass);
};

#endif //PROBLEMS_PROBLEM_799_H