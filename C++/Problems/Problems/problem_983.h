#ifndef PROBLEM_983_H
#define PROBLEM_983_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_983 : public problem {
public:
    bool test() override;

    int mincostTickets(std::vector<int>& days, std::vector<int>& costs);
};



#endif //PROBLEM_983_H
