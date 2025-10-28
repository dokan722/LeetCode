#ifndef PROBLEM_1492_H
#define PROBLEM_1492_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1492 : public problem {
public:
    bool test() override;

    int kthFactor(int n, int k);
};



#endif //PROBLEM_1492_H
