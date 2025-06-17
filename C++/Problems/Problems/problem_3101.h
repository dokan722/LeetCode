#ifndef PROBLEM_3101_H
#define PROBLEM_3101_H



#include "../problem.h"
#include <vector>


class problem_3101 : public problem {
public:
    bool test() override;

    long long countAlternatingSubarrays(std::vector<int>& nums);
};



#endif //PROBLEM_3101_H
