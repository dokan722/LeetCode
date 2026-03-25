#ifndef PROBLEM_3861_H
#define PROBLEM_3861_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3861 : public problem {
public:
    bool test() override;

    int minimumIndex(std::vector<int>& capacity, int itemSize);
};

#endif //PROBLEM_3861_H
