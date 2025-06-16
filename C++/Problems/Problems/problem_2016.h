#ifndef PROBLEM_2016_H
#define PROBLEM_2016_H



#include "../problem.h"
#include <vector>


class problem_2016 : public problem
{
public:
    bool test() override;

    int maximumDifference(std::vector<int>& nums);
};



#endif //PROBLEM_2016_H
