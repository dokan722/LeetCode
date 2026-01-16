#ifndef PROBLEMS_PROBLEM_2975_H
#define PROBLEMS_PROBLEM_2975_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_2975 : public problem {
public:
    bool test() override;

    int maximizeSquareArea(int m, int n, std::vector<int>& hFences, std::vector<int>& vFences);
};

#endif //PROBLEMS_PROBLEM_2975_H