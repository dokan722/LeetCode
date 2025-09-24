#ifndef PROBLEM_3210_H
#define PROBLEM_3210_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3210: public problem {
public:
    bool test() override;

    std::string getEncryptedString(std::string s, int k);
};



#endif //PROBLEM_3210_H
