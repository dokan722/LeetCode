#ifndef PROBLEM_1525_H
#define PROBLEM_1525_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1525 : public problem {
public:
    bool test() override;

    int numSplits(std::string s);
};



#endif //PROBLEM_1525_H
