#ifndef PROBLEM_3307_H
#define PROBLEM_3307_H

#include "../problem.h"
#include <vector>

class problem_3307 : public problem {
public:
    bool test() override;

    char kthCharacter(long long k, std::vector<int>& operations);
};



#endif //PROBLEM_3307_H
