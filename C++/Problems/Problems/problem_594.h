#ifndef PROBLEM_594_H
#define PROBLEM_594_H



#include "../problem.h"
#include <vector>

class problem_594 : public problem {
public:
    bool test() override;

    int findLHS(std::vector<int>& nums) ;
};



#endif //PROBLEM_594_H
