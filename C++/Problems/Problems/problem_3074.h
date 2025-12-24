#ifndef PROBLEMS_PROBLEM_3074_H
#define PROBLEMS_PROBLEM_3074_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3074 : public problem {
public:
    bool test() override;

    int minimumBoxes(std::vector<int>& apple, std::vector<int>& capacity);
};

#endif //PROBLEMS_PROBLEM_3074_H