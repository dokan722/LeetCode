#ifndef PROBLEM_976_H
#define PROBLEM_976_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_976: public problem {
public:
    bool test() override;

    int largestPerimeter(std::vector<int>& nums);
};



#endif //PROBLEM_976_H
