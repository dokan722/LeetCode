#ifndef PROBLEM_841_H
#define PROBLEM_841_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_841 : public problem {
public:
    bool test() override;

    bool canVisitAllRooms(std::vector<std::vector<int>>& rooms);
};



#endif //PROBLEM_841_H
