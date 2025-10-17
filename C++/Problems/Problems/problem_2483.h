#ifndef PROBLEM_2483_H
#define PROBLEM_2483_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2483 : public problem {
public:
    bool test() override;

    int bestClosingTime(std::string customers);
};



#endif //PROBLEM_2483_H
