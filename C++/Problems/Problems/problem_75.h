#ifndef PROBLEM_75_H
#define PROBLEM_75_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_75 : public problem {
public:
    bool test() override;

    void sortColors(std::vector<int>& nums);
};

#endif //PROBLEM_75_H
