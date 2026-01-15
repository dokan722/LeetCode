#ifndef PROBLEMS_PROBLEM_1450_H
#define PROBLEMS_PROBLEM_1450_H

#include "../problem.h"
#include <string>
#include <vector>



class problem_1450 : public problem {
public:
    bool test() override;

    int busyStudent(std::vector<int>& startTime, std::vector<int>& endTime, int queryTime);
};

#endif //PROBLEMS_PROBLEM_1450_H