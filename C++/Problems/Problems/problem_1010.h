#ifndef PROBLEM_1010_H
#define PROBLEM_1010_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1010 : public problem {
public:
    bool test() override;

    int numPairsDivisibleBy60(std::vector<int>& time);
};



#endif //PROBLEM_1010_H
