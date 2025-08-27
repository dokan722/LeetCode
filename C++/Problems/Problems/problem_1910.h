#ifndef PROBLEM_1910_H
#define PROBLEM_1910_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1910 : public problem {
public:
    bool test() override;

    std::string removeOccurrences(std::string s, std::string part);
};



#endif //PROBLEM_1910_H
