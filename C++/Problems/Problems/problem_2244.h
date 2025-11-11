#ifndef PROBLEM_2244_H
#define PROBLEM_2244_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2244 : public problem {
public:
    bool test() override;

    int minimumRounds(std::vector<int>& tasks);
};





#endif //PROBLEM_2244_H
