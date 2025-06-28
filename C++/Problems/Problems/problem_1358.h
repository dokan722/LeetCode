#ifndef PROBLEM_1358_H
#define PROBLEM_1358_H

#include "../problem.h"
#include <string>

class problem_1358 : public problem {
public:
    bool test() override;

    int numberOfSubstrings(std::string s);
};



#endif //PROBLEM_1358_H
