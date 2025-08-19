#ifndef PROBLEM_1647_H
#define PROBLEM_1647_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1647 : public problem {
public:
    bool test() override;

    int minDeletions(std::string s);
};



#endif //PROBLEM_1647_H
