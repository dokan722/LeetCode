#ifndef PROBLEM_2138_H
#define PROBLEM_2138_H

#include "../problem.h"
#include <vector>
#include <string>


class problem_2138 : public problem {
public:
    bool test() override;

    std::vector<std::string> divideString(std::string s, int k, char fill);
};




#endif //PROBLEM_2138_H
