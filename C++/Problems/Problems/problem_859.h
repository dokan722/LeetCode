#ifndef PROBLEM_859_H
#define PROBLEM_859_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_859 : public problem {
public:
    bool test() override;

    bool buddyStrings(std::string s, std::string goal);
};

#endif //PROBLEM_859_H
