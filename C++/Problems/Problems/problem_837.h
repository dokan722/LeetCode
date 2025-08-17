#ifndef PROBLEM_837_H
#define PROBLEM_837_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_837 : public problem {
public:
    bool test() override;

    double new21Game(int n, int k, int maxPts);
};



#endif //PROBLEM_837_H
