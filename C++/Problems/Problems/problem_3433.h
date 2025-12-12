#ifndef PROBLEMS_PROBLEM_3433_H
#define PROBLEMS_PROBLEM_3433_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_3433 : public problem {
public:
    bool test() override;

    std::vector<int> countMentions(int numberOfUsers, std::vector<std::vector<std::string>>& events);
};

#endif //PROBLEMS_PROBLEM_3433_H