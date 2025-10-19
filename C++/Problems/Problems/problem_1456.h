#ifndef PROBLEM_1456_H
#define PROBLEM_1456_H

#include <set>

#include "../problem.h"
#include <string>
#include <vector>

class problem_1456 : public problem {
public:
    bool test() override;

    int maxVowels(std::string s, int k);
private:
    bool isVowel(char c);
};



#endif //PROBLEM_1456_H
