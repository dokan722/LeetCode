#ifndef PROBLEM_2528_H
#define PROBLEM_2528_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2528 : public problem {
public:
    bool test() override;

    long long maxPower(std::vector<int>& stations, int r, int k);
};



#endif //PROBLEM_2528_H
