#ifndef PROBLEM_2469_H
#define PROBLEM_2469_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2469 : public problem {
public:
    bool test() override;

    std::vector<double> convertTemperature(double celsius);
};

#endif //PROBLEM_2469_H
