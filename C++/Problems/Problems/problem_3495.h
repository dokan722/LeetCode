#ifndef PROBLEM_3495_H
#define PROBLEM_3495_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3495 : public problem {
public:
    bool test() override;

    long long minOperations(std::vector<std::vector<int>>& queries);
};



#endif //PROBLEM_3495_H
