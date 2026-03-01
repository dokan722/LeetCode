#ifndef PROBLEM_826_H
#define PROBLEM_826_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_826 : public problem {
public:
    bool test() override;

    int maxProfitAssignment(std::vector<int>& difficulty, std::vector<int>& profit, std::vector<int>& worker);
};

#endif //PROBLEM_826_H
