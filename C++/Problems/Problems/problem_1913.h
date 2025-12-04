#ifndef PROBLEM_1913_H
#define PROBLEM_1913_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1913 : public problem {
public:
    bool test() override;

    int maxProductDifference(std::vector<int>& nums);
};

#endif //PROBLEM_1913_H
