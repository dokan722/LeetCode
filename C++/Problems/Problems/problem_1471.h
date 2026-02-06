#ifndef PROBLEM_1471_H
#define PROBLEM_1471_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1471 : public problem {
public:
    bool test() override;

    std::vector<int> getStrongest(std::vector<int>& arr, int k);
};

#endif //PROBLEM_1471_H
