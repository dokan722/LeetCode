#ifndef PROBLEM_3147_H
#define PROBLEM_3147_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3147 : public problem {
public:
    bool test() override;

    int maximumEnergy(std::vector<int>& energy, int k);
};



#endif //PROBLEM_3147_H
