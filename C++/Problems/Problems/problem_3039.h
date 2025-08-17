#ifndef PROBLEM_3039_H
#define PROBLEM_3039_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3039 : public problem {
public:
    bool test() override;

    std::string lastNonEmptyString(std::string s);
};



#endif //PROBLEM_3039_H
