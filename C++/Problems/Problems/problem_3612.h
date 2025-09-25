#ifndef PROBLEM_3612_H
#define PROBLEM_3612_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3612: public problem {
public:
    bool test() override;

    std::string processStr(std::string s);
};



#endif //PROBLEM_3612_H
