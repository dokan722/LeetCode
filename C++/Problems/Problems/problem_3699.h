#ifndef PROBLEM_3699_H
#define PROBLEM_3699_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_3699 : public problem {
public:
    bool test() override;

    int zigZagArrays(int n, int l, int r);
};

#endif //PROBLEM_3699_H
