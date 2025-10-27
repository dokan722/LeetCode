#ifndef PROBLEM_2125_H
#define PROBLEM_2125_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2125 : public problem {
public:
    bool test() override;

    int numberOfBeams(std::vector<std::string>& bank);
};



#endif //PROBLEM_2125_H
