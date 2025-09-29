#ifndef PROBLEM_3211_H
#define PROBLEM_3211_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3211: public problem {
public:
    bool test() override;

    std::vector<std::string> validStrings(int n);
};



#endif //PROBLEM_3211_H
