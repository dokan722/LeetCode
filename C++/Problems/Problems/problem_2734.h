#ifndef PROBLEM_2734_H
#define PROBLEM_2734_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_2734 : public problem {
public:
    bool test() override;

    std::string smallestString(std::string s);
};


#endif //PROBLEM_2734_H
