#ifndef PROBLEM_747_H
#define PROBLEM_747_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_747 : public problem {
public:
    bool test() override;

    int dominantIndex(std::vector<int>& nums);
};



#endif //PROBLEM_747_H
