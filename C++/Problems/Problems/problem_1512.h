#ifndef PROBLEM_1512_H
#define PROBLEM_1512_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1512 : public problem {
public:
    bool test() override;

    int numIdenticalPairs(std::vector<int>& nums);
};



#endif //PROBLEM_1512_H
