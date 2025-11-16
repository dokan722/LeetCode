#ifndef PROBLEM_1513_H
#define PROBLEM_1513_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1513 : public problem {
public:
    bool test() override;

    int numSub(std::string s);
};



#endif //PROBLEM_1513_H
