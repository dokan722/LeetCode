#ifndef PROBLEM_1247_H
#define PROBLEM_1247_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1247 : public problem {
public:
    bool test() override;

    int minimumSwap(std::string s1, std::string s2);
};



#endif //PROBLEM_1247_H
