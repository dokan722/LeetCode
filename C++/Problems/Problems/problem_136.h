#ifndef PROBLEM_136_H
#define PROBLEM_136_H



#include "../problem.h"
#include <vector>


class problem_136 : public problem {
public:
    bool test() override;

    int singleNumber(std::vector<int>& nums);
};



#endif //PROBLEM_136_H
