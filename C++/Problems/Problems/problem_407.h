#ifndef PROBLEM_407_H
#define PROBLEM_407_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_407 : public problem {
public:
    bool test() override;

    int trapRainWater(std::vector<std::vector<int>>& heightMap);
};



#endif //PROBLEM_407_H
