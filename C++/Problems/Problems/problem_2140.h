#ifndef PROBLEM_2140_H
#define PROBLEM_2140_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2140 : public problem {
public:
    bool test() override;

    long long mostPoints(std::vector<std::vector<int>>& questions);
};



#endif //PROBLEM_2140_H
