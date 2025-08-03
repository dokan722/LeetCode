#ifndef PROBLEM_1790_H
#define PROBLEM_1790_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1790 : public problem {
public:
    bool test() override;

    bool areAlmostEqual(std::string s1, std::string s2);
};



#endif //PROBLEM_1790_H
