#ifndef PROBLEMS_PROBLEM_2606_H
#define PROBLEMS_PROBLEM_2606_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_2606 : public problem {
public:
    bool test() override;

    int maximumCostSubstring(std::string s, std::string chars, std::vector<int>& vals);
};

#endif //PROBLEMS_PROBLEM_2606_H