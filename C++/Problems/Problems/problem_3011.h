#ifndef PROBLEM_3011_H
#define PROBLEM_3011_H

#include "../problem.h"
#include <vector>

class problem_3011 : public problem {
public:
    bool test() override;

    bool canSortArray(std::vector<int>& nums);
private:
    int countBits(int num);
};



#endif //PROBLEM_3011_H
