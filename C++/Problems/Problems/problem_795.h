#ifndef PROBLEM_795_H
#define PROBLEM_795_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_795 : public problem {
public:
    bool test() override;

    int numSubarrayBoundedMax(std::vector<int>& nums, int left, int right);
private:
    int getProperSubarrays(int index, int count, std::vector<int> properElements);
};



#endif //PROBLEM_795_H
