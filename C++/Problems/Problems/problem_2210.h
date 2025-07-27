#ifndef PROBLEM2210_H
#define PROBLEM2210_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2210 : public problem {
public:
    bool test() override;

    int countHillValley(std::vector<int>& nums);
};



#endif //PROBLEM2210_H
