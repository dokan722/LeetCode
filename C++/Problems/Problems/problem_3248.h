#ifndef PROBLEM_3248_H
#define PROBLEM_3248_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3248 : public problem {
public:
    bool test() override;

    int finalPositionOfSnake(int n, std::vector<std::string>& commands);
};



#endif //PROBLEM_3248_H
