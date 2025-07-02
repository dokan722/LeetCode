#ifndef PROBLEM_1968_H
#define PROBLEM_1968_H



#include "../problem.h"
#include <vector>

class problem_1968 : public problem {
public:
    bool test() override;

    std::vector<int> rearrangeArray(std::vector<int>& nums);
};



#endif //PROBLEM_1968_H
