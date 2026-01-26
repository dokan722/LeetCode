#ifndef PROBLEM_1200_H
#define PROBLEM_1200_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1200 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> minimumAbsDifference(std::vector<int>& arr) ;
};

#endif //PROBLEM_1200_H
