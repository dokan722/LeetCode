#ifndef PROBLEMS_PROBLEM_916_H
#define PROBLEMS_PROBLEM_916_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_916 : public problem {
public:
    bool test() override;

    std::vector<std::string> wordSubsets(std::vector<std::string>& words1, std::vector<std::string>& words2);
};

#endif //PROBLEMS_PROBLEM_916_H