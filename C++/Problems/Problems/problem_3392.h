#ifndef PROBLEM_3392_H
#define PROBLEM_3392_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3392 : public problem {
public:
    bool test() override;

    int countSubarrays(std::vector<int>& nums);
};



#endif //PROBLEM_3392_H
