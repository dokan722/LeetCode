#ifndef PROBLEM_1208_H
#define PROBLEM_1208_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1208 : public problem {
public:
    bool test() override;

    int equalSubstring(std::string s, std::string t, int maxCost);
};

#endif //PROBLEM_1208_H
