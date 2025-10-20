#ifndef PROBLEM_852_H
#define PROBLEM_852_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_852 : public problem {
public:
    bool test() override;

    int peakIndexInMountainArray(std::vector<int>& arr);
};



#endif //PROBLEM_852_H
