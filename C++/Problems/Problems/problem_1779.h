#ifndef PROBLEM_1779_H
#define PROBLEM_1779_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1779 : public problem {
public:
    bool test() override;

    int nearestValidPoint(int x, int y, std::vector<std::vector<int>>& points);
};



#endif //PROBLEM_1779_H
