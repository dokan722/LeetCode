#ifndef PROBLEMS_PROBLEM_3271_H
#define PROBLEMS_PROBLEM_3271_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3271 : public problem {
public:
    bool test() override;

    std::string stringHash(std::string s, int k);
};


#endif //PROBLEMS_PROBLEM_3271_H