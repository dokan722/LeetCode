#ifndef PROBLEM_3623_H
#define PROBLEM_3623_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3623 : public problem {
public:
    bool test() override;

    int countTrapezoids(std::vector<std::vector<int>>& points);
};


#endif //PROBLEM_3623_H
