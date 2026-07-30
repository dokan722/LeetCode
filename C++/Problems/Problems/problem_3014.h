#ifndef PROBLEM_3014_H
#define PROBLEM_3014_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3014 : public problem {
public:
    bool test() override;

    int minimumPushes(std::string word) ;
};

#endif //PROBLEM_3014_H
