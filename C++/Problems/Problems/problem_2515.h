#ifndef PROBLEM_2515_H
#define PROBLEM_2515_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2515 : public problem {
public:
    bool test() override;

    int closestTarget(std::vector<std::string>& words, std::string target, int startIndex);
};

#endif //PROBLEM_2515_H
