#ifndef PROBLEM_2006_H
#define PROBLEM_2006_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2006 : public problem {
public:
    bool test() override;

    int countKDifference(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2006_H
