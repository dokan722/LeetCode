#ifndef PROBLEM_3499_H
#define PROBLEM_3499_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3499 : public problem {
public:
    bool test() override;

    int maxActiveSectionsAfterTrade(std::string s);
};
#endif //PROBLEM_3499_H
