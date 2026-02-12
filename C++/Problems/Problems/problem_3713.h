#ifndef PROBLEMS_PROBLEM_3713_H
#define PROBLEMS_PROBLEM_3713_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3713 : public problem {
public:
    bool test() override;

    int longestBalanced(std::string s);
};

#endif //PROBLEMS_PROBLEM_3713_H