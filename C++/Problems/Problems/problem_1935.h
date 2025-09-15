#ifndef PROBLEM_1935_H
#define PROBLEM_1935_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1935 : public problem {
public:
    bool test() override;

    int canBeTypedWords(std::string text, std::string brokenLetters);
};



#endif //PROBLEM_1935_H
