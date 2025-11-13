#ifndef PROBLEM_3228_H
#define PROBLEM_3228_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3228 : public problem {
public:
    bool test() override;

    int maxOperations(std::string s);
};



#endif //PROBLEM_3228_H
