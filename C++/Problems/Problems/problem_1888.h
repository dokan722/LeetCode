#ifndef PROBLEM_1888_H
#define PROBLEM_1888_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1888 : public problem {
public:
    bool test() override;

    int minFlips(std::string s);
};

#endif //PROBLEM_1888_H
