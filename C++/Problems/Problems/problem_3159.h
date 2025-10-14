#ifndef PROBLEM_3159_H
#define PROBLEM_3159_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3159 : public problem {
public:
    bool test() override;

    std::vector<int> occurrencesOfElement(std::vector<int>& nums, std::vector<int>& queries, int x);
};



#endif //PROBLEM_3159_H
