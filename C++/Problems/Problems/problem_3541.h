#ifndef PROBLEM_3541_H
#define PROBLEM_3541_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3541 : public problem {
public:
    bool test() override;

    int maxFreqSum(std::string s);
};



#endif //PROBLEM_3541_H
