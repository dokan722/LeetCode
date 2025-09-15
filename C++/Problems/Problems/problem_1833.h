#ifndef PROBLEM_1833_H
#define PROBLEM_1833_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1833 : public problem {
public:
    bool test() override;

    int maxIceCream(std::vector<int>& costs, int coins);
};



#endif //PROBLEM_1833_H
