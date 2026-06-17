#ifndef PROBLEM_2645_H
#define PROBLEM_2645_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>

class problem_2645 : public problem {
public:
    bool test() override;

    int addMinimum(std::string word);
};

#endif //PROBLEM_2645_H
