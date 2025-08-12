#ifndef PROBLEM_2787_H
#define PROBLEM_2787_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2787 : public problem {
public:
    bool test() override;

    int numberOfWays(int n, int x);
};



#endif //PROBLEM_2787_H
