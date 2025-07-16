#ifndef PROBLEM_461_H
#define PROBLEM_461_H


// SAME AS 2220
#include "../problem.h"
#include <vector>

class problem_461 : public problem {
public:
    bool test() override;

    int hammingDistance(int x, int y);
};



#endif //PROBLEM_461_H
