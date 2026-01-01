#ifndef PROBLEMS_PROBLEM66_H
#define PROBLEMS_PROBLEM66_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_66 : public problem {
public:
    bool test() override;

    std::vector<int> plusOne(std::vector<int>& digits);
};

#endif //PROBLEMS_PROBLEM66_H