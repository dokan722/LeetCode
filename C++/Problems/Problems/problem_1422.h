#ifndef PROBLEM_1422_H
#define PROBLEM_1422_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1422 : public problem {
public:
    bool test() override;

    int maxScore(std::string s);
};



#endif //PROBLEM_1422_H
