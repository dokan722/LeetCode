#ifndef PROBLEM_2402_H
#define PROBLEM_2402_H

#include "../problem.h"
#include <vector>

class problem_2402 : public problem {
public:
    bool test() override;

    int mostBooked(int n, std::vector<std::vector<int>>& meetings);
};



#endif //PROBLEM_2402_H
