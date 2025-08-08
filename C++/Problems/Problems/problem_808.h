#ifndef PROBLEM_808_H
#define PROBLEM_808_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_808 : public problem {
public:
    bool test() override;

    double soupServings(int n);
private:
    double getProb(std::vector<std::vector<double>>& dp, int a, int b);
};



#endif //PROBLEM_808_H
