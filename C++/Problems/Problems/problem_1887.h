#ifndef PROBLEM_1887_H
#define PROBLEM_1887_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1887 : public problem {
public:
    bool test() override;

    int reductionOperations(std::vector<int>& nums);
};



#endif //PROBLEM_1887_H
