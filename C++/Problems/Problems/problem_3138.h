#ifndef PROBLEM_3138_H
#define PROBLEM_3138_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3138 : public problem {
public:
    bool test() override;

    int minAnagramLength(std::string s);
private:
    std::vector<int> countLetters(std::string s);
    int gcd(int bigger, int lower);
};



#endif //PROBLEM_3138_H
