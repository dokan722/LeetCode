#ifndef PROBLEM_3005_H
#define PROBLEM_3005_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3005: public problem {
public:
    bool test() override;

    int maxFrequencyElements(std::vector<int>& nums);
};



#endif //PROBLEM_3005_H
