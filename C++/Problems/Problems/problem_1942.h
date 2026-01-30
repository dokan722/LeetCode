#ifndef PROBLEMS_PROBLEM_1942_H
#define PROBLEMS_PROBLEM_1942_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1942 : public problem {
public:
    bool test() override;

    int smallestChair(std::vector<std::vector<int>>& times, int targetFriend);
};

#endif //PROBLEMS_PROBLEM_1942_H