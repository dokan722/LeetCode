#ifndef PROBLEM_1957_H
#define PROBLEM_1957_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1957 : public problem {
public:
    bool test() override;

    std::string makeFancyString(std::string s);
};



#endif //PROBLEM_1957_H
