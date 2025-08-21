#ifndef PROBLEM_2124_H
#define PROBLEM_2124_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2124 : public problem {
public:
    bool test() override;

    bool checkString(std::string s);
};



#endif //PROBLEM_2124_H
