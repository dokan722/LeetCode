#ifndef PROBLEM_2779_H
#define PROBLEM_2779_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2779: public problem {
public:
    bool test() override;

    int maximumBeauty(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2779_H
