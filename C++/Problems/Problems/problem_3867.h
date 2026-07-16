#ifndef PROBLEM3867_H
#define PROBLEM3867_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3867 : public problem {
public:
    bool test() override;

    long long gcdSum(std::vector<int>& nums);
private:
    int gcd(int a, int b);
};

#endif //PROBLEM3867_H
