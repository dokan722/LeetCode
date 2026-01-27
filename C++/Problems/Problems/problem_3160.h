#ifndef PROBLEM_3160_H
#define PROBLEM_3160_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3160 : public problem {
public:
    bool test() override;

    std::vector<int> queryResults(int limit, std::vector<std::vector<int>>& queries);
};

#endif //PROBLEM_3160_H
