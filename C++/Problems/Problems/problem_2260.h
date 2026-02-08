#ifndef PROBLEM_2260_H
#define PROBLEM_2260_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2260 : public problem {
public:
    bool test() override;

    int minimumCardPickup(std::vector<int>& cards);
};

#endif //PROBLEM_2260_H
