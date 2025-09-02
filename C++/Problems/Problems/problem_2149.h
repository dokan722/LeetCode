#ifndef PROBLEM_2149_H
#define PROBLEM_2149_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2149 : public problem {
public:
    bool test() override;

    std::vector<int> rearrangeArray(std::vector<int>& nums);
};



#endif //PROBLEM_2149_H
