#ifndef PROBLEM_2315_H
#define PROBLEM_2315_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2315 : public problem {
public:
    bool test() override;

    int countAsterisks(std::string s);
};



#endif //PROBLEM_2315_H
