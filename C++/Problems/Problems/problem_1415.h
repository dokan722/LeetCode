#ifndef PROBLEM_1415_H
#define PROBLEM_1415_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1415 : public problem {
public:
    bool test() override;

    std::string getHappyString(int n, int k);
};



#endif //PROBLEM_1415_H
