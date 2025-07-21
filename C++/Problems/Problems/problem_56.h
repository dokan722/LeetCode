#ifndef PROBLEM_56_H
#define PROBLEM_56_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_56 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> merge(std::vector<std::vector<int>>& intervals);
};



#endif //PROBLEM_56_H
