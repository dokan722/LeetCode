#ifndef PROBLEM_3234_H
#define PROBLEM_3234_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3234 : public problem {
public:
    bool test() override;

    int numberOfSubstrings(std::string s);
};



#endif //PROBLEM_3234_H
