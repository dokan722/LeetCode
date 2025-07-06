#ifndef PROBLEM_2212_H
#define PROBLEM_2212_H

#include "../problem.h"
#include <vector>

class problem_2212 : public problem {
public:
    bool test() override;

    std::vector<int> maximumBobPoints(int numArrows, std::vector<int>& aliceArrows);
private:
    std::vector<int> transformToBitArray(int num);
};



#endif //PROBLEM_2212_H
