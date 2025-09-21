#ifndef PROBLEM_3090_H
#define PROBLEM_3090_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3090: public problem {
public:
    bool test() override;

    int maximumLengthSubstring(std::string s);
};



#endif //PROBLEM_3090_H
