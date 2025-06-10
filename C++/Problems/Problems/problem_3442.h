#ifndef PROBLEM_3442_H
#define PROBLEM_3442_H

#include "../problem.h"
#include <string>

class problem_3442 : public problem
{
public:
    bool test() override;

    int maxDifference(std::string s);
};




#endif //PROBLEM_3442_H
