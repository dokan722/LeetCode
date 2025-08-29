#ifndef PROBLEM_3021_H
#define PROBLEM_3021_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3021 : public problem {
public:
    bool test() override;

    long long flowerGame(int n, int m);
};



#endif //PROBLEM_3021_H
