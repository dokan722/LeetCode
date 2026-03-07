#ifndef PROBLEM_769_H
#define PROBLEM_769_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_769 : public problem {
public:
    bool test() override;

    int maxChunksToSorted(std::vector<int>& arr);
};

#endif //PROBLEM_769_H
