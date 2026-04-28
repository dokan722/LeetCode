#ifndef PROBLEM_678_H
#define PROBLEM_678_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_678 : public problem {
public:
    bool test() override;

    bool checkValidString(std::string s);
};

#endif //PROBLEM_678_H
