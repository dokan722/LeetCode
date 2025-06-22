#ifndef PROBLEM_334_H
#define PROBLEM_334_H



#include "../problem.h"
#include <vector>


class problem_334 : public problem {
public:
    bool test() override;

    bool increasingTriplet(std::vector<int>& nums);
};



#endif //PROBLEM_334_H
