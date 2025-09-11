#ifndef PROBLEM_985_H
#define PROBLEM_985_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_985 : public problem {
public:
    bool test() override;

    std::vector<int> sumEvenAfterQueries(std::vector<int>& nums, std::vector<std::vector<int>>& queries);
};



#endif //PROBLEM_985_H
