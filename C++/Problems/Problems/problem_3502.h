#ifndef PROBLEM_3502_H
#define PROBLEM_3502_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3502 : public problem {
public:
    bool test() override;

    std::vector<int> minCosts(std::vector<int>& cost);
};

#endif //PROBLEM_3502_H
