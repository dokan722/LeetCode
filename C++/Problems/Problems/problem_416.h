#ifndef PROBLEM_416_H
#define PROBLEM_416_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_416 : public problem {
public:
    bool test() override;

    bool canPartition(std::vector<int>& nums);
};

#endif //PROBLEM_416_H
