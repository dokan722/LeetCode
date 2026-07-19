#ifndef PROBLEM_2391_H
#define PROBLEM_2391_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2391 : public problem {
public:
    bool test() override;

    int garbageCollection(std::vector<std::string>& garbage, std::vector<int>& travel);
};

#endif //PROBLEM_2391_H
