#ifndef PROBLEM_3913_H
#define PROBLEM_3913_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3913 : public problem {
public:
    bool test() override;

    std::string sortVowels(std::string s);
};

#endif //PROBLEM_3913_H
