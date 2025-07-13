#ifndef PROBLEM_2410_H
#define PROBLEM_2410_H

#include "../problem.h"
#include <vector>

class problem_2410 : public problem {
public:
    bool test() override;

    int matchPlayersAndTrainers(std::vector<int>& players, std::vector<int>& trainers);
};



#endif //PROBLEM_2410_H
