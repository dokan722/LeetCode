#ifndef PROBLEM_757_H
#define PROBLEM_757_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_757 : public problem {
public:
    bool test() override;

    int intersectionSizeTwo(std::vector<std::vector<int>>& intervals);
};



#endif //PROBLEM_757_H
