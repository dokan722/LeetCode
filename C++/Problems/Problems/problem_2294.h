#ifndef PROBLEM_2294_H
#define PROBLEM_2294_H



#include "../problem.h"
#include <vector>


class problem_2294 : public problem {
public:
    bool test() override;

    int partitionArray(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2294_H
