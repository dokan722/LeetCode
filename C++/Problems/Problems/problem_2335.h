#ifndef PROBLEM_2335_H
#define PROBLEM_2335_H

#include "../problem.h"
#include <vector>

class problem_2335 : public problem {
public:
    bool test() override;

    int fillCups(std::vector<int>& amount);
};



#endif //PROBLEM_2335_H
