#ifndef PROBLEM_2274_H
#define PROBLEM_2274_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2274 : public problem {
public:
    bool test() override;

    int maxConsecutive(int bottom, int top, std::vector<int>& special);
};



#endif //PROBLEM_2274_H
