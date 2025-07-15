#ifndef PROBLEM_3136_H
#define PROBLEM_3136_H

#include "../problem.h"
#include <string>

class problem_3136 : public problem {
public:
    bool test() override;

    bool isValid(std::string word);
};



#endif //PROBLEM_3136_H
