#ifndef PROBLEM_3498_H
#define PROBLEM_3498_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3498 : public problem {
public:
    bool test() override;

    int reverseDegree(std::string s);
};



#endif //PROBLEM_3498_H
