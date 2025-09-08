#ifndef PROBLEM_1317_H
#define PROBLEM_1317_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1317 : public problem {
public:
    bool test() override;

    std::vector<int> getNoZeroIntegers(int n);
};



#endif //PROBLEM_1317_H
