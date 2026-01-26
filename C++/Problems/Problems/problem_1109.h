#ifndef PROBLEM_1109_H
#define PROBLEM_1109_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1109 : public problem {
public:
    bool test() override;

    std::vector<int> corpFlightBookings(std::vector<std::vector<int>>& bookings, int n);
};

#endif //PROBLEM_1109_H
