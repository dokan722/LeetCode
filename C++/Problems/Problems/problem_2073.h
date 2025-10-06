#ifndef PROBLEM_2073_H
#define PROBLEM_2073_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2073 : public problem {
public:
    bool test() override;

    int timeRequiredToBuy(std::vector<int>& tickets, int k);
};



#endif //PROBLEM_2073_H
