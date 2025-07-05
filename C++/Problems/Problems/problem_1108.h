#ifndef PROBLEM_1108_H
#define PROBLEM_1108_H

#include "../problem.h"
#include <string>

class problem_1108 : public problem {
public:
    bool test() override;

    std::string defangIPaddr(std::string address);
};



#endif //PROBLEM_1108_H
