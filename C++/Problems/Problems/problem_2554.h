#ifndef PROBLEM_2554_H
#define PROBLEM_2554_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2554 : public problem {
public:
    bool test() override;

    int maxCount(std::vector<int>& banned, int n, int maxSum);
};



#endif //PROBLEM_2554_H
