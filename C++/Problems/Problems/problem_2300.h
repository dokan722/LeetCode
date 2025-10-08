#ifndef PROBLEM_2300_H
#define PROBLEM_2300_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2300 : public problem {
public:
    bool test() override;

    std::vector<int> successfulPairs(std::vector<int>& spells, std::vector<int>& potions, long long success);
};



#endif //PROBLEM_2300_H
