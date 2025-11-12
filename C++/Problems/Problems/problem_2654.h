#ifndef PROBLEM_2654_H
#define PROBLEM_2654_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2654 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums);
private:
    int gcd(int a, int b);
};



#endif //PROBLEM_2654_H
