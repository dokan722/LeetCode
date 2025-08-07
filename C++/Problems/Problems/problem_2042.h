#ifndef PROBLEM_2042_H
#define PROBLEM_2042_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2042 : public problem {
public:
    bool test() override;

    bool areNumbersAscending(std::string s);
};



#endif //PROBLEM_2042_H
