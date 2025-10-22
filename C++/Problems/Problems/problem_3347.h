#ifndef PROBLEM_3347_H
#define PROBLEM_3347_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3347 : public problem {
public:
    bool test() override;

    int maxFrequency(std::vector<int>& nums, int k, int numOperations);
};



#endif //PROBLEM_3347_H
