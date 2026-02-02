#ifndef PROBLEMS_PROBLEM_2491_H
#define PROBLEMS_PROBLEM_2491_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2491 : public problem {
public:
    bool test() override;

    long long dividePlayers(std::vector<int>& skill) ;
};

#endif //PROBLEMS_PROBLEM_2491_H