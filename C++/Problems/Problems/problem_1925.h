#ifndef PROBLEMS_PROBLEM_1925_H
#define PROBLEMS_PROBLEM_1925_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1925 : public problem {
public:
    bool test() override;

    int countTriples(int n);
};

#endif //PROBLEMS_PROBLEM_1925_H