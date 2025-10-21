#ifndef PROBLEM_3346_H
#define PROBLEM_3346_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3346 : public problem {
public:
    bool test() override;

    int maxFrequency(std::vector<int>& nums, int k, int numOperations);
};



#endif //PROBLEM_3346_H
