#ifndef PROBLEM_2679_H
#define PROBLEM_2679_H



#include "../problem.h"
#include <vector>


class problem_2679 : public problem {
public:
    bool test() override;

    int matrixSum(std::vector<std::vector<int>>& nums);
};


#endif //PROBLEM_2679_H
