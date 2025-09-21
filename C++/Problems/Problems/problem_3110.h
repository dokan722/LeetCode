#ifndef PROBLEM_3110_H
#define PROBLEM_3110_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3110: public problem {
public:
    bool test() override;

    int scoreOfString(std::string s);
};



#endif //PROBLEM_3110_H
