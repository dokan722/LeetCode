#ifndef PROBLEM_1524_H
#define PROBLEM_1524_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1524 : public problem {
public:
    bool test() override;

    int numOfSubarrays(std::vector<int>& arr);
};



#endif //PROBLEM_1524_H
