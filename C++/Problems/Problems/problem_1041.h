#ifndef PROBLEMS_PROBLEM_1041_H
#define PROBLEMS_PROBLEM_1041_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1041 : public problem {
public:
    bool test() override;

    bool isRobotBounded(std::string instructions);
};

#endif //PROBLEMS_PROBLEM_1041_H