#ifndef PROBLEM_1717_H
#define PROBLEM_1717_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1717 : public problem {
public:
    bool test() override;

    int maximumGain(std::string s, int x, int y);
};



#endif //PROBLEM_1717_H
