#ifndef PROBLEM_1653_H
#define PROBLEM_1653_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1653 : public problem {
public:
    bool test() override;

    int minimumDeletions(std::string s);
};

#endif //PROBLEM_1653_H
