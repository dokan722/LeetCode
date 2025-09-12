#ifndef PROBLEM_3227_H
#define PROBLEM_3227_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3227 : public problem {
public:
    bool test() override;

    bool doesAliceWin(std::string s);
};



#endif //PROBLEM_3227_H
