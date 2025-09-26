#ifndef PROBLEM_2038_H
#define PROBLEM_2038_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2038: public problem {
public:
    bool test() override;

    bool winnerOfGame(std::string colors);
};



#endif //PROBLEM_2038_H
