#ifndef PROBLEM_791_H
#define PROBLEM_791_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_791 : public problem {
public:
    bool test() override;

    std::string customSortString(std::string order, std::string s);
};



#endif //PROBLEM_791_H
