#ifndef PROBLEM_2108_H
#define PROBLEM_2108_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2108 : public problem {
public:
    bool test() override;

    std::string firstPalindrome(std::vector<std::string>& words);
};



#endif //PROBLEM_2108_H
