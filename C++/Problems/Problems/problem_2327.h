#ifndef PROBLEM_2327_H
#define PROBLEM_2327_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2327 : public problem {
public:
    bool test() override;

    int peopleAwareOfSecret(int n, int delay, int forget);
};



#endif //PROBLEM_2327_H
