#ifndef PROBLEM_3577_H
#define PROBLEM_3577_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3577 : public problem {
public:
    bool test() override;

    int countPermutations(std::vector<int>& complexity);
};

#endif //PROBLEM_3577_H
