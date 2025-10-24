#ifndef PROBLEM_946_H
#define PROBLEM_946_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_946 : public problem {
public:
    bool test() override;

    bool validateStackSequences(std::vector<int>& pushed, std::vector<int>& popped);
};



#endif //PROBLEM_946_H
