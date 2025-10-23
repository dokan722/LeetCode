#ifndef PROBLEM_1689_H
#define PROBLEM_1689_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1689 : public problem {
public:
    bool test() override;

    int minPartitions(std::string n);
};



#endif //PROBLEM_1689_H
