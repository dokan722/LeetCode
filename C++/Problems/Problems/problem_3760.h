#ifndef PROBLEMS_PROBLEM_3760_H
#define PROBLEMS_PROBLEM_3760_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3760 : public problem {
public:
    bool test() override;

    int maxDistinct(std::string s);
};

#endif //PROBLEMS_PROBLEM_3760_H