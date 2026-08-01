#ifndef PROBLEM_3890_H
#define PROBLEM_3890_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>
#include <cmath>
#include <unordered_map>

class problem_3890 : public problem {
public:
    bool test() override;

    std::vector<int> findGoodIntegers(int n);
};

#endif //PROBLEM_3890_H
