#ifndef PROBLEM_3025_H
#define PROBLEM_3025_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3025 : public problem {
public:
    bool test() override;

    int numberOfPairs(std::vector<std::vector<int>>& points);
private:
    static bool comparePoints(const std::vector<int>& x, const std::vector<int>& y);
};



#endif //PROBLEM_3025_H
