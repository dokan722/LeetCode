#ifndef PROBLEMS_PROBLEM_1276_H
#define PROBLEMS_PROBLEM_1276_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1276 : public problem {
public:
    bool test() override;

    std::vector<int> numOfBurgers(int tomatoSlices, int cheeseSlices);
};

#endif //PROBLEMS_PROBLEM_1276_H