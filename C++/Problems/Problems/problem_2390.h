#ifndef PROBLEM_2390_H
#define PROBLEM_2390_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2390 : public problem {
public:
    bool test() override;

    std::string removeStars(std::string s);
};



#endif //PROBLEM_2390_H
