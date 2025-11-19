#ifndef PROBLEM_456_H
#define PROBLEM_456_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_456 : public problem {
public:
    bool test() override;

    bool find132pattern(std::vector<int>& nums);
};



#endif //PROBLEM_456_H
