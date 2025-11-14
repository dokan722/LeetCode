#ifndef PROBLEM_2536_H
#define PROBLEM_2536_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2536 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> rangeAddQueries(int n, std::vector<std::vector<int>>& queries);
};



#endif //PROBLEM_2536_H
