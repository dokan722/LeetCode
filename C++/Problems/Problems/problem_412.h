#ifndef PROBLEMS_PROBLEM_412_H
#define PROBLEMS_PROBLEM_412_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_412 : public problem {
public:
    bool test() override;

    std::vector<std::string> fizzBuzz(int n);
};

#endif //PROBLEMS_PROBLEM_412_H