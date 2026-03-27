#ifndef PROBLEMS_PROBLEM_2946_H
#define PROBLEMS_PROBLEM_2946_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2946 : public problem {
public:
    bool test() override;

    bool areSimilar(std::vector<std::vector<int>>& mat, int k);
};

#endif //PROBLEMS_PROBLEM_2946_H