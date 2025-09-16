#ifndef PROBLEM_2197_H
#define PROBLEM_2197_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2197 : public problem {
public:
    bool test() override;

    std::vector<int> replaceNonCoprimes(std::vector<int>& nums);
private:
    int gcd(int a, int b);
};



#endif //PROBLEM_2197_H
