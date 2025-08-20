#ifndef PROBLEM_1619_H
#define PROBLEM_1619_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1619 : public problem {
public:
    bool test() override;

    double trimMean(std::vector<int>& arr);
};



#endif //PROBLEM_1619_H
