#ifndef PROBLEM_3325_H
#define PROBLEM_3325_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3325 : public problem {
public:
    bool test() override;

    int numberOfSubstrings(std::string s, int k);
};



#endif //PROBLEM_3325_H
