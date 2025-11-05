#ifndef PROBLEM_2027_H
#define PROBLEM_2027_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2027 : public problem {
public:
    bool test() override;

    int minimumMoves(std::string s);
};



#endif //PROBLEM_2027_H
