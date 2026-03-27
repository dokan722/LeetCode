#ifndef PROBLEMS_PROBLEM_1897_H
#define PROBLEMS_PROBLEM_1897_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1897 : public problem {
public:
    bool test() override;

    bool makeEqual(std::vector<std::string>& words);
};

#endif //PROBLEMS_PROBLEM_1897_H