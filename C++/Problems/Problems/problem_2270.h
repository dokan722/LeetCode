#ifndef PROBLEM_2270_H
#define PROBLEM_2270_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2270 : public problem {
public:
    bool test() override;

    int waysToSplitArray(std::vector<int>& nums);
};



#endif //PROBLEM_2270_H
