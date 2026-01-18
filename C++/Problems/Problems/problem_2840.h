#ifndef PROBLEMS_PROBLEM_2840_H
#define PROBLEMS_PROBLEM_2840_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2840 : public problem {
public:
    bool test() override;

    bool checkStrings(std::string s1, std::string s2);
};

#endif //PROBLEMS_PROBLEM_2840_H