#ifndef PROBLEMS_PROBLEM_1401_H
#define PROBLEMS_PROBLEM_1401_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>
#include<stack>

class problem_1401 : public problem {
public:
    bool test() override;

    bool checkOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2);
};

#endif //PROBLEMS_PROBLEM_1401_H