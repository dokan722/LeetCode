#ifndef PROBLEM_3179_H
#define PROBLEM_3179_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3179 : public problem {
public:
    bool test() override;

    int valueAfterKSeconds(int n, int k);
};

#endif //PROBLEM_3179_H
