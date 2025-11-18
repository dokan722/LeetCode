#ifndef PROBLEM_784_H
#define PROBLEM_784_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_784 : public problem {
public:
    bool test() override;

    std::vector<std::string> letterCasePermutation(std::string s);
};



#endif //PROBLEM_784_H
