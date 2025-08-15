#ifndef PROBLEM_3232_H
#define PROBLEM_3232_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_3232 : public problem {
public:
    bool test() override;

    bool canAliceWin(std::vector<int>& nums);
};



#endif //PROBLEM_3232_H
