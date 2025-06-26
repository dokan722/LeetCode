#ifndef PROBLEM_1417_H
#define PROBLEM_1417_H



#include "../problem.h"
#include <string>

class problem_1417 : public problem {
public:
    bool test() override;

    std::string reformat(std::string s);
};



#endif //PROBLEM_1417_H
