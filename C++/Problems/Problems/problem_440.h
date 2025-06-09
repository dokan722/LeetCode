#ifndef PROBLEM_440_H
#define PROBLEM_440_H

#include "../problem.h"

class problem_440 : public problem
{
public:
    bool test() override;

    int findKthNumber(int n, int k);
private:
    long countSteps(long n, long long p1, long long p2);
};



#endif //PROBLEM_440_H
