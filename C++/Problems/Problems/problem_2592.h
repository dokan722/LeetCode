#ifndef PROBLEM_2592_H
#define PROBLEM_2592_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2592 : public problem {
public:
    bool test() override;

    int maximizeGreatness(std::vector<int>& nums);
};



#endif //PROBLEM_2592_H
