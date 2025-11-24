#ifndef PROBLEM_3222_H
#define PROBLEM_3222_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3222 : public problem {
public:
    bool test() override;

    std::string winningPlayer(int x, int y);
};



#endif //PROBLEM_3222_H
