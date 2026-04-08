#ifndef PROBLEM_1299_H
#define PROBLEM_1299_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1299 : public problem {
public:
    bool test() override;

    std::vector<int> replaceElements(std::vector<int>& arr);
};

#endif //PROBLEM_1299_H
