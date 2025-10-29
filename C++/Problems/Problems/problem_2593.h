#ifndef PROBLEM_2593_H
#define PROBLEM_2593_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2593 : public problem {
public:
    bool test() override;

    long long findScore(std::vector<int>& nums);
};



#endif //PROBLEM_2593_H
