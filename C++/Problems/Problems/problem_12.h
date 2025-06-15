#ifndef PROBLEM_12_H
#define PROBLEM_12_H

#include "../problem.h"
#include <string>


class problem_12 : public problem
{
public:
    bool test() override;

    std::string intToRoman(int num);
private:
    void appendStuff(std::string &result, char one, char five, char dec, char src);
};



#endif //PROBLEM_12_H
