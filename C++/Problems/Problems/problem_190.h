#ifndef PROBLEMS_PROBLEM_190_H
#define PROBLEMS_PROBLEM_190_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_190 : public problem {
public:
    bool test() override;

    int reverseBits(int n);
private:
    int reverseRec(int n, int l);
};

#endif //PROBLEMS_PROBLEM_190_H