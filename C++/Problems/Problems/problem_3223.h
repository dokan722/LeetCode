#ifndef PROBLEM_3223_H
#define PROBLEM_3223_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3223 : public problem {
public:
    bool test() override;

    int minimumLength(std::string s);
};



#endif //PROBLEM_3223_H
