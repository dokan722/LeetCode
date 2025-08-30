#ifndef PROBLEM_316_H
#define PROBLEM_316_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_316 : public problem {
public:
    bool test() override;

    std::string removeDuplicateLetters(std::string s);
};



#endif //PROBLEM_316_H
