#ifndef PROBLEM_3120_H
#define PROBLEM_3120_H



#include "../problem.h"
#include <string>

class problem_3120 : public problem {
public:
    bool test() override;

    int numberOfSpecialChars(std::string word);
};



#endif //PROBLEM_3120_H
