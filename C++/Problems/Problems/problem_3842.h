#ifndef PROBLEM_3842_H
#define PROBLEM_3842_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3842 : public problem {
public:
    bool test() override;

    std::vector<int> toggleLightBulbs(std::vector<int>& bulbs);
};

#endif //PROBLEM_3842_H
