#ifndef PROBLEM_2966_H
#define PROBLEM_2966_H



#include "../problem.h"
#include <vector>


class problem_2966 : public problem {
public:
    bool test() override;

    std::vector<std::vector<int>> divideArray(std::vector<int>& nums, int k);
};


#endif //PROBLEM_2966_H
