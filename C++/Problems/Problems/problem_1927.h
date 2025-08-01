#ifndef PROBLEM_1927_H
#define PROBLEM_1927_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1927 : public problem {
public:
    bool test() override;

    bool sumGame(std::string num);
};



#endif //PROBLEM_1927_H
