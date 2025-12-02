#ifndef PROBLEM_2405_H
#define PROBLEM_2405_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2405 : public problem {
public:
    bool test() override;

    int partitionString(std::string s);
};


#endif //PROBLEM_2405_H
