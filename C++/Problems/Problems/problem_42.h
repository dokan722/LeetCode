#ifndef PROBLEM_42_H
#define PROBLEM_42_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_42 : public problem {
public:
    bool test() override;

    int trap(std::vector<int>& height);
};



#endif //PROBLEM_42_H
