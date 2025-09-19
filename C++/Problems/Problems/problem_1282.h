#ifndef PROBLEM_1282_H
#define PROBLEM_1282_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1282 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> groupThePeople(std::vector<int>& groupSizes);
};



#endif //PROBLEM_1282_H
