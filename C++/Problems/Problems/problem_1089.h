#ifndef PROBLEM_1089_H
#define PROBLEM_1089_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1089 : public problem {
public:
    bool test() override;

    void duplicateZeros(std::vector<int>& arr);
};



#endif //PROBLEM_1089_H
