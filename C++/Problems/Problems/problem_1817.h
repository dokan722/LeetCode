#ifndef PROBLEM_1817_H
#define PROBLEM_1817_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1817 : public problem {
public:
    bool test() override;

    std::vector<int> findingUsersActiveMinutes(std::vector<std::vector<int>>& logs, int k);
};



#endif //PROBLEM_1817_H
