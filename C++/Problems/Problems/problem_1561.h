#ifndef PROBLEM_1561_H
#define PROBLEM_1561_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1561 : public problem {
public:
    bool test() override;

    int maxCoins(std::vector<int>& piles);
};



#endif //PROBLEM_1561_H
