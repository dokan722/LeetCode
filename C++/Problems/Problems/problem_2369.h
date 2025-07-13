#ifndef PROBLEM_2369_H
#define PROBLEM_2369_H

#include "../problem.h"
#include <vector>

class problem_2369 : public problem {
public:
    bool test() override;

    bool validPartition(std::vector<int>& nums);
private:
    bool CheckTwo(std::vector<int>& nums, int index);
    bool CheckThree(std::vector<int>& nums, int index);
};



#endif //PROBLEM_2369_H
