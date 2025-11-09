#ifndef PROBLEM_2169_H
#define PROBLEM_2169_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2169 : public problem {
public:
    bool test() override;

    int countOperations(int num1, int num2);
};



#endif //PROBLEM_2169_H
