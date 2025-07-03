#ifndef PROBLEM_2856_H
#define PROBLEM_2856_H

#include "../problem.h"
#include <vector>

class problem_2856 : public problem {
public:
    bool test() override;

    int minLengthAfterRemovals(std::vector<int>& nums);
};



#endif //PROBLEM_2856_H
