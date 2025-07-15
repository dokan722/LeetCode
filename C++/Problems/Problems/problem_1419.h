#ifndef PROBLEM_1419_H
#define PROBLEM_1419_H

#include "../problem.h"
#include <string>

class problem_1419 : public problem {
public:
    bool test() override;

    int minNumberOfFrogs(std::string croakOfFrogs);
};



#endif //PROBLEM_1419_H
