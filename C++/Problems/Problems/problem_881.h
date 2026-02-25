#ifndef PROBLEM_881_H
#define PROBLEM_881_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_881 : public problem {
public:
    bool test() override;

    int numRescueBoats(std::vector<int>& people, int limit);
};

#endif //PROBLEM_881_H
