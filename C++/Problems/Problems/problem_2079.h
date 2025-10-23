#ifndef PROBLEM_2079_H
#define PROBLEM_2079_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2079 : public problem {
public:
    bool test() override;

    int wateringPlants(std::vector<int>& plants, int capacity);
};



#endif //PROBLEM_2079_H
