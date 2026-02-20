#ifndef PROBLEMS_PROBLEM_761_H
#define PROBLEMS_PROBLEM_761_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_761 : public problem {
public:
    bool test() override;

    std::string makeLargestSpecial(std::string s) ;
};

#endif //PROBLEMS_PROBLEM_761_H