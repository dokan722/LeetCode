#ifndef PROBLEM_3354_H
#define PROBLEM_3354_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3354 : public problem {
public:
    bool test() override;

    int countValidSelections(std::vector<int>& nums);
};



#endif //PROBLEM_3354_H
