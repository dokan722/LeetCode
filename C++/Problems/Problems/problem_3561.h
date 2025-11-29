#ifndef PROBLEM_3561_H
#define PROBLEM_3561_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3561 : public problem {
public:
    bool test() override;

    std::string resultingString(std::string s);
};


#endif //PROBLEM_3561_H
