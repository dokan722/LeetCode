#ifndef PROBLEM_1400_H
#define PROBLEM_1400_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_1400 : public problem {
public:
    bool test() override;

    bool canConstruct(std::string s, int k);
};

#endif //PROBLEM_1400_H
