#ifndef PROBLEM_1792_H
#define PROBLEM_1792_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1792 : public problem {
public:
    bool test() override;

    double maxAverageRatio(std::vector<std::vector<int>>& classes, int extraStudents);
};



#endif //PROBLEM_1792_H
