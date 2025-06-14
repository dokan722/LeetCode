#ifndef PROBLEM_11_H
#define PROBLEM_11_H



#include <vector>

#include "../problem.h"

class problem_11 : public problem {
public:
    bool test() override;

    int maxArea(std::vector<int>& height);
};



#endif //PROBLEM_11_H
