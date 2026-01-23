#ifndef PROBLEM_2186_H
#define PROBLEM_2186_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2186 : public problem {
public:
    bool test() override;

    int minSteps(std::string s, std::string t);
};

#endif //PROBLEM_2186_H
