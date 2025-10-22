#ifndef PROBLEM_1769_H
#define PROBLEM_1769_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1769 : public problem {
public:
    bool test() override;

    std::vector<int> minOperations(std::string boxes);
};



#endif //PROBLEM_1769_H
