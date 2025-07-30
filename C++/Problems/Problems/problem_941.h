#ifndef PROBLEM_941_H
#define PROBLEM_941_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_941 : public problem {
public:
    bool test() override;

    bool validMountainArray(std::vector<int>& arr);
};



#endif //PROBLEM_941_H
