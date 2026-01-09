#ifndef PROBLEM_1753_H
#define PROBLEM_1753_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1753 : public problem {
public:
    bool test() override;

    int maximumScore(int a, int b, int c);
};

#endif //PROBLEM_1753_H
