#ifndef PROBLEMS_PROBLEM_2661_H
#define PROBLEMS_PROBLEM_2661_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2661 : public problem {
public:
    bool test() override;

    int firstCompleteIndex(std::vector<int>& arr, std::vector<std::vector<int>>& mat);
};

#endif //PROBLEMS_PROBLEM_2661_H