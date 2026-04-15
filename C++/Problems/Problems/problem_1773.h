#ifndef PROBLEM_1773_H
#define PROBLEM_1773_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1773 : public problem {
public:
    bool test() override;

    int countMatches(std::vector<std::vector<std::string>>& items, std::string ruleKey, std::string ruleValue);
};

#endif //PROBLEM_1773_H
