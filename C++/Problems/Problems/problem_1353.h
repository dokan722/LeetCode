#ifndef PROBLEM_1353_H
#define PROBLEM_1353_H

#include "../problem.h"
#include <vector>

class problem_1353 : public problem {
public:
    bool test() override;

    int maxEvents(std::vector<std::vector<int>>& events);
};



#endif //PROBLEM_1353_H
