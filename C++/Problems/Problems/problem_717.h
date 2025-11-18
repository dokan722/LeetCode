#ifndef PROBLEM_717_H
#define PROBLEM_717_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_717 : public problem {
public:
    bool test() override;

    bool isOneBitCharacter(std::vector<int>& bits);
};



#endif //PROBLEM_717_H
