#ifndef PROBLEM_2785_H
#define PROBLEM_2785_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2785 : public problem {
public:
    bool test() override;

    std::string sortVowels(std::string s);
private:
    bool isVowel(char c);
};



#endif //PROBLEM_2785_H
