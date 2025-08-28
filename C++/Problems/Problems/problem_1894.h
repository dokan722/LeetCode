#ifndef PROBLEM_1894_H
#define PROBLEM_1894_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1894 : public problem {
public:
    bool test() override;

    int chalkReplacer(std::vector<int>& chalk, int k);
};



#endif //PROBLEM_1894_H
